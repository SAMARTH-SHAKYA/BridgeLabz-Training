// class that use linked list for stages
class Stages
{
    //fields of class
    public string StageName { get; private set; }
    public Stages Next { get; private set; }

    //contructor
    public Stages(string name)
    {
        StageName = name;
        Next = null;
    }

    //method to set the next pointer
    public void SetNext(Stages node)
    {
        Next = node;
    }

    //overrding the to string method
    public override string ToString()
    {
        return $"Parcel is currently at: {StageName}";
    }
}
