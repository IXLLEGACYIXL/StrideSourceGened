namespace Stride.Core;


[System.Runtime.Serialization.DataContract]
public class TInherit
{
    [System.Runtime.Serialization.DataMember]
    public int Nun { get; set; } = 10;

    public object Clone()
    {
        
        throw new NotImplementedException();
    }

}