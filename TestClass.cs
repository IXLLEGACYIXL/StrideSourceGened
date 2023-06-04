using Stride.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using YamlDotNet.Core;
using YamlDotNet.Serialization;

namespace StrideSourceGened
{
    [DataContract]
    public class TestClass : TInherit
    {
        [DataMember]
        public int Number { get; set; } = 10;
        [DataMember]
        public string Test { get; set; } = "hello mister";
        [DataMember]
        public TestClass FancyClass { get; set; }
        
        public TestClass FancyClass2 { get; set; }

        public void WriteToFile(TestClass objectToSerialize, string filePath)
        {
            

            var serializer = new SerializerBuilder().Build();

            var dict = new Dictionary<string, object>();
            dict["$Type"] = typeof(TestClass).AssemblyQualifiedName;
            var propertiesDictionary = new Dictionary<string, object>();
            dict["$Attributes"] = propertiesDictionary;


            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, dict);
            }
        }
    }
}

