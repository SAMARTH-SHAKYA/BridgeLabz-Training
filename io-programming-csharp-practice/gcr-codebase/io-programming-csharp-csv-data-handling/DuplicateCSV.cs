
using System;
using System.IO;
using System.Collections.Generic;

class DuplicateCSV
{
    static void Main()
    {
        var set = new HashSet<string>();
        using StreamReader r = new StreamReader("data.csv");
        r.ReadLine();
        string line;
        while((line=r.ReadLine())!=null)
        {
            var id = line.Split(',')[0];
            if(!set.Add(id))
                Console.WriteLine("Duplicate: "+line);
        }
    }
}
