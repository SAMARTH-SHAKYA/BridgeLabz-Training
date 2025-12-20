using System;
class SimpleInterest
{
    public static void Main(string[] args)
    {
        double p = Convert.ToDouble(Console.ReadLine());
        double r = Convert.ToDouble(Console.ReadLine());
        double t = Convert.ToDouble(Console.ReadLine());

        double simpleInterst = (p*r*t)/100;

        Console.WriteLine($"The Simple Interest is {simpleInterst} for Principal {p}, Rate of Interest {r} and {t}");
    }
}