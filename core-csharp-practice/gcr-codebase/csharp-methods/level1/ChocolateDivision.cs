using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class ChocolateDivision
    {
        public void CalDivision(int numberOfChocolates,int numberOfChildren)
        {
            int divided = numberOfChocolates / numberOfChildren;
            int remaining = numberOfChocolates % numberOfChildren;

            Console.WriteLine($"The number of chocolates each child gets is {divided} and the number of remaining chocolates is {remaining}");
        }
        public void main()
        {
            //taking input from the user
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

            int numberOfChildren = Convert.ToInt32(Console.ReadLine());

            //calling the method
            CalDivision(numberOfChocolates,numberOfChildren);
        }
    }
}
