using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class QuotientRemainder
    {
        //method the find the quotient and remainder
        public void CalQuoRem(int a,int b)
        {
            int quo = a / b;
            int rem = a % b;
            Console.WriteLine($"Quotient {quo} and Remainder {rem}");
        }
        public void main()
        {
            //taking input from the user
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            

            //calling the method
            CalQuoRem(num1,num2);
        }
    }
}
