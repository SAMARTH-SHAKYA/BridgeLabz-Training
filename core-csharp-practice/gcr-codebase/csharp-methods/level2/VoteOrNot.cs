using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level2
{
    internal class VoteOrNot
    {
        public static bool VoteOrNott(int x)
        {
            bool result = false;
            //checking age to vote or not
            if (x >= 18)
            {
                result = true;
                return result;
            }
            return result;
        }
        public static  void main()
        {
            //declaring an array
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                //taking input from the user
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(VoteOrNott(arr[i]));
                
            }

        }
    }
}
