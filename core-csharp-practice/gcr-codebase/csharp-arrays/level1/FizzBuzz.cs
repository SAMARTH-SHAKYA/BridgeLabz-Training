using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class FizzBuzz
    {
        public void FizzBuzzPrint()
        {
            //taking input from the user 
            int num = Convert.ToInt32(Console.ReadLine());

            //calculating size and declaring array
            //int three = num / 3;
            //int five = num / 5;
            //int both = num / 15;

            //int size = three + five - both;

            //string[] arr = new string[size];
            //int count = 0;
            //// checking divisibility
            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        arr[count] = "FizzBuzz";
            //        count++;
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        arr[count] = "Fizz";
            //        count++;
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        arr[count] = "Buzz";
            //        count++;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

            //for (int j = 0; j < size; j++)
            //{
            //    Console.WriteLine(arr[j]);
            //}

            string[] arr = new string[num];

            // checking divisibility
            for (int i = 0; i < num; i++)
            {
                if ((i+1) % 3 == 0 && (i+1) % 5 == 0)
                {
                    arr[i] = "FizzBuzz";
                }
                else if ((i+1) % 3 == 0)
                {
                    arr[i] = "Fizz";
                }
                else if ((i+1) % 5 == 0)
                {
                    arr[i] = "Buzz";
                }
                else
                {
                    arr[i] = "Both not divisible";
                }
            }

            for(int j = 0; j < num; j++)
            {
                Console.Write($"Number : {j+1} :");
                Console.WriteLine(arr[j]);
            }
        }
    }
}
