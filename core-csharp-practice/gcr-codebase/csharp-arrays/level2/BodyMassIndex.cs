using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BodyMassIndex
    {
        public double CalculateBMI(double weight,double height)
        {
            double newHeight = height/100;
            double bmi = weight /( newHeight*newHeight);

            return bmi;
        }

        public string CalculateStatus(double bmi)
        {
            if (bmi <= 18.4)
            {
                return "Underweight";
            }
            else if(bmi >= 18.5 && bmi <= 24.9)
            {
                return "Normal";
            }
            else if(bmi  >= 25 &&  bmi <= 39.9)
            {
                return "Overweight";
            }
            return "Obese";
        }
        public void Bmi()
        {
            //taking number of persons count form the user
            int num = Convert.ToInt32(Console.ReadLine());

            double[] weight = new double[num];
            double[] height = new double[num];
            double[] bmi = new double[num];
            string[] weightStatus = new string[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter weight");
                weight[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter height in cm");
                height[i] = Convert.ToInt32(Console.ReadLine());

                bmi[i] = CalculateBMI(weight[i], height[i]);
                weightStatus[i] = CalculateStatus(bmi[i]);
            }


            for (int j = 0; j < num; j++) 
            {
                Console.WriteLine($"Height is {height[j]}, weight is {weight[j]}, Bmi is {bmi[j]} and status is {weightStatus[j]}");
            }

        }
    }
}
