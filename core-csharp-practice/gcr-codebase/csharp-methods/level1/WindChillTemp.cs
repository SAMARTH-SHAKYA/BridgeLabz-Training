using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class WindChillTemp
    {
        public double CalWindChill(double temp, double windSpeed)
        {
            return 35.74 + (0.6215 * temp) + (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);


        }
        public void main()
        {
            //taking input from the user
            double temp = Convert.ToDouble(Console.ReadLine());
            double windSpeed = Convert.ToDouble(Console.ReadLine());

            //calling the method
            double res = CalWindChill(temp, windSpeed);
        }
    }
}
