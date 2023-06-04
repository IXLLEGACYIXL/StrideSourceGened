using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StrideSourceGened
{
    public class TInherit2 : Dictionary<string, TInherit2>
    {
        [DataMember]
        public int Nubmers { get; set; }
        public int Nubmers2 { get; set; }
    }
}

