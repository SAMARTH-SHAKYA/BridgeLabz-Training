using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.builtIn.level2
{
    internal class Fibonnaci
    {
        public static void main()
        {
            Console.WriteLine("Enter number of terms");
            int terms = Convert.ToInt32(Console.ReadLine());

            PrintFibonacci(terms);
        }

        public static void PrintFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }
        }
    }
}
