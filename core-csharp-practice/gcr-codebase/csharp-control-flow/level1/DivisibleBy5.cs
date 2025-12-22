using System;
class DivisibleBy5
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 5 == 0)
        {
            Console.WriteLine($"{num} Divisible by 5");
        }
        else
        {
            Console.WriteLine($"{num} Not Divisible by 5");
        }
    } 
}