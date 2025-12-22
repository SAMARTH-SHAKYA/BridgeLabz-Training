using System;
class RocketLaunch
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        while (num >= 1)
        {
            Console.WriteLine(num);
            num--;
        }
    }
}