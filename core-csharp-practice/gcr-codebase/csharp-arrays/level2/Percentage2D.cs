using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Percentage2D
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

        public void CalculatePercentage2D()
        {


            //taking number of students 
            int num = Convert.ToInt32(Console.ReadLine());

            //  declaring 2D marks array
            int[,] marks = new int[num, 3];

            int[] percentage = new int[num];

            string[] grades = new string[num];

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Enter maths marks");
                        marks[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (j == 1) 
                    {
                        Console.WriteLine("Emter phy marks");
                        marks[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Enter chem marks");
                        marks[i, j] = Convert.ToInt32(Console.ReadLine());

                        percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, j]) / 3;

                        grades[i] = CalculateGrades(percentage[i]);

                    }
                }
            }
            //printing results
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        Console.Write($"maths marks {marks[i,j]}, ");
                  
                    }
                    else if (j == 1)
                    {
                        Console.Write($"phy marks {marks[i,j]}, ");
                
                    }
                    else
                    {
                        Console.WriteLine($"chem marks {marks[i,j]}, percentage {percentage[i]}, grades {grades[i]}");
                     
                    }
                }
            }


        }
        


    }
}
