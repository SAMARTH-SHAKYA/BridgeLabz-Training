using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class Factors
    {
        public void FactorsPrint() {
            //taking inout from the user
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            int count = 0;
            //checking the factors and intilizing into the factors array
            for(int i = 1; i <= num / 2; i++)
            {
                if(count >= 9)
                {
                    Console.WriteLine("Array size excedded");
                    break;
                }
                else if(num % i == 0)
                {
                    arr[count] = i;
                    count++;
                }
                else
                {
                    continue;
                }
            }
            for(int j = 0; j < 10; j++)
            {
                Console.WriteLine(arr[j]);
            }
        }
    }
}
