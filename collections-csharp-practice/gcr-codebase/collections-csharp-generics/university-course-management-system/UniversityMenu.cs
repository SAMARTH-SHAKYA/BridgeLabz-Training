using System;
public class UniversityMenu
{
    private IUniversity universityService;

    public UniversityMenu()
    {
        universityService = new UniversityIMPL();
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n====== University Course System ======");
            Console.WriteLine("1. Add Exam Course");
            Console.WriteLine("2. Add Assignment Course");
            Console.WriteLine("3. Show All Courses");
            Console.WriteLine("4. Evaluate All Courses");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    universityService.AddExamCourse();
                    break;
                case 2:
                    universityService.AddAssignmentCourse();
                    break;
                case 3:
                    universityService.ShowAllCourses();
                    break;
                case 4:
                    universityService.EvaluateAll();
                    break;
                case 5:
                    return;
            }
        }
    }
}
