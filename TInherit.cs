
using System.Runtime.Serialization;
using VYaml.Annotations;

namespace StrideSourceGened;

[DataContract]
public class TInherit 
{
    public int Nubmers2 { get; set; } = 0;
    public int Number { get; set; } = 10;
}

[DataContract]
public class TInherit2
{
    public int Nubmers { get; set; } = 13827945;
    public int Nubmers2 { get; set; } = 120938537;
    TInherit Fancy { get; set; } = new TInherit();
}

