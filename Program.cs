// See https://aka.ms/new-console-template for more information
using Microsoft.CodeAnalysis;
using StrideSourceGened;
using YamlDotNet.Core.Events;
using YamlDotNet.Core;
using YamlDotNet.RepresentationModel;
using BenchmarkDotNet.Running;
using VYaml.Serialization;
using VYaml.Parser;
using VYaml.Emitter;


BenchmarkRunner.Run<Benchmark>();
// GeneratedYamlSerializerTestClass generatedYamlSerializerTestClass = new GeneratedYamlSerializerTestClass();