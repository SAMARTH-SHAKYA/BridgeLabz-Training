using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level2
{
    internal class CheckNumber
    {
        public void CheckEvenOdd(int n)
        {
            if (n / 2 * 2 == n)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
        public void checkNumber(int num)
        {

            if (num > 0)
            {
                Console.WriteLine("Number is Positive");
                //calling checkEvenOdd for checking number is even or odd
                CheckEvenOdd(num);
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
        }
        public void Compare(int x,int y)
        {
            if (x == y)
            {
                Console.WriteLine("Equal");
            }
            else if (x < y)
            {
                Console.WriteLine($"{x} is smaller");
            }
            else 
            {
                Console.WriteLine($"{x} is greater");
            }
        }
        //taking input from the user
        public void UserInput()
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                //calling cheknumber for +,- and zero
                checkNumber(arr[i]);
            }
            Compare(arr[0], arr[4]);
        }
    }
}
