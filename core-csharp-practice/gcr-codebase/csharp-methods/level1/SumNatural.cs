using BridgeLabzTraining.arrays.level1;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class SumNatural
    {
        //method to calculate sum of natural numbers
        public void CalNatural(int num)
        {
            if (num > 0)
            {
                int sum = 0;
                for(int i = 1; i <= num; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum of {num} natural numbers is {sum}");
            }
            else
            {
                Console.WriteLine($"The number {num} is not a natural number");
            }
        }
        public void main()
        {
            //taking input from the user
            int num = Convert.ToInt32(Console.ReadLine());

            
            //calling the method
            CalNatural(num);
        }
    }
}
