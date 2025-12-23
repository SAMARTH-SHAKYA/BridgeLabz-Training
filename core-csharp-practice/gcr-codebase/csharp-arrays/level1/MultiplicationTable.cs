using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MultiplicationTable
    {
        public void PrintTable()
        {
            // taking input from the user
            int num = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                // intilizing multiples to arr
                arr[i] = num * (i+1);
            }

            for (int j = 0; j < arr.Length; j++) 
            { 
                // Printing values 
                Console.WriteLine(arr[j]);
            }
        }
    }
}
