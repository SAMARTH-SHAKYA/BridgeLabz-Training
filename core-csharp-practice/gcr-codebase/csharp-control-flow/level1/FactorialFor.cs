using System;
class FactorialFor
{
    public static void Main(string[] args)
    {
        int fact = Convert.ToInt32(Console.ReadLine());

        if (fact <= 0)
        {
            Console.WriteLine("Not valid");
        }
        int ans = 1;
        for(int i = 2; i <= fact; i++)
        {
            ans *= i;
        }
        Console.WriteLine(ans);
    }
}