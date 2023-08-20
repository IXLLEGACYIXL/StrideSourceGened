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
using YamlDotNet.Core.Tokens;

NexYamlSerializerRegistry.Default.RegisterFormatter(new GeneratedYamlSerializerTInherit2());
NexYamlSerializerRegistry.Default.RegisterFormatter(new GeneratedYamlSerializerTInherit());

var tinherit = new TInherit2();
using FileStream writer = File.OpenWrite("C:\\Godot\\tmp.yaml");
var yamlString = YamlSerializer.SerializeToString(tinherit);

writer.Write(Encoding.UTF8.GetBytes(yamlString));
writer.Dispose();
var mem = File.ReadAllBytes("C:\\Godot\\tmp.yaml");


var b = YamlSerializer.Deserialize<TInherit2>(mem.AsMemory());
Console.WriteLine(b.ToString());

Utf8YamlEmitter emitter;
YamlParser parser;
YamlDeserializationContext context;
