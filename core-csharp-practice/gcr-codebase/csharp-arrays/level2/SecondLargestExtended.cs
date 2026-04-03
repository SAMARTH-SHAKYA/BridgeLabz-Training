using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class SecondLargestExtended
    {

        public void LargestFindExtended()
        {

            //taking inout from the user
            long num = Convert.ToInt64(Console.ReadLine());
            int maxDigiit = 10;
            int[] arr = new int[maxDigiit];

            int count = 0;
            while (num > 0)
            {

                if (count == maxDigiit)
                {
                    //creating a new array if size excedded
                    maxDigiit += 10;
                    int[] temp = new int[maxDigiit];
                    for (int j = 0; j < temp.Length-10; j++)
                    {
                        temp[j] = arr[j];
                    }
                    arr = temp;
                }

                arr[count] = Convert.ToInt32(num % 10);
                num /= 10;
                count++;
            }
            

        


            int largest = arr[0];
            int slargest = 0;


            //applying logic to find largest and second largest 
            for (int i = 1; i< 10; i++)
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
