
using Stride.Core.Mathematics;
using System.Runtime.Serialization;

namespace StrideSourceGened;

    [DataContract]
    public class TInherit : TInherit2
    {
        [DataMember]
        public int FancyNumber { get; set; } = 10;
    }

    [DataContract]
    public partial class TInherit2
    {
        public int Nubmers { get; set; }
        public Int2 Int2 { get; set; } = new Int2() { X = 1, Y = 2 };
        public int Nubmers2 { get; set; }
    }

