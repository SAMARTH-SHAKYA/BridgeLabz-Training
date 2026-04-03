using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MeanHeight
    {
        public void Heigth()
        {

            double[] arr = new double[11];
            double sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {   //taking input from the user
                arr[i] = Convert.ToDouble(Console.ReadLine());
                //adding user input value to sum 
                sum += arr[i];

            }
            //calculating mean of heigths
            double mean = sum/arr.Length;
            Console.WriteLine(mean);
        }
    }
}
