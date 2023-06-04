using Stride.Core.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StrideSourceGened
{
    public class TInherit2
    {
        [DataMember]
        public int Nubmers { get; set; }
        public Int2 Int2 { get; set; } = new Int2() { X = 1 ,Y = 2 };
        public int Nubmers2 { get; set; }
    }
}

