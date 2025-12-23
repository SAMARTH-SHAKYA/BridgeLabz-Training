using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class VoteOrNot
    {
        public void VoteOrNott()
        {
            //declaring an array
            int[] arr = new int[10];
            
            for (int i = 0; i < arr.Length; i++)
            {   
                //taking input from the user
                arr[i] = Convert.ToInt32(Console.ReadLine());

                //checking age to vote or not
                if(arr[i] >= 18)
                {
                    Console.WriteLine("Eligible to vote");
                }
                // checking for valid age
                else if (arr[i] < 0)
                {
                    Console.WriteLine("Enter a valid Age");
                }
                else
                {
                    Console.WriteLine("Not eligible to vote");
                }
            }
            
        }
    }
}
