using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level2
{
    internal class UnitConversion2
    {
        public static void YardsToFeet(double yards)
        {
            Console.WriteLine($"yards to feet : {yards * 3}");
        }
        public static void FeetToYards(double feet)
        {
            Console.WriteLine($"feet to yards : {feet * 0.333333}");
        }
        public static void MetersToInches(double meters)
        {
            Console.WriteLine($"meters to inches : {meters * 39.3701}");
        }
        public static void InchesToMeters(double inches)
        {
            Console.WriteLine($"inches to meters : {inches * 0.0254}");
        }
        public static void InchesToCentimeters(double inches)
        {
            Console.WriteLine($"inches to centimeters : {inches * 2.54}");
        }
        public static void main()
        {
            //taking input from the user and instantly calling the methods
            double yards = Convert.ToDouble(Console.ReadLine());
            YardsToFeet(yards);
            double feet = Convert.ToDouble(Console.ReadLine());
            FeetToYards(feet);
            double meters = Convert.ToDouble(Console.ReadLine());
            MetersToInches(meters);
            double inches1 = Convert.ToDouble(Console.ReadLine());
            InchesToMeters(inches1);
            double inches2 = Convert.ToDouble(Console.ReadLine());
            InchesToCentimeters(inches2);
        }
    }
}
