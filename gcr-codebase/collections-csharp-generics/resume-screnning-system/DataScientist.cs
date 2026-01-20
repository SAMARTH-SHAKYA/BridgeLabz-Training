using System;
public class DataScientist : JobRole
{
    public string Tool { get; set; }

    public DataScientist(int id, string name, string tool)
        : base(id, name)
    {
        Tool = tool;
    }

    public override void Screen()
    {
        Console.WriteLine($"{CandidateName} screened for Data Scientist role.");
    }

    public override void Display()
    {
        Console.WriteLine($"[Data Scientist] ID: {CandidateId}, Name: {CandidateName}, Tool: {Tool}");
    }
}
