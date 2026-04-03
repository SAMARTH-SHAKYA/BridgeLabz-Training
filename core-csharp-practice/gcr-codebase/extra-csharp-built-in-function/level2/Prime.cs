using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.builtIn.level2
{
    internal class Prime
    {
        public static void main()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            CheckPrime(num);
        }

        public static void CheckPrime(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine($"{n} is not a prime number");
                return;
            }

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine($"{n} is not a prime number");
                    return;
                }
            }

            Console.WriteLine($"{n} is a prime number");
        }
    }
}
