using System;
public class UniversityIMPL : IUniversity
{
    private Course<ExamCourse> examCourses = new Course<ExamCourse>();
    private Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();

    public void AddExamCourse()
    {
        ExamCourse exam = new ExamCourse(1, "Mathematics", 100);
        examCourses.AddCourse(exam);
        Console.WriteLine("Exam course added!");
    }

    public void AddAssignmentCourse()
    {
        AssignmentCourse assignment = new AssignmentCourse(2, "AI Project", 5);
        assignmentCourses.AddCourse(assignment);
        Console.WriteLine("Assignment course added!");
    }

    public void ShowAllCourses()
    {
        Console.WriteLine("\n--- Exam Courses ---");
        examCourses.DisplayAll();

        Console.WriteLine("\n--- Assignment Courses ---");
        assignmentCourses.DisplayAll();
    }

    public void EvaluateAll()
    {
        Console.WriteLine("\n--- Evaluating Exam Courses ---");
        foreach (var c in examCourses.GetAllCourses())
        {
            c.Evaluate();
        }

        Console.WriteLine("\n--- Evaluating Assignment Courses ---");
        foreach (var c in assignmentCourses.GetAllCourses())
        {
            c.Evaluate();
        }
    }
}
