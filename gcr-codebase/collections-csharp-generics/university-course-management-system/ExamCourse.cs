using System;
public class ExamCourse : CourseType
{
    public int MaxMarks { get; set; }

    public ExamCourse(int id, string name, int maxMarks)
        : base(id, name)
    {
        MaxMarks = maxMarks;
    }

    public override void Evaluate()
    {
        Console.WriteLine($"Exam evaluation for {CourseName} with max marks {MaxMarks}");
    }

    public override void Display()
    {
        Console.WriteLine($"[Exam Course] ID: {CourseId}, Name: {CourseName}, MaxMarks: {MaxMarks}");
    }
}
