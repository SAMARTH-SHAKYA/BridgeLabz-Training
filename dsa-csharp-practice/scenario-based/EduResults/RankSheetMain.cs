/// <summary>
/// Entry point of the application.
/// Creates sample student data for multiple districts, generates a state-level
/// rank sheet by combining and sorting all students, and displays the ranked
/// list on the console.
/// </summary>


using System;

class RankSheetMain
{
    static void Main(string[] args)
    {
        Student[] d1 = {
            new Student("S101", "Rahul", "Bangalore", 95),
            new Student("S102", "Shruti", "Bangalore", 90)
        };

        Student[] d2 = {
            new Student("S201", "Uday", "Mumbai", 96),
            new Student("S202", "Mehak", "Mumbai", 90)
        };

        DistrictResult[] districts = {
            new DistrictResult("Delhi", d1),
            new DistrictResult("Mumbai", d2)
        };

        RankSheet rankSheet = new RankSheet(districts);
        Student[] students = rankSheet.GenerateRankSheet();

        Console.WriteLine("State Rank List: ");
        Console.WriteLine("=================");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine("Rank. " + (i + 1));
            Console.WriteLine(students[i].ToString());
            Console.WriteLine("====================");
        }
    }
}

