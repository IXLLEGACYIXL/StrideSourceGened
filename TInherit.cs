using System.Runtime.Serialization;

namespace StrideSourceGened
{
    [DataContract]
    public class TInherit : TInherit2
    {
        [DataMember]
        public int FancyNumber { get; set; } = 10;
    }
}

