using System;
class FizzBuzzFor
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Number not positive");
        }
        for(int i = 1; i <= n; i++)
        {
            if (i%3==0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(i%5==0){
                Console.WriteLine("Buzz");
            }
            else if(i%3==0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                continue;
            }
        }
    }
}