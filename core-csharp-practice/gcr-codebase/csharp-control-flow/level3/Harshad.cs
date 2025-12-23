using System;
class Harshad
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int temp = n;
        while (n > 0)
        {
            sum = sum + n%10;
            n = n/10;
        }
        if(temp%sum==0)
        {
            Console.WriteLine("Harshad Number");
        }
        else
        {
            Console.WriteLine("Not a Harshad Number");
        }
    }
}