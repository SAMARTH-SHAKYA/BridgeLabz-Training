using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class RoundsAthelete
    {
        //method to calculate the rouds
        public int CalculateAns(int a,int b,int c)
        {
            int perimeter = a + b + c;
            int rounds = 5000 / perimeter;
            return rounds;
        }
        public void InputSides()
        {
            //taking input from the user
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int res = CalculateAns(a,b,c); 

            //printin the reslyut
            Console.WriteLine($"The total number of rounds the athlete will run is {res} to complete 5 km");
        }
    }
}
