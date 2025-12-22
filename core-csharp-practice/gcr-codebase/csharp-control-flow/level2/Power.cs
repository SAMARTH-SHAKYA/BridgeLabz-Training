using System;
class Power
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int power = Convert.ToInt32(Console.ReadLine());
        int num = number;
        for(int i = 1; i < power; i++)
        {
            num *= number;
        }
        Console.WriteLine(num);
    }
}