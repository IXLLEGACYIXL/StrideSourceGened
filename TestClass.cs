
using System.Runtime.Serialization;


namespace StrideSourceGened
{
    [DataContract]
    public class TestClass : TInherit2
    {
        [IgnoreDataMember]
        public int TEst = 10;
        public int Number { internal get; set; } = 10;
        public string Test { get; internal init; } = "hello mister";
        public TestClass FancyClass { get; set; }
        public TestClass FancyClass2 { get; set; }

        public void WriteToFile(TestClass objectToSerialize, string filePath)
        {
        }
    }
}

