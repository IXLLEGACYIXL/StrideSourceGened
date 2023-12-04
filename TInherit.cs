namespace Stride.Core;


[System.Runtime.Serialization.DataContract]
public class TInherit
{
    public int Nun { get; set; } = 10;
    [System.Runtime.Serialization.IgnoreDataMember]
    public int Ignore { get; set; } = 100;
    public List<int> ints { get; set; } = new List<int>() { 1, 2, 3 };
    public int[] intArray { get; set; } = { 1, 2, 3 };
    public Dictionary<int, string> keyValuePairs { get; set; } = new Dictionary<int, string>()
    {
        [0] = "1",
        [1] = "2",
    };
    public object Clone()
    {
        
        throw new NotImplementedException();
    }

}