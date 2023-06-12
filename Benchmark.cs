using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VYaml.Emitter;
using VYaml.Serialization;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace StrideSourceGened
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        [Params(1,100,1000,100000)]
        public int count;

        TestClass x = new TestClass()
        {
            FancyClass = new TestClass(),
        };

        GeneratedYamlSerializerTInherit x2 = new GeneratedYamlSerializerTInherit();
            Stream s ;
        [IterationSetup]
        public void SEtup()
        {
            global::VYaml.Serialization.GeneratedResolver.Register<TestClass>(new GeneratedYamlSerializerTestClass());

            s = File.OpenWrite($"C:\\Godot\\test{count}");
        }
        [IterationCleanup]
        public void Clean()
        {
            s.Flush();
            s.Close();
        }
        [Benchmark]
        public void Test()
        {
            YamlSerializerOptions options = new YamlSerializerOptions();

            for(int i = 0; i < count; i++)
            {
                var res = YamlSerializer.Serialize(x).Span;
                s.Write(res);
            }
        }
    }

}


