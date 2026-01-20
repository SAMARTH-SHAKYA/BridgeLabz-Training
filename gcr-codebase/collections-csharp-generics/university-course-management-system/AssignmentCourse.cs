public class AssignmentCourse : CourseType
{
    public int TotalAssignments { get; set; }

    public AssignmentCourse(int id, string name, int totalAssignments)
        : base(id, name)
    {
        TotalAssignments = totalAssignments;
    }

    public override void Evaluate()
    {
        Console.WriteLine($"Assignment-based evaluation for {CourseName} with {TotalAssignments} assignments");
    }

    public override void Display()
    {
        Console.WriteLine($"[Assignment Course] ID: {CourseId}, Name: {CourseName}, Assignments: {TotalAssignments}");
    }
}
