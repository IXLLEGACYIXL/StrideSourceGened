
using Stride.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VYaml;
using VYaml.Serialization;


NexSourceGenerated_Stride_CoreTInherit<int>.Register();
NexSourceGenerated_Stride_CoreTest.Register();
var t = new TInherit<Test>();
t.Test = new Test();    
t.Value = new Test();
var x = YamlSerializer.SerializeToString<Tomp<Test>>(t);
//var x2 = YamlSerializer.Deserialize<Tomp<Test>>(x);
//Console.WriteLine(YamlSerializer.SerializeToString(x2));
Console.WriteLine(x);