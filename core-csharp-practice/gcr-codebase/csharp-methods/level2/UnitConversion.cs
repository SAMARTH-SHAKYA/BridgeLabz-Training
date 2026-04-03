using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level2
{
    internal class UnitConversion
    {
        public static void KmToMile(double km)
        {
            Console.WriteLine($"Km to miles : {km * 0.621371}");    
        }
        public static void MileToKm(double mile)
        {
            Console.WriteLine($"miles to km : {mile * 1.60934}");
        }
        public static void MeterToFeet(double meter)
        {
            Console.WriteLine($"meter to feet : {meter * 3.28084}");
        }
        public static void FeetToMeter(double feet)
        {
            Console.WriteLine($"miles to km : {feet * 0.3048}");
        }


        public static void main()
        {
            //taking input from the user and instantly calling the methods
            double km = Convert.ToDouble(Console.ReadLine());
            KmToMile(km);
            double mile = Convert.ToDouble(Console.ReadLine());
            MileToKm(mile);
            double meter = Convert.ToDouble(Console.ReadLine());
            MeterToFeet(meter);
            double feet = Convert.ToDouble(Console.ReadLine());
            FeetToMeter(feet);

        }
    }
}
