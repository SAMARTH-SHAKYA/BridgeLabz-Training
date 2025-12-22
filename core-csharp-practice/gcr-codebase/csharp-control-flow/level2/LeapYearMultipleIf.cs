using System;
class LeapYearMultipleIf
{
    public static void Main(string[] args)
    {
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0)
        {
            Console.WriteLine("Leap Year");
        }
        else if(year % 4 == 0 && year % 100 != 0)
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not a Leap Year");
        }
    }
}