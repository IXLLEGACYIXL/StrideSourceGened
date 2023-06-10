
using System.Runtime.Serialization;

namespace StrideSourceGened;

    [DataContract]
    public class TInherit 
    {
        [DataMember()]
        public int FancyNumber { get; set; }
        [IgnoreDataMember()]
        public string FancyString { get; set; }
    }

    [DataContract]
    public class TInherit2
    {
        public int Nubmers { get; set; }
        public int Nubmers2 { get; set; }
    }

