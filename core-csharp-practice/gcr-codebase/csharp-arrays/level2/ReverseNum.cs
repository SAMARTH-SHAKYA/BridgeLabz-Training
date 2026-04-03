using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class ReverseNum
    {
        public void Reverse()
        {
            //taking input from the user
            int num = Convert.ToInt32(Console.ReadLine());

            int len = Convert.ToString(num).Length;

            int[] arr = new int[len];

            int count = 0;

            //applying logic to reverse

            while (num > 0) {
                arr[count] = num % 10;
                num /= 10;
                count++;
            }

            //printing the reverse number
            for (int i = 0; i < len; i++)
            {
                Console.Write(arr[i]);
            }
        } 
    }
}
