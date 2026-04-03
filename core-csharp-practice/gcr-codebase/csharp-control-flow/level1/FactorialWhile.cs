using System;
class FactorialWhile
{
    public static void Main(string[] args)
    {
        int fact = Convert.ToInt32(Console.ReadLine());
        if (fact <= 0)
        {
            Console.WriteLine("Not valid");
        }
        int ans = 1;
        while(fact > 0)
        {
            ans *= fact;
            fact--;
        }
        Console.WriteLine(ans);
    }
}