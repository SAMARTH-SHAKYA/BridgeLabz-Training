using System;
using System.IO;

class ReadCSV
{
    static void Main()
    {
        using StreamReader reader = new StreamReader("students.csv");
        reader.ReadLine();
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var c = line.Split(',');
            Console.WriteLine($"ID:{c[0]} Name:{c[1]} Age:{c[2]} Marks:{c[3]}");
        }
    }
}
