using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level2
{
    internal class RandomAvg
    {
        public static int Avg(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum/arr.Length;
        }
        public static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static void main()
        {
            int[] arr = new int[5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                arr[i] = rand.Next(1000,9999);
            }
            Console.WriteLine("The random array is");
            for(int j=0; j<4; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("Average");
            Console.WriteLine(Avg(arr));
            Console.WriteLine("Minimum");
            Console.WriteLine(Min(arr));
            Console.WriteLine("Maximum");
            Console.WriteLine(Max(arr));

        }

    }
}
