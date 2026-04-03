using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class TrigonometricFunctions
    {
        public void CalTrigoFun(double angle)
        {
            // convert degrees to radians
            double radians = angle * Math.PI/180;

            double resultSin = Math.Sin(radians);
            double resultCos = Math.Cos(radians);
            double resultTan = Math.Tan(radians);

            // printing result
            Console.WriteLine($"Sin {resultSin}, Cos {resultCos}, Tan {resultTan}, Angle in Radians {radians}");
        }

        public void main()
        {
            // taking input from user
            double angle = Convert.ToDouble(Console.ReadLine());

            // calling method
            CalTrigoFun(angle);
        }
    }
}
