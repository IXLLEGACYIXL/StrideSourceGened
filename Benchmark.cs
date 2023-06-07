using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;

namespace StrideSourceGened
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        [Params(1,100,1000,10000,100000)]
        public int count;

        TestClass x = new TestClass()
        {
            FancyClass = new TestClass()
            {
                Test = "Hello recursive"
            },
        };
        GeneratedSerializerTestClass ser = new GeneratedSerializerTestClass();
        [IterationSetup]
        public void Setup()
        {
        }
        [IterationCleanup]
        public void SEtup()
        {

        }
        [Benchmark]
        public void Test()
        {

            using var writer = File.CreateText("C:\\Godot\\some-file.yaml");

            List<YamlDocument> documents = new List<YamlDocument>(count);
            YamlStream st = new YamlStream();
            Emitter emitter = new Emitter(writer);
            for (int i = 0; i < count; i++)
            {
                documents.Add(new YamlDocument(ser.ConvertToYaml(x)));
            }
            st.Save(writer);
            writer.Close();
           writer.Dispose();
        }
    }
}


