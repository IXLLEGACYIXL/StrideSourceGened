
using Stride.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using VYaml;
using VYaml.Serialization;

NexYamlSerializerRegistry.Instance.RegisterFormatter(new NexSourceGenerated_Stride_CoreTInherit());
var t = new TInherit();
var x = YamlSerializer.SerializeToString(new TInherit());
YamlSerializer.Deserialize<TInherit>(x);
Console.WriteLine(x);
