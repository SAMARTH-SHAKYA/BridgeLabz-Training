using System;
using System.Collections.Specialized;
using System.Net.Http.Headers;
class AbundantNumber
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 1;
        for(int i = 2; i <= n/2; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        if (sum > n)
        {
            Console.WriteLine("Abundant Number");
        }
        else
        {
            Console.WriteLine("Not a Aboundant Number");
        }
    }
}