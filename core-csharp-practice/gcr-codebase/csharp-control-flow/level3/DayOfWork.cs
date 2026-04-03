using System;
class DayOfWork
{
    public static void Main(string[] args)
    {
        int m = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        int y1 = y - (14 - m) / 12;
        int x = y1 + y1/4 - y1/100 + y1/400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31*m0 / 12) % 7;

        Console.WriteLine(d0);



    }
}