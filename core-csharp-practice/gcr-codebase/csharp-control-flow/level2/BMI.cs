using System;
using System.Runtime.CompilerServices;
class BMI
{
    public static void Main(string[] args)
    {
        double weight = Convert.ToDouble(Console.ReadLine());
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        double heightInM = heightInCm/100;
        double bmi = weight / (heightInM * heightInM);

        if(bmi <= 18.4)
        {
            Console.WriteLine("UnderWeight");
        }
        else if(bmi<=24.9 && bmi >= 18.5)
        {
            Console.WriteLine("Normal");
        }
        else if(bmi>=25.0 && bmi <= 39.9)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }

    }
}