using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.builtIn.level2
{
    internal class TempConverter
    {
        public static void FarhenheitToCelsius(double farhenheit)
        {
            Console.WriteLine($"farhenheit to celsius : {(farhenheit - 32) * 5 / 9}");
        }
        public static void CelsiusToFarhenheit(double celsius)
        {
            Console.WriteLine($"celsius to farhenheit : {(celsius * 9 / 5) + 32}");
        }

        public static void main()
        {
            //taking input from the user and instantly calling the methods
            double farhenheit = Convert.ToDouble(Console.ReadLine());
            FarhenheitToCelsius(farhenheit);
            double celsius = Convert.ToDouble(Console.ReadLine());
            CelsiusToFarhenheit(celsius);
        }
    }
}
