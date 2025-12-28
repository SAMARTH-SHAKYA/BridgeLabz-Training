using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.builtIn.level2
{
    internal class GCDandLCM
    {
        public static void main()
        {
            Console.WriteLine("Enter  numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int gcd = FindGCD(num1, num2);
            int lcm = FindLCM(num1, num2, gcd);

            Console.WriteLine("GCD = " + gcd);
            Console.WriteLine("LCM = " + lcm);
        }

        public static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }
        public static int FindLCM(int a, int b, int gcd)
        {
            return (a * b) / gcd;
        }
    }
}
