using Stride.Core;
using Stride.Core.Mathematics;



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
    public partial class TInherit4
    {
        public int Nubmers { get; set; }
        public Int2 Int2 { get; set; } = new Int2() { X = 1, Y = 2 };
        public int Nubmers2 { get; set; }
    }


}

namespace Bob
{

    /// <summary>
    /// It must succeed if (a second namespace is given with the same name of the classes.
    /// To ensure that there is no conflict as roslyn assumes a unique file name
    /// </summary>
    [DataContract]
    public class TInherit3
    {
        [DataMember]
        public int FancyNumber { get; set; } = 10;
    }

    [DataContract]
    public partial class TInherit4
    {
        public int Nubmers { get; set; }
        public Int2 Int2 { get; set; } = new Int2() { X = 1, Y = 2 };
        public int Nubmers2 { get; set; }
    }


}