using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level2
{
    internal class SumNatural
    {
        public static void main()

        {
            //taking input from the user
            double n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Not valid");
            }
            //calling methods
            double formula = Formula(n);

            double recur = Recursive(n);

            Console.WriteLine($"From formula the sum is {formula} and using the for loop the sum is {recur}");
        }

        public static double Formula(double n)
        {
            return (n * (n + 1)) / 2;
        }

        public static double Recursive(double n)
        {
            if (n == 0) {
                return 0;
            }
            return n + Recursive(n - 1);
        }
    }
}
