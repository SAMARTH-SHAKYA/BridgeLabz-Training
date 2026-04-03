using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class Sum
    {
        public void SumOfNumbers()
        {   //declaring array of size 10
            double[] numbers = new double[10];
            
            double sum = 0.0;
            
            for(int i = 0; i < numbers.Length; i++)
            {   //taking input from the user
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                //adding each number to the sum variable
                sum += numbers[i];
                if (numbers[i] <= 0)
                {
                    Console.WriteLine("Terminated");
                    break;
                }
            }
            // printing the output
            Console.WriteLine(sum);
        }
    }
}
