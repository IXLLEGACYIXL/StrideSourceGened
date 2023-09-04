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
var b = new TInherit2<string>();
b.ints.Add("hi -");
var s = YamlSerializer.SerializeToString(b);
File.WriteAllText("C:\\Godot\\tmp.yaml", s);


