using System.Runtime.Serialization;

namespace OnlyForVerifiedGithubPublishers;
[DataContract]
public class DescriptionData
{
    public Description World { get; set; }
    public Description Inventory { get; set; }
}
[DataContract]
internal class NullSerialization
{
    public List<int> Guid { get; set; } = null;
}

[DataContract]
public sealed class BananaTemplate : IItemTemplate
{
    public string ItemName { get; set; } = "Banana";
    public string InventoryItemScene { get; set; } = "res://Scenes/Items/Items/ItemOld.tscn";
    public string WorldItemScene { get; set; } = "res://Scenes/Items/Items/ItemOld.tscn";
    public string DraggableItemScene { get; set; } = "res://Scenes/Items/Items/ItemOld.tscn";
    public DescriptionData Descriptions { get; set; } = CreateDescriptions();
    public Component[] Components { get; set; } = new Component[]{
        new FancyThing(),
        new SecondFancyThing(),
    };
    private static DescriptionData CreateDescriptions()
    {

        return new()
        {

            World = new Description
            {
                Unidentified = "There's a strange yellow fruit on the ground.",
                Identified = "There's a banana on the ground.",
            },

            Inventory = new Description
            {
                Unidentified = "It's a yellow fruit of some kind.",
                Identified = "It's a banana.",
            }
        };
    }
}
internal interface IItemTemplate
{
    string ItemName { get; }
    string InventoryItemScene { get; }
}
[DataContract]
public class Description
{
    public string Unidentified { get; set; }
    public string Identified { get; set; }

}

public abstract class Component
{
    public abstract void Do();
}
[DataContract]
public class FancyThing : Component
{
    public int Nutrition { get; set; } = 12345;
    public override void Do()
    {
        throw new NotImplementedException();
    }
}
[DataContract]
public class SecondFancyThing : Component
{
    public string Publisher { get; set; } = "Pilvinen";
    public override void Do()
    {
        throw new NotImplementedException();
    }
}