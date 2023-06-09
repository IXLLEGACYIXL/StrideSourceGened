using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace StrideSourceGened
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        [Params(1,100,1000,10000)]
        public int count;

        TestClass x = new TestClass()
        {
            FancyClass = new TestClass()
            {
                Test = "Hello recursive"
            },
        };
    //    GeneratedSerializerTestClass ser = new GeneratedSerializerTestClass();

     /* [Benchmark]
        public void Test()
        {

            using var writer = File.CreateText($"C:\\Godot\\some-file.yaml{count}");

            Emitter emitter = new Emitter(writer);
            YamlStream stream = new YamlStream(count);
            
            foreach(var x2 in GetYamlDocuments())
            {
                stream.Add(x2);
            }
           stream.Save(writer,false);
            writer.Close();
           writer.Dispose();
        }
        public IEnumerable<YamlDocument> GetYamlDocuments()
        {
            for (int i = 0; i < count; i++)
            {
                yield return new YamlDocument(ser.ConvertToYaml(x));
            }
        }*/
        [Benchmark]
        public void ReadBench()
        {
            List<TestClass> testCases = new (count);
            using var reader = new StreamReader($"C:\\Godot\\some-file.yaml{count}");
            var g = new GeneratedSerializerTestClass();
            YamlStream stream = new();
            stream.Load( reader, count );
            g.serializerTemp = new GeneratedSerializerTestClass();
            g.serializerTemp.serializerTemp = new GeneratedSerializerTestClass();
            foreach(var x in stream.Documents)
            {
            testCases.Add(g.Deserialize((YamlMappingNode)x.RootNode));

            }
        }

    }

}


