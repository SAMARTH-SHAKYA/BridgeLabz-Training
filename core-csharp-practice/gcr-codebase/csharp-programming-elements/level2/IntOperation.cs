using System;
using System.IO.Compression;
class IntOperation
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int exp1 = a + b * c;
        int exp2 = a * b + c;
        int exp3 = c + a / b;
        int exp4 = a % b + c;

        Console.WriteLine($" The results of Int Operations are {exp1}, {exp2}, {exp3} and {exp4}");

    }
}