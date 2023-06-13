using Microsoft.Diagnostics.Tracing.Stacks.Formats;
using StrideSourceGened;
using System.Buffers;
using System.Diagnostics;
using System.Text;
using YamlDotNet.Core.Tokens;

Stream st = File.OpenWrite("C:\\Godot\\Test3");
BinaryWriter bw = new BinaryWriter(st);
FastWriter fastWriter = new FastWriter(st);
var t = "asdfasdfasdfasdfasfdasdf";
var stop  = Stopwatch.StartNew();

for (int i = 0; i < 10000; i++)
{
    fastWriter.Write(ref t);
}

fastWriter.Flush();
stop.Stop();
Console.WriteLine(stop.Elapsed.Microseconds);

