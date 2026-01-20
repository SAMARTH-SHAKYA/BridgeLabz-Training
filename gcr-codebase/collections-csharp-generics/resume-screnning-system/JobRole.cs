using System;
public abstract class JobRole
{
    public int CandidateId { get; set; }
    public string CandidateName { get; set; }

    protected JobRole(int id, string name)
    {
        CandidateId = id;
        CandidateName = name;
    }

    public abstract void Screen();
    public abstract void Display();
}
