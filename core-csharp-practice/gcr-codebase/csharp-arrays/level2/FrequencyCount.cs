using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class FrequencyCount
    {
        public void Count()
        {
            // taking input from the user
            int num = Convert.ToInt32(Console.ReadLine());

            int[] freq = new int[10];

            while (num > 0)
            {
                int temp = num % 10;
                freq[temp]++;
                num = num / 10;
            }

            for (int i = 0; i < 10; i++)
            {
                if( freq[i] > 0)
                {
                    Console.WriteLine($"{i} occurs {freq[i]} times");
                }
                
            }
        }
    }
}
