using System;
class PoundToKg
{
    public static void Main(string[] args)
    {
        double pound = Convert.ToDouble(Console.ReadLine());

        double kg = (pound/2.2);

        Console.WriteLine($"The weight of the person in pounds is {pound} and in kg is {kg}");
    }
}