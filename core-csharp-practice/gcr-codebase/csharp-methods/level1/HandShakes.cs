using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class HandShakes
    {
        //method to calculte number of handshakes
        public int TotalHand(int n)
        {
            return (n * (n - 1)) / 2; 
        }
        public void main()
        {
            //taking inout from the user
            int persons = Convert.ToInt32(Console.ReadLine());

            int res = TotalHand(persons);

            //printing the reslut
            Console.WriteLine($"Total handshakes {res}") ;
        }
    }
}
