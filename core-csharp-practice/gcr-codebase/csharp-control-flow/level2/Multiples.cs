using System;
using System.Collections.Specialized;
class Multiples
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        for(int i = 100; i > 0; i--)
        {
            if (i % num == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}