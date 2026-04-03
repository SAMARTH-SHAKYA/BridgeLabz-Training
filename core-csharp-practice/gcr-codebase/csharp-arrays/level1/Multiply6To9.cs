using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class Multiply6To9
    {
        public void Multiply() {
            int[] arr = new int[3];
            // taking number from the user
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                // intilizing multiple from 6 to 9
                arr[i] = (i + 6) * num;
            }

            //Printing multilication table using for loop through array
            for (int j = 0; j < arr.Length; j++) 
            { 
                Console.WriteLine(arr[j]);
            }
        }
    }
}
