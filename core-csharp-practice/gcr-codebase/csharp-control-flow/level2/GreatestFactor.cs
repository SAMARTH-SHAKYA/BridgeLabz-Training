using System;
class GreatestFactor
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int ans = 1;
        for(int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                ans = i;
            }
        }
        Console.WriteLine(ans);
    }
}