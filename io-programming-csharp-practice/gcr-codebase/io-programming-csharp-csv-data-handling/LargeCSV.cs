
using System;
using System.IO;

class LargeCSV
{
    static void Main()
    {
        int count=0,batch=0;
        using StreamReader r = new StreamReader("large.csv");
        r.ReadLine();
        while (r.ReadLine()!=null)
        {
            count++; batch++;
            if(batch==100)
            {
                Console.WriteLine(count);
                batch=0;
            }
        }
    }
}
