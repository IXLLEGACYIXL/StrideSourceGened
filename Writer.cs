using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stride.Core.Serialization
{
    /// <summary>
    /// Implements <see cref="SerializationStream"/> as a binary writer.
    /// </summary>
    public class BinarySerializationWriter : SerializationStream
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BinarySerializationWriter"/> class.
        /// </summary>
        /// <param name="outputStream">The output stream.</param>
        public BinarySerializationWriter([NotNull] Stream outputStream)
        {
            Writer = new BinaryWriter(outputStream);
            UnderlyingStream = outputStream;
        }

        private BinaryWriter Writer { get; }

        /// <inheritdoc />
        public override void Serialize(ref bool value)
        {
            UnderlyingStream.WriteByte(value ? (byte)1 : (byte)0);
        }

        /// <inheritdoc />
        public override unsafe void Serialize(ref float value)
        {
            unsafe
            {
                fixed (float* ptr = &value)
                {
                    var span = new Span<byte>(ptr, sizeof(float));
                    Writer.Write(span);
                }
            }
        }

        /// <inheritdoc />
        public override unsafe void Serialize(ref double value)
        {
            unsafe
            {
                fixed (double* ptr = &value)
                {
                    var span = new Span<byte>(ptr, sizeof(double));
                    Writer.Write(span);
                }
            }
        }

        /// <inheritdoc />
        public override void Serialize(ref short value)
        {
            unsafe
            {
                fixed (short* ptr = &value)
                {
                    var span = new Span<byte>(ptr, sizeof(short));
                    Writer.Write(span);
                }
            }
        }

        /// <inheritdoc />
        public override void Serialize(ref int value)
        {
            unsafe
            {
                fixed (int* ptr = &value)
                {
                    var span = new Span<byte>(ptr, sizeof(int));
                    Writer.Write(span);
                }
            }
        }

        /// <inheritdoc />
        public override void Serialize(ref long value)
        {
            unsafe
            {
                fixed (long* ptr = &value)
                {
                    var span = new Span<byte>(ptr, sizeof(long));
                    Writer.Write(span);
                }
            }
        }

        /// <inheritdoc />
        public override void Serialize(ref ushort value)
        {
            unsafe
            {
                fixed (ushort* ptr = &value)
                {
                    var span = new Span<byte>(ptr, sizeof(ushort));
                    Writer.Write(span);
                }
            }
        }

        /// <inheritdoc />
        public override void Serialize(ref uint value)
        {
            unsafe
            {
                fixed (uint* ptr = &value)
                {
                    var span = new Span<byte>(ptr, sizeof(uint));
                    Writer.Write(span);
                }
            }
        }

        /// <inheritdoc />
        public override void Serialize(ref ulong value)
        {
            unsafe
            {
                fixed (ulong* ptr = &value)
                {
                    var span = new Span<byte>(ptr, sizeof(ulong));
                    Writer.Write(span);
                }
            }
        }

        /// <inheritdoc />
        public override void Serialize(ref string value)
        {
            Writer.Write(value);
        }

        /// <inheritdoc />
        public override void Serialize(ref char value)
        {
            Writer.Write(value);
        }

        /// <inheritdoc />
        public override void Serialize(ref byte value)
        {
            unsafe
            {
                fixed (byte* ptr = &value)
                {
                    var span = new Span<byte>(ptr, sizeof(byte));
                    Writer.Write(span);
                }
            }
        }

        /// <inheritdoc />
        public override void Serialize(ref sbyte value)
        {
            unsafe
            {
                fixed (sbyte* ptr = &value)
                {
                    var span = new Span<byte>(ptr, sizeof(sbyte));
                    Writer.Write(span);
                }
            }
        }

        /// <inheritdoc />
        public override void Serialize([NotNull] byte[] values, int offset, int count)
        {
            UnderlyingStream.Write(values, offset, count);
        }

        /// <inheritdoc />
        public override void Serialize(Span<byte> buffer) => UnderlyingStream.Write(buffer);

        /// <inheritdoc />
        public override void Flush()
        {
            UnderlyingStream.Flush();
        }
    }
    /// <summary>
    /// Base class for implementation of <see cref="SerializationStream"/>.
    /// </summary>
    public abstract class SerializationStream
    {
        protected const int BufferTLSSize = 1024;

        /// <summary>
        /// The <see cref="Stream"/> from which this serializer reads or to which it writes.
        /// </summary>
        public Stream UnderlyingStream { get; protected set; } = new MemoryStream();

        /// <summary>
        /// Serializes the specified boolean value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref bool value);

        /// <summary>
        /// Serializes the specified float value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref float value);

        /// <summary>
        /// Serializes the specified double value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref double value);

        /// <summary>
        /// Serializes the specified short value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref short value);

        /// <summary>
        /// Serializes the specified integer value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref int value);

        /// <summary>
        /// Serializes the specified long value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref long value);

        /// <summary>
        /// Serializes the specified ushort value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref ushort value);

        /// <summary>
        /// Serializes the specified unsigned integer value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref uint value);

        /// <summary>
        /// Serializes the specified unsigned long value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref ulong value);

        /// <summary>
        /// Serializes the specified string value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref string value);

        /// <summary>
        /// Serializes the specified char value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref char value);

        /// <summary>
        /// Serializes the specified byte value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref byte value);

        /// <summary>
        /// Serializes the specified signed byte value.
        /// </summary>
        /// <param name="value">The value to serialize</param>
        public abstract void Serialize(ref sbyte value);

        /// <summary>
        /// Serializes the specified byte array.
        /// </summary>
        /// <param name="values">The buffer to serialize.</param>
        /// <param name="offset">The starting offset in the buffer to begin serializing.</param>
        /// <param name="count">The size, in bytes, to serialize.</param>
        public abstract void Serialize(byte[] values, int offset, int count);

        /// <summary>
        /// Serializes the specified memory area.
        /// </summary>
        /// <param name="memory">The memory area to serialize.</param>
        public abstract void Serialize(Span<byte> memory);

        /// <summary>
        /// Flushes all recent writes (for better batching).
        /// Please note that if only Serialize has been used (no PopTag()),
        /// Flush() should be called manually.
        /// </summary>
        public abstract void Flush();
    }

    // TODO: Switch to extensible/composite enumeration
    public class SerializationTagType
    {
        public static readonly SerializationTagType StartElement = new SerializationTagType();
        public static readonly SerializationTagType EndElement = new SerializationTagType();
        public static readonly SerializationTagType Identifier = new SerializationTagType();
    }

    public delegate void TagMarkedDelegate(SerializationStream stream, SerializationTagType tagType, object tagParam);
}