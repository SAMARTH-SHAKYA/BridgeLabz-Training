using System;
using System.IO.Compression;
class DoubleOperation
{
    public static void Main(string[] args)
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double exp1 = a + b * c;
        double exp2 = a * b + c;
        double exp3 = c + a / b;
        double exp4 = a % b + c;

        Console.WriteLine($" The results of Int Operations are {exp1}, {exp2}, {exp3} and {exp4}");

    }
}