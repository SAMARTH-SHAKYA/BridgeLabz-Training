using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Percentage
    {
        //program to calculate grades
        public string CalculateGrades(double percentage)
        {
            if (percentage >= 80)
            {
                return "Level 4";
            }
            else if (percentage >= 70 && percentage < 80)
            {
                return "Level 3";
            }
            else if (percentage >= 60 && percentage < 70)
            {
                return "Level 2";
            }
            else if (percentage >= 50 && percentage < 60)
            {
                return "Level 1";
            }
            else if (percentage >= 40 && percentage < 50)
            {
                return "Level 1 Below";
            }
            
             return "Remedia standards";
            
        }
        public void CalculatePer()
        {
            //taking input from the user total students
            int num = Convert.ToInt32(Console.ReadLine());

            //declaring arrays to storre marks and percentage 
            int[] maths = new int[num];
            int[] phy = new int[num];
            int[] chem = new int[num];
            double[] percentage = new double[num];
            string[] grade = new string[num];

            //initilizinng values to the arrays
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter maths marks");
                maths[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter phy marks");
                phy[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter chem marks");
                chem[i] = Convert.ToInt32(Console.ReadLine());
                percentage[i] = (maths[i]+phy[i]+chem[i])/3;
                grade[i] = CalculateGrades(percentage[i]);
            }
            for (int j = 0; j < num; j++) 
            {
                Console.WriteLine($"Maths : {maths[j]}, Physics {phy[j]}, Chem : {chem[j]}, Percentage : {percentage[j]}, Grade : {grade[j]}");
            }
        }

       
    }
}
