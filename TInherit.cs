
using Stride.Core;
using VYaml.Serialization;

namespace Stride.Core;


[DataContract]
public class TInherit : ICloneable
{
    public int Nun { get; set; } = 10;

    public object Clone()
    {
        
        throw new NotImplementedException();
    }

}