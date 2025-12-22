using System;
class NaturalNumberSum
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {   
            int sum =  (num * (num+1)) / 2;
            Console.WriteLine($"The sum of {num} natural numbers is {sum}");
        }
        else
        {
            Console.WriteLine($"The number {num} is not a natural number");
        }
    }
}