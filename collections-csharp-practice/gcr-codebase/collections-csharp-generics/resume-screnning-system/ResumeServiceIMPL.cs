using System;
public class ResumeServiceIMPL : IResumeService
{
    private Resume<SoftwareEngineer> softwareEngineers = new Resume<SoftwareEngineer>();
    private Resume<DataScientist> dataScientists = new Resume<DataScientist>();

    public void AddSoftwareEngineer()
    {
        var se = new SoftwareEngineer(1, "Alice", "C#");
        ScreeningUtility.ProcessResume(se);
        softwareEngineers.AddResume(se);
        Console.WriteLine("Software Engineer resume added!");
    }

    public void AddDataScientist()
    {
        var ds = new DataScientist(2, "Bob", "Python");
        ScreeningUtility.ProcessResume(ds);
        dataScientists.AddResume(ds);
        Console.WriteLine("Data Scientist resume added!");
    }

    public void ShowAll()
    {
        Console.WriteLine("\n--- Software Engineers ---");
        softwareEngineers.DisplayAll();

        Console.WriteLine("\n--- Data Scientists ---");
        dataScientists.DisplayAll();
    }

    public void ScreenAll()
    {
        Console.WriteLine("\n--- Screening Software Engineers ---");
        foreach (var se in softwareEngineers.GetAll())
        {
            se.Screen();
        }

        Console.WriteLine("\n--- Screening Data Scientists ---");
        foreach (var ds in dataScientists.GetAll())
        {
            ds.Screen();
        }
    }
}
