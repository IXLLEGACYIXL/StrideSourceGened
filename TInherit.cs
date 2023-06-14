
using System.Runtime.Serialization;
using VYaml.Annotations;

namespace StrideSourceGened;
[YamlObject]
[DataContract]
public partial class TInherit
{
    static readonly byte[] UTF8FancyNumber = new byte[]
        {
            70,
            97,
            110,
            99,
            121,
            78,
            117,
            109,
            98,
            101,
            114
        };
    public int FancyNumber { get; set; } = 132954717;
    public string FancyString { get; set; } = "asofhbneoiwp";
    public string FancyString2 { get; set; } = "asdofnwe";
    public string FancyString6 { get; set; } = "aoönfeiwpinopio";
    public string FancyString3 { get; set; } = "safbonwenfowerui";
    public string FancyString4 { get; set; } = "aofnejawjn";
    public string FancyString5 { get; set; } = "apnhjfpweöfiojawe";
}

[DataContract]
public class TInherit2
{
    public int Nubmers { get; set; }
    public int Nubmers2 { get; set; }
}

