using System;
class RocketLaunchFor
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        for(int i = num; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}