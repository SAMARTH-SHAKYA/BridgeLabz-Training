using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.builtIn.level2
{
    internal class MaxThreeNum
    {
        public static void main()
        {
            Console.WriteLine("Enter numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            MaxThreeNumbers(num1, num2, num3);

        }

        public static void MaxThreeNumbers(int a,int b,int c)
        {
            if(a > b && a>c)
            {
                Console.WriteLine($"{a} is largest");
            }
            else if(b>a && b>c) 
            {
                Console.WriteLine($"{b} is largest");
            }
            else
            {
                Console.WriteLine($"{c} is largest");
            }
        }
    }
}
