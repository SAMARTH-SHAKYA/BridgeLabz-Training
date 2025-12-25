using BridgeLabzTraining.Methods.level1;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level3
{
    internal class FootballTeam
    {
        public static void SumEle(int[] heights)
        {
            int sum = 0;
            for (int i = 0; i < heights.Length; i++) 
            { 
                sum += heights[i];
            }
            Console.WriteLine($"sum of all elements is : {sum}");
        }

        public static void MeanEle(int[] heights)
        {
            int sum = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                sum += heights[i];
            }
            int mean = sum/heights.Length;
            Console.WriteLine($"mean of all elements is : {mean}");
        }

        public static void ShotestHeight(int[] heights)
        {
            int min = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] < min)
                {
                    min = heights[i];
                }
            }
            Console.WriteLine($"Min of all elements is : {min}");
        }

        public static void TallestHeight(int[] heights)
        {
            int max = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > max)
                {
                    max = heights[i];
                }
            }
            Console.WriteLine($"Tallest of all elements is : {max}");
        }

        public static void main()
        {
            int[] heights = new int[11];

            Random rand = new Random();

            Console.WriteLine("Randomly generated numbers are");
            for (int i = 0; i < 11; i++)
            {
                heights[i] = rand.Next(150, 251);
                Console.WriteLine(heights[i]);
            }

            SumEle(heights);
            MeanEle(heights);
            ShotestHeight(heights);
            TallestHeight(heights);
        }
    }
}
