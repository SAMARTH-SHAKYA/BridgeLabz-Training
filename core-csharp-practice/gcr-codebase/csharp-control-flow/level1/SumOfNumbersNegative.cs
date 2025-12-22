using System;
using System.Data;
class SumOfNumbersNegative
{
    public static void Main(string[] args)
    {
        double sum = 0;
        double n = 1;
        while(n > 0)
        {
            n=Convert.ToDouble(Console.ReadLine());
            if (n <= 0)
            {
                break;
            }
            sum += n;
        }
        Console.WriteLine(sum);
    }
}