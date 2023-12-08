using System.Runtime.CompilerServices;

namespace Stride.Core;


[System.Runtime.Serialization.DataContract]
public class TInherit<T> : ICloneable,Tomp<T>
{
    public int Nun { get; set; } = 10;
    public T Test { get; set; }
    public int Ignore { get; set; } = 100;
    public List<int> ints { get; set; } = new List<int>() { 1, 2, 3 };
    public int[] intArray { get; set; } = { 1, 2, 3 };
    public Test[] tests { get; set; }
    //public Test<int> Test { get; set; } = new Test<int>();
    public Dictionary<int, string> keyValuePairs { get; set; } = new Dictionary<int, string>()
    {
        [0] = "1",
        [1] = "2",
    };
    public Dictionary<Test, Test> testDictionary { get; set; } = new Dictionary<Test, Test>()
    {
        [new Test()] = new Test(),
        [new Test()] = new Test()
    };
    public T Value { get; set; }

    public object Clone()
    {
        throw new NotImplementedException();
    }
}
public interface Tomp<T>
{
    T Value { get; set; }
}
[System.Runtime.Serialization.DataContract]
public class Test
{
    public int Value { get; set; }
}
public unsafe class Test2
{
    [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "_myField")]
    extern static ref string _myField(Test c);
}