using BenchmarkDotNet.Running;
using Microsoft.Diagnostics.Tracing.Stacks.Formats;
using StrideSourceGened;
using System.Buffers;
using System.Diagnostics;
using System.Text;
using VYaml.Serialization;
using YamlDotNet.Core.Tokens;


new GeneratedYamlSerializerTInherit();
var x = new TInherit()
{
    Bob = new()
};

var x2 = YamlSerializer.SerializeToString(x);
ReadOnlyMemory<byte> myReadOnlyMemory = Encoding.UTF8.GetBytes(x2);
var result = YamlSerializer.Deserialize<TInherit>(myReadOnlyMemory);
Console.WriteLine(result);