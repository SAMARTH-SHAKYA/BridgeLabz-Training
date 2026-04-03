using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BmiMultiD
    {
        // to calculate bmi 
        public double CalculateBMI(double weight, double height)
        {
            double newHeight = height / 100;
            double bmi = weight / (newHeight * newHeight);

            return bmi;
        }
        //to calculate weight status
        public string CalculateStatus(double bmi)
        {
            if (bmi <= 18.4)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                return "Normal";
            }
            else if (bmi >= 25 && bmi <= 39.9)
            {
                return "Overweight";
            }
            return "Obese";
        }
        public void BmiMulti2D()
        {
            //taking input from the user 
            int num = Convert.ToInt32(Console.ReadLine());
            double[,] persons = new double[num,3];
            string[] weightStatus = new string[num];
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Enter weigth:");
                        persons[i,j] = Convert.ToDouble(Console.ReadLine());
                    }
                    else if(j == 1)
                    {
                        Console.WriteLine("Enter height in cm");
                        persons[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        persons[i,j] = CalculateBMI(persons[i,0], persons[i,1]);
                        weightStatus[i] = CalculateStatus(persons[i, j]);
                    }
                        
                }

            }

            //printing values
            for(int i = 0; i < num; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine(persons[i, j]);
                    if (j == 2)
                    {
                        Console.WriteLine(weightStatus[i]);
                    }
                }
            }
        }
    }
}
