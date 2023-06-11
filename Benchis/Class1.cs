using BenchmarkDotNet.Attributes;
using StrideSourceGened.NexYaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSourceGened.Benchis;
[MemoryDiagnoser]
public class Class1
{
    private Stream stream = new MemoryStream();
    private NexYamlStream y;
    private const int integer = 1234801491;
    private const string HI = @"""
  !TestClass
Nubmers: 0
Nubmers2: 0
Number: 10
Test: hello mister
FancyClass: !TestClass
  Nubmers: 0
  Nubmers2: 0
  Number: 10
  Test: Hello recursive
  FancyClass: {}
  FancyClass2: {}
FancyClass2: {}
... = 12411325}\n
    """;
    [Params(1,10,100,1000,10000)]
    public int count;
    [IterationSetup]
    public void Setup()
    {
        stream = File.Create($"C:\\Godot\\g{count}.yaml");
        
        y = new NexYamlStream(stream);
    }
    [IterationCleanup]
    public void CleanUP()
    {
        stream.Flush();
        stream.Dispose();
    }
    [Benchmark]
    public void WriteInt()
    {
        var h = integer;
        for (int i = 0; i < count; i++)
        {
            y.Write(ref h);
        }
    }
}
