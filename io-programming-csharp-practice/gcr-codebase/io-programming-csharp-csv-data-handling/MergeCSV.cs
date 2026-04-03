
using System;
using System.IO;
using System.Collections.Generic;

class MergeCSV
{
    static void Main()
    {
        var map = new Dictionary<string,string[]>();
        using StreamReader r1 = new StreamReader("students1.csv");
        r1.ReadLine();
        string line;
        while ((line = r1.ReadLine()) != null)
        {
            var c = line.Split(',');
            map[c[0]] = c;
        }

        using StreamReader r2 = new StreamReader("students2.csv");
        using StreamWriter w = new StreamWriter("merged.csv");
        w.WriteLine("ID,Name,Age,Marks,Grade");
        r2.ReadLine();

        while ((line = r2.ReadLine()) != null)
        {
            var c2 = line.Split(',');
            if (map.ContainsKey(c2[0]))
            {
                var c1 = map[c2[0]];
                w.WriteLine($"{c1[0]},{c1[1]},{c1[2]},{c2[1]},{c2[2]}");
            }
        }
    }
}
