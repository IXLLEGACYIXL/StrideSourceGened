// See https://aka.ms/new-console-template for more information
using Microsoft.CodeAnalysis;
using StrideSourceGened;
using YamlDotNet.Core.Events;
using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;
using System.Diagnostics;
using BenchmarkDotNet.Running;
using System.Runtime.ConstrainedExecution;
using YamlDotNet;
int count = 10000;
using var writer = File.CreateText($"C:\\Godot\\some-file.yaml{count}");

Emitter emitter = new Emitter(writer);
YamlStream stream = new YamlStream(count);
TestClass x = new TestClass()
{
    FancyClass = new TestClass()
    {
        Test = "Hello recursive"
    },
};
foreach (var x2 in GetYamlDocuments())
{
    stream.Add(x2);
}
stream.Save(writer, false);
writer.Close();
writer.Dispose();
IEnumerable<YamlDocument> GetYamlDocuments()
{
GeneratedSerializerTestClass ser = new GeneratedSerializerTestClass();
    for (int i = 0; i < count; i++)
    {
        yield return new YamlDocument(ser.ConvertToYaml(x));
    }
}