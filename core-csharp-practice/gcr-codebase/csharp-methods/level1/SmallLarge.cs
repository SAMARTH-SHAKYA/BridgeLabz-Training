using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class SmallLarge
    {
        //method to calcute the smallest and largest number
        public void CalSmallLarge(int num1,int num2,int num3)
        {
            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} largest");
                if (num2 < num3)
                {
                    Console.WriteLine($"{num2} smallest");
                }
                else
                {
                    Console.WriteLine($"{num3} smallest");
                }
            }
            else if(num2>num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} largest");
                if (num1 < num3)
                {
                    Console.WriteLine($"{num1} smallest");
                }
                else
                {
                    Console.WriteLine($"{num3} smallest");
                }
            }
            else
            {
                Console.WriteLine($"{num3} largest");
                if (num1 < num2)
                {
                    Console.WriteLine($"{num1} smallest");
                }
                else
                {
                    Console.WriteLine($"{num2} smallest");
                }
            }
        }
        public void main()
        {
            //taking input from the user
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            //calling the method
            CalSmallLarge(num1,num2,num3);
        }
    }
}
