using System;
public class ResumeMenu
{
    private IResumeService resumeService;

    public ResumeMenu()
    {
        resumeService = new ResumeServiceIMPL();
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n====== AI Resume Screening System ======");
            Console.WriteLine("1. Add Software Engineer Resume");
            Console.WriteLine("2. Add Data Scientist Resume");
            Console.WriteLine("3. Show All Resumes");
            Console.WriteLine("4. Screen All Resumes");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    resumeService.AddSoftwareEngineer();
                    break;
                case 2:
                    resumeService.AddDataScientist();
                    break;
                case 3:
                    resumeService.ShowAll();
                    break;
                case 4:
                    resumeService.ScreenAll();
                    break;
                case 5:
                    return;
            }
        }
    }
}
