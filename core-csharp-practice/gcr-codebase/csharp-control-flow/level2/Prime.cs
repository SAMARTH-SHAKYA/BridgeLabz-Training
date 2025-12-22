using System;
using System.Runtime.CompilerServices;
class Prime
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine("Enter number greater than 1");
        }
        bool isPrime = true;
        for(int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime);
    }
}