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
GeneratedYamlSerializerBananaTemplate inherit3 = new ();
GeneratedYamlSerializerDescription inherit = new ();
GeneratedYamlSerializerDescriptionData inherit2 = new();
GeneratedYamlSerializerFancyThing fancy = new();
GeneratedYamlSerializerSecondFancyThing fancy2 = new();
fancy2.Register();
fancy.Register();
inherit.Register();
inherit2.Register();

inherit3.Register();
IItemTemplate inh = new BananaTemplate();
var x2 = YamlSerializer.SerializeToString(inh);
File.WriteAllText("C:\\Godot\\tmp.yaml",x2);



