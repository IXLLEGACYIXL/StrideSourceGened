using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StrideSourceGened.NexYaml;
public class NexYamlStream
{
    private BinaryWriter _writer;
    Stream stream;
    public NexYamlStream(Stream stream)
    {
        _writer = new BinaryWriter(stream,Encoding.UTF8);
    }

    public void Write(ref int primitive)
    {
        _writer.Write(primitive);
    }
    public void Write(ref string value)
    {
        WriteString(ref value);
    }
    private void WriteString(ref string value)
    {
        unsafe
        {
            fixed (char* ptr = value)
            {
                var charSpan = new Span<char>(ptr, value.Length);
                _writer.Write(charSpan);
            }
        }
    }
}
