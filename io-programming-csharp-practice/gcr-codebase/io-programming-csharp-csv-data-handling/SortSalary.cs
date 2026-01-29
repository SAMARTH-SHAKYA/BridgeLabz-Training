
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class SortSalary
{
    static void Main()
    {
        var list = new List<string[]>();
        using StreamReader r = new StreamReader("employees.csv");
        r.ReadLine();
        string line;
        while ((line = r.ReadLine()) != null)
            list.Add(line.Split(','));

        foreach (var e in list.OrderByDescending(x => decimal.Parse(x[3])).Take(5))
            Console.WriteLine($"{e[1]} {e[3]}");
    }
}
