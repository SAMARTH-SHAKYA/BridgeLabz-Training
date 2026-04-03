using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level2
{
    internal class QuadraticRoots
    {
        public static double[] Calculate(double a, double b, double c)
        {
            //calculating delta
            double delta = (b * b) - (4 * a * c);
            if (delta > 0)
            {
                double[] arr = new double[2];
                arr[0] = (-b + Math.Sqrt(delta)) / (2 * a);
                arr[1] = (-b - Math.Sqrt(delta)) / (2 * a);
                return arr;
            }
            else if (delta == 0)
            {
                double[] arr = new double[1];
                arr[0] = -b / (2 * a);
                return arr;
            }
            else
            {
                return new double[0];
            }

        }
        public static void main()
        {
            //taking input from the user
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble (Console.ReadLine());

            double[] roots = Calculate(a, b, c);
            int length = roots.Length;
            //printing the result
            if (length == 0)
            {
                Console.WriteLine("No real roots");
            }
            else if (length == 1)
            {
                Console.WriteLine("Root: " + roots[0]);
            }
            else
            {
                Console.WriteLine($"Root 1: {roots[0]}");
                Console.WriteLine($"Root 2: {roots[1]}");
            }
        }
    }
}
