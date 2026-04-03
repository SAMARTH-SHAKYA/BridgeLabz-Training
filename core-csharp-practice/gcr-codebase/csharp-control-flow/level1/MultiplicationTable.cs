using System;
class MultiplicationTable
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for(int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{i}*{n}={i*n}");
        }
    }
}