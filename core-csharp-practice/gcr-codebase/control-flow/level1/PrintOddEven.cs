using System;
class PrintOddEven
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Not valid");
        }

        for(int i = 1; i <= n; i++)
        {
            if ((i / 2) * 2 == i)
            {
                Console.WriteLine($"{i} is even");
            }
            else
            {
                Console.WriteLine($"{i} is odd");
            }
        }
    }
}