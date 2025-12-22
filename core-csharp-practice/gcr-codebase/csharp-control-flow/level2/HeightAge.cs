using System;

class HeightAge
{
    public static void Main(string[] args)
    {
        int age1 = Convert.ToInt32(Console.ReadLine());
        int age2 = Convert.ToInt32(Console.ReadLine());
        int age3 = Convert.ToInt32(Console.ReadLine());

        int height1 = Convert.ToInt32(Console.ReadLine());
        int height2 = Convert.ToInt32(Console.ReadLine());
        int height3 = Convert.ToInt32(Console.ReadLine());

        int lowestAge = Lowest(age1,age2,age3);
        int lowestheight = Lowest(height1,height2,height3);

        Console.WriteLine($"Lowest age {lowestAge}");
        Console.WriteLine($"Lowest height {lowestheight}");

    }

    public static int Lowest(int a, int b,int c)
    {
        if(a<b && a < c)
        {
            return a;
        }
        else if(b<a && b < c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}