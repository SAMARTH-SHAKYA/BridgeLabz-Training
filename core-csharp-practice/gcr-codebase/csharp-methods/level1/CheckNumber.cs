using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class CheckNumber
    {
        public void Check(int value)
        {
            if (value < 0)
            {
                Console.WriteLine("Negative");

            }
            else if (value == 0)
            {
                Console.WriteLine("Zero");
            }
            else 
            {
                Console.WriteLine("Positive");
            }
        }
        public void main()
        {
            // taking input from the user
            int num = Convert.ToInt32(Console.ReadLine());
            //calling the method 
            Check(num);
        }
    }
}
