using System;
public class SoftwareEngineer : JobRole
{
    public string ProgrammingLanguage { get; set; }

    public SoftwareEngineer(int id, string name, string language)
        : base(id, name)
    {
        ProgrammingLanguage = language;
    }

    public override void Screen()
    {
        Console.WriteLine($"{CandidateName} screened for Software Engineer role.");
    }

    public override void Display()
    {
        Console.WriteLine($"[Software Engineer] ID: {CandidateId}, Name: {CandidateName}, Language: {ProgrammingLanguage}");
    }
}
