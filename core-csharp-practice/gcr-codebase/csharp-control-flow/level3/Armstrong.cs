using System;
using System.Collections.Specialized;
class Armstrong{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int l = n.ToString().Length;

        int temp = n;
        double sum = 0;

        while (temp > 0)
        {
            sum = sum + Math.Pow(temp%10,l);
            temp = temp/10;
        }
        if (sum == n)
        {
            Console.WriteLine("Armstrong Number");
        }
        else
        {
            Console.WriteLine("Not a Armstrong Number");
        }
    }
}