using BenchmarkDotNet.Running;
using CommandLine.Text;
using Microsoft.Diagnostics.Tracing.Stacks.Formats;
using StrideSourceGened;
using System.Buffers;
using System.Diagnostics;
using System.Text;
using VYaml.Emitter;
using VYaml.Parser;
using VYaml.Serialization;
GeneratedYamlSerializerTInherit2 generatedYamlSerializerTInherit2 = new GeneratedYamlSerializerTInherit2();
GeneratedYamlSerializerTInherit3 inherit3 = new GeneratedYamlSerializerTInherit3();

inherit3.Register();
generatedYamlSerializerTInherit2.Register();
using FileStream writer = File.OpenWrite("C:\\Godot\\tmp.yaml");
var tinherit = new TInherit2();
var yamlString = YamlSerializer.SerializeToString<ICloneable>(tinherit);

writer.Write(Encoding.UTF8.GetBytes(yamlString));
writer.Dispose();
