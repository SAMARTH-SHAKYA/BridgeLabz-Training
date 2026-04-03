using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class SecondLargest
    {
        public void LargestFind()
        {

            //taking inout from the user
            int num = Convert.ToInt32(Console.ReadLine());
            //int len = num.ToString().Length;
            int[] arr = new int[10];

            int count = 0;
            while (num > 0)
            {
                arr[count] = num % 10;
                num /= 10;
                count++;
            }
            

            int largest = arr[0];
            int slargest = 0;


            //applying logic to find largest and second largest 
            for (int i = 1; i < 10; i++)
            {
                if (arr[i] > largest)
                {
                    slargest = largest;
                    largest = arr[i];

                }
                else if (arr[i] > slargest && arr[i] < largest)
                {
                    slargest = arr[i];
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"Largest Element {largest}");
            Console.WriteLine($"Second Largest Element {slargest}");
        }
    }
}
