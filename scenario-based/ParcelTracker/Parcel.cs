//class of user parcel
public class Parcel
{
    //encapsualted fields
    public string ParcelName { get; private set; }
    public Stages ParcelStageNode { get; private set; }

    //constructor
    public Parcel(string name)
    {
        ParcelName = name;
        ParcelStageNode = null;
    }

    //setting on which stage my parcel have reached
    public void SetParcelStageNode(Stages node)
    {
        ParcelStageNode = node;
    }

    public override string ToString()
    {
        return ParcelName;
    }
}
