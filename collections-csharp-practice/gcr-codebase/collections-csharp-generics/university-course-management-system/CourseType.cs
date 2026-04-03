using System;
public abstract class CourseType
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }

    protected CourseType(int id, string name)
    {
        CourseId = id;
        CourseName = name;
    }

    public abstract void Evaluate();
    public abstract void Display();
}
