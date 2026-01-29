
using System;
using System.IO;

class FilterMarks
{
    static void Main()
    {
        using StreamReader reader = new StreamReader("students.csv");
        reader.ReadLine();
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var c = line.Split(',');
            if (int.Parse(c[3]) > 80)
                Console.WriteLine(c[1]);
        }
    }
}
