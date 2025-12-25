using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class SimpleInterest
    {
        //method to calculate interest 
        public double CalInterest(double x, double y, double z)
        {
            return (x * y * z)/100.00; 
        }


        public void main()
        {
            //taking input from the user
            double principle = Convert.ToDouble(Console.ReadLine());
            double rate = Convert.ToDouble(Console.ReadLine());
            double time = Convert.ToDouble(Console.ReadLine());

            //calling method
            double ans = CalInterest(principle, rate, time);

            //printing result
            Console.WriteLine($"The Simple Interest is {ans} for Principal {principle}, Rate of Interest {rate} and Time {time}");
        }
    }
}
