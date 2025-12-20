using System;
class FahrenToCelcius
{
    public static void Main(string[] args)
    {
        double tempInFahren = Convert.ToDouble(Console.ReadLine());
        double tempInCelcius = (tempInFahren-32) * (5.0/9.0);

        Console.WriteLine($" The {tempInFahren} Fahrenheit is {tempInCelcius} Celcius");
    }
}