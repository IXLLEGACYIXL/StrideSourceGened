using BenchmarkDotNet.Running;
using CommandLine.Text;
using Microsoft.Diagnostics.Tracing.Stacks.Formats;
using OnlyForVerifiedGithubPublishers;
using StrideSourceGened;
using System.Buffers;
using System.Diagnostics;
using System.Text;
using VYaml.Emitter;
using VYaml.Parser;
using VYaml.Serialization;
new GeneratedYamlSerializerTInherit2<int>().Register();
new GeneratedYamlSerializerTInherit3().Register();
new GeneratedYamlSerializerTInherit().Register();
var x = File.ReadAllBytes("C:\\Godot\\tmp.yaml").AsMemory < byte>();
var t = YamlSerializer.Deserialize<ICloneable>(x);
Console.WriteLine(t);

