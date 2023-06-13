
using System.Buffers;
using System.Runtime.Serialization;
using System.Text;
using VYaml.Annotations;

namespace StrideSourceGened
{
    public class FastWriter : TInherit2
    {
        /// <summary>
        /// The size of a 16 bit unsigned integer.
        /// <see cref="BinaryWriter"/> has also this as cap size until the strings get too large.
        /// </summary>
        private const int KiB64 = 64 * 1024;

        Stream OutStream;

        private readonly Encoding _encoding = Encoding.UTF8;
        ArrayBufferWriter<byte> arrayBufferWriter = new ArrayBufferWriter<byte>(KiB64);

        public FastWriter(Stream st)
        {
            OutStream = st;
        }
        public void Write(ref string value) 
        {
            // Avoid resizing too often
            if(arrayBufferWriter.FreeCapacity < KiB64 / 4)
                ArrayBufferFlush();

            if (value.Length <= 127 / 3)
            {
                // Max expansion: each char -> 3 bytes, so 127 bytes max of data, +1 for length prefix
                Span<byte> buffer = stackalloc byte[128];
                var actualByteCount = Encoding.UTF8.GetBytes(value, buffer.Slice(1));
                buffer[0] = (byte)actualByteCount;
                arrayBufferWriter.Write(buffer.Slice(0, actualByteCount + 1));
                return;
            }
            else if (value.Length <= KiB64 / 3)
            {
                byte[] rented = ArrayPool<byte>.Shared.Rent(value.Length * 3); // max expansion: each char -> 3 bytes
                int actualByteCount = _encoding.GetBytes(value, rented);
                Write7BitEncodedInt(actualByteCount);
                ArrayBufferFlush();
                OutStream.Write(rented, 0, actualByteCount);
                ArrayPool<byte>.Shared.Return(rented);
                return;
            }
            // string is too big to care about performance
            int actualBytecount = _encoding.GetByteCount(value);
            Write7BitEncodedInt(actualBytecount);
            WriteCharsCommonWithoutLengthPrefix(value);
        }
        private void WriteCharsCommonWithoutLengthPrefix(ReadOnlySpan<char> chars)
        {
            Flush();
            // If our input is truly enormous, the call to GetMaxByteCount might overflow,
            // which we want to avoid. Theoretically, any Encoding could expand from chars -> bytes
            // at an enormous ratio and cause us problems anyway given small inputs, but this is so
            // unrealistic that we needn't worry about it.


            byte[] rented;

            if (chars.Length <= KiB64)
            {
                // GetByteCount may walk the buffer contents, resulting in 2 passes over the data.
                // We prefer GetMaxByteCount because it's a constant-time operation.

                int maxByteCount = _encoding.GetMaxByteCount(chars.Length);
                if (maxByteCount <= KiB64)
                {
                    rented = ArrayPool<byte>.Shared.Rent(maxByteCount);
                    int actualByteCount = _encoding.GetBytes(chars, rented);
                    OutStream.Write(rented, 0, actualByteCount);
                    ArrayPool<byte>.Shared.Return(rented);
                    return;
                }
            }

            // We're dealing with an enormous amount of data, so acquire an Encoder.
            // It should be rare that callers pass sufficiently large inputs to hit
            // this code path, and the cost of the operation is dominated by the transcoding
            // step anyway, so it's ok for us to take the allocation here.

            rented = ArrayPool<byte>.Shared.Rent(KiB64);
            Encoder encoder = _encoding.GetEncoder();
            bool completed;

            do
            {
                encoder.Convert(chars, rented, flush: true, out int charsConsumed, out int bytesWritten, out completed);
                if (bytesWritten != 0)
                {
                    OutStream.Write(rented, 0, bytesWritten);
                }

                chars = chars.Slice(charsConsumed);
            } while (!completed);

            ArrayPool<byte>.Shared.Return(rented);
        }
        private void ArrayBufferFlush()
        {
            OutStream.Write(arrayBufferWriter.WrittenSpan);
            arrayBufferWriter.Clear();
        }
        public void Flush()
        {
            ArrayBufferFlush();
            OutStream.Flush();
        }
        public void Write7BitEncodedInt(int value)
        {
            uint uValue = (uint)value;

            // Write out an int 7 bits at a time. The high bit of the byte,
            // when on, tells reader to continue reading more bytes.
            //
            // Using the constants 0x7F and ~0x7F below offers smaller
            // codegen than using the constant 0x80.
            while (uValue > 0x7Fu)
            {
                byte newByte = (byte)(uValue | ~0x7Fu);
                Serialize(ref newByte);
                uValue >>= 7;
            }
            var leftoverByte = (byte)uValue;
            Serialize(ref leftoverByte);
        }
        public void Serialize(ref byte value)
        {
            unsafe
            {
                fixed (byte* ptr = &value)
                {
                    var span = new Span<byte>(ptr, sizeof(byte));
                    arrayBufferWriter.Write(span);
                }
            }
        }
    }
}