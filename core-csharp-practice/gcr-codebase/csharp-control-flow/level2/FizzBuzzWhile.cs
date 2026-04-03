using System;
class FizzBuzzWhile
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Number not positive");
        }
        int i = 1;
        while (i <= n)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                i++;
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
                i++;
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
                i++;
            }
            else
            {
                i++;
                continue;
            }
        }

    }
}