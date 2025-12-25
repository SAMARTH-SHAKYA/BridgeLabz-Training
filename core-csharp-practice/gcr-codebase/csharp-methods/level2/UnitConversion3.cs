using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level2
{
    internal class UnitConversion3
    {
        public static void FarhenheitToCelsius(double farhenheit)
        {
            Console.WriteLine($"farhenheit to celsius : {(farhenheit - 32) * 5 / 9}");
        }
        public static void CelsiusToFarhenheit(double celsius)
        {
            Console.WriteLine($"celsius to farhenheit : {(celsius * 9 / 5) + 32}");
        }
        public static void PoundsToKilograms(double pounds)
        {
            Console.WriteLine($"pounds to kilograms : {pounds * 0.453592}");
        }
        public static void KilogramsToPounds(double kilograms)
        {
            Console.WriteLine($"kilograms to pounds : {kilograms * 2.20462}");
        }
        public static void GallonsToLiters(double gallons)
        {
            Console.WriteLine($"gallons to liters : {gallons * 3.78541}");
        }
        public static void LitersToGallons(double liters)
        {
            Console.WriteLine($"liters to gallons : {liters * 0.264172}");
        }
        public static void main()
        {
            //taking input from the user and instantly calling the methods
            double farhenheit = Convert.ToDouble(Console.ReadLine());
            FarhenheitToCelsius(farhenheit);
            double celsius = Convert.ToDouble(Console.ReadLine());
            CelsiusToFarhenheit(celsius);
            double pounds = Convert.ToDouble(Console.ReadLine());
            PoundsToKilograms(pounds);
            double kilograms = Convert.ToDouble(Console.ReadLine());
            KilogramsToPounds(kilograms);
            double gallons = Convert.ToDouble(Console.ReadLine());
            GallonsToLiters(gallons);
            double liters = Convert.ToDouble(Console.ReadLine());
            LitersToGallons(liters);
        }
    }
}
