
using System.Runtime.Serialization;
using VYaml.Serialization;

namespace StrideSourceGened;


[DataContract]
public class TInherit : ICloneable
{
    public int Nun { get; set; } = 10;

    public object Clone()
    {
        throw new NotImplementedException();
    }

}
[DataContract]
public class TInherit2 : TInherit
{
    public int Nubmers { get; set; } = 13827945;
    public int Nubmers2 { get; set; } = 120938537 ;
    // changing this to ICloneable makes the inherit4 fail to deserialize
    public TInherit3 inherit3 { get; set; } = new TInherit3();
    public TInherit3 inherit4 { get; set; } = new TInherit3();
}

[DataContract]
public class TInherit3 : TInherit
{
    public int FancyNumber { get; set; } = 10;
    // public int[] Test { get; set; } = new[] { 1, 2, 3, 4, 5 };
}
