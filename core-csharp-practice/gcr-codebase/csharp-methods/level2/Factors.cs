using BridgeLabzTraining.arrays.level1;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level2
{
    internal class Factors
    {
        public static int[] FindFactors(int num)
        {
            int temp = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    temp++;
                }
               
            }
            int[] arr = new int[temp];
            int count = 0;
            //checking the factors and intilizing into the factors array
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    arr[count] = i;
                    count++;
                }
            }
            return arr;
        }
        public static void DisplayFactors(int[] arr)
        {
            Console.WriteLine("Printing the factors of the given number");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void DisplaySum(int[] arr)
        {
            Console.WriteLine("Printing the Sum");
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
        public static void DisplayProduct(int[] arr)
        {
            Console.WriteLine("Printing the Product");
            int product = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine(product);
        }
        public static void DisplaySquares(int[] arr)
        {
            Console.WriteLine("Printing the Squares");
            double squares = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                squares *= Math.Pow(arr[i],2);
            }
            Console.WriteLine(squares);
        }
        public static void main()
        {
            //taking input from the user 
            int number = Convert.ToInt32(Console.ReadLine());

            int[] res = FindFactors(number);

            DisplayFactors(res);
            DisplaySum(res);
            DisplayProduct(res);
            DisplaySquares(res);




        }
    }
}
