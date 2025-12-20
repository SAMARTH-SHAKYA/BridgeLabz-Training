using System;
class CelciusToFahre
{
    public static void Main(string[] args)
    {
        double tempInCelcius = Convert.ToDouble(Console.ReadLine());
        double tempInFahren = (tempInCelcius*(9.0/5.0)) + 32;

        Console.WriteLine($" The {tempInCelcius} Celsius is {tempInFahren} Fahrenheit");
    }

}