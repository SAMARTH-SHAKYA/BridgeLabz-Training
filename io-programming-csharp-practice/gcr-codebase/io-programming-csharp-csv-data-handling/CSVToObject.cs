
using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public int ID;
    public string Name;
    public int Age;
    public int Marks;
}

class CSVToObject
{
    static void Main()
    {
        var list = new List<Student>();
        using StreamReader r = new StreamReader("students.csv");
        r.ReadLine();
        string line;
        while ((line = r.ReadLine()) != null)
        {
            var c = line.Split(',');
            list.Add(new Student{ID=int.Parse(c[0]),Name=c[1],Age=int.Parse(c[2]),Marks=int.Parse(c[3])});
        }
        foreach(var s in list) Console.WriteLine(s.Name);
    }
}
