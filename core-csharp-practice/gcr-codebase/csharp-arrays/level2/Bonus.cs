using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Bonus
    {
        public void EmpBonus()
        {
            //Declaring the array
            double[] currSalary = new double[10];
            double[] yearOfservice = new double[10];
            double[] newSalary = new double[10];
            for(int i = 0; i < 10; i++)
            {
                //Taking input from the user
                Console.WriteLine("Salary:");
                currSalary[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Year of Service:");
                yearOfservice[i] = Convert.ToDouble(Console.ReadLine());

                //applying logic
                if (yearOfservice[i] >= 5)
                {
                    newSalary[i] = (currSalary[i] * 0.05) + currSalary[i];
                }
                else
                {
                    newSalary[i] = (currSalary[i] * 0.02) + currSalary[i];
                }

            }
            //printing new salaries
            for(int j = 0; j < 10; j++)
            {
                Console.WriteLine($"New Salaries:{newSalary[j]}");

            }
            


        }
    }
}
