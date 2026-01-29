
using System;
using System.IO;

class SearchEmployee
{
    static void Main()
    {
        string search = "Alice";
        using StreamReader reader = new StreamReader("employees.csv");
        reader.ReadLine();
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var c = line.Split(',');
            if (c[1] == search)
            {
                Console.WriteLine($"{c[2]} {c[3]}");
                break;
            }
        }
    }
}
