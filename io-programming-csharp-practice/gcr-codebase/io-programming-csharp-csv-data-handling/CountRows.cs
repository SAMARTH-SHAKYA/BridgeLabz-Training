
using System;
using System.IO;

class CountRows
{
    static void Main()
    {
        int count = 0;
        using StreamReader reader = new StreamReader("employees.csv");
        reader.ReadLine();
        while (reader.ReadLine() != null) count++;
        Console.WriteLine(count);
    }
}
