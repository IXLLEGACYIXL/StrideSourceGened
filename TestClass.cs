
using System.Runtime.Serialization;


namespace StrideSourceGened
{
    public class TestClass : TInherit2
    {
        [DataMember]
        public int Number { get; set; } = 10;
        [DataMember]
        public string Test { get; set; } = "hello mister";
        [DataMember]
        public TestClass FancyClass { get; set; }
        [DataMember]
        public TestClass FancyClass2 { get; set; }

        public void WriteToFile(TestClass objectToSerialize, string filePath)
        {
        }
    }
}

