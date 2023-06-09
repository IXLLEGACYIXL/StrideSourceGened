﻿
using System.Runtime.Serialization;

namespace StrideSourceGened
{

    /// <summary>
    /// This scenario tests if (a multi class normal namespace works
    /// If it fails to create of these two classes the generation, then normally 
    /// one of the classes is attached to the generator and causes duplication generation of a class.
    /// clearing the namespace helps, but better to create a new namespace syntax
    /// </summary>
    [DataContract]
    public class TInherit3 : TInherit2
    {
        [DataMember]
        public int FancyNumber { get; set; } = 10;
    }

    [DataContract]
    public class TInherit4
    {
        public int Nubmers { get; set; }
        public int Nubmers2 { get; set; }
    }
    
    public struct TInherit5
    {
        public int Test { get; set; }
    }

}