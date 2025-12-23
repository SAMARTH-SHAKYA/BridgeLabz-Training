using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class EvenOdd
    {
        public void FindEvenOdd()
        {   //taking input from the user
            int num = Convert.ToInt32(Console.ReadLine());


            
            int even = num/2;
            int odd;

            // detemining the size of the arrays
            if (num % 2 == 0)
            {
                
                odd = num / 2;
            }
            else 
            {
                odd = (num / 2) + 1;
            }

            // declaring and intilizing the array
            int[] evenarr = new int[even];
            int[] oddarr = new int[odd];
            int j = 0;
            int k = 0;

            //putting even and odd numbers into theri respective arrays
            for(int i = 1; i <= num; i++)
            {
                if (i % 2 == 0) 
                { 
                    evenarr[j] = i;
                    j++;
                }
                else
                {
                    oddarr[k] = i;
                    k++;
                }

            }

            //printing the odd and even array one by one
            Console.WriteLine("Printing even numbers");
            for(int l = 0; l < even; l++)
            {
                Console.WriteLine(evenarr[l]);
            }
            Console.WriteLine("Printing odd numbers");
            for(int m=0;m< odd; m++)
            {
                Console.WriteLine(oddarr[m]);
            }
        }
    }
}
