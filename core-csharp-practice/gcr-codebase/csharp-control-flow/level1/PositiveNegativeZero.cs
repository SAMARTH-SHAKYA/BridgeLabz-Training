using System;
class PositiveNegativeZero
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("Positive");
        }
        else if(num < 0)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("zero");
        }
    }
}