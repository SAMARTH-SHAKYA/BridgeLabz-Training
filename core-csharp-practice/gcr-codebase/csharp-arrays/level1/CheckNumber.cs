using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class CheckNumber
    {   public void checkEvenOdd(int n)
        {
            if(n/2 * 2 == n)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
        public void  checkNumber(int num)
        {

            if (num > 0)
            {
                Console.WriteLine("Number is Positive");
                //calling checkEvenOdd for checking number is even or odd
                checkEvenOdd(num);
            }
            else if(num<0){
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
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
        }
    }
}
