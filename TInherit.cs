
using System.Runtime.Serialization;

namespace StrideSourceGened;

[DataContract]
public  class TInherit : ICloneable
{
    public int Nun2 { get; set; } = 0;
    public int Num { get; set; } = 10;

    public object Clone()
    {
        throw new NotImplementedException();
    }
}

[DataContract]
public class TInherit2 : TInherit
{
    public int Nubmers { get; set; } = 13827945;
    public int Nubmers2 { get; set; } = 120938537;
    public TInherit Fancy { get; set; } = new();
}

