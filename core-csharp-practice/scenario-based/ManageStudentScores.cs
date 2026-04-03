/*
 * ManageStudentScores is a console-based, non-static C# class that helps manage and analyze student scores. 
 * It takes input for the number of students and their scores, then calculates and displays the average score, highest score, and lowest score. 
 * It also identifies and prints all scores that are above the calculated average. 
 * The class uses separate methods for input handling, calculations, and result display, making it a clear example of modular programming and basic array processing in C#.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Senario_based
{
    internal class ManageStudentScores
    {
        // method which will be called by Main method
        public void ManageStudents()
        {
            Console.WriteLine("-----Manage your Students scores------");
            TakeInputAndPrintResults();

        }

        //method to take input and show all the results
        public void TakeInputAndPrintResults()
        {
            Console.WriteLine("Enter number of students");
            int num = Convert.ToInt32(Console.ReadLine());

            double[] scores = new double[num];

            //taking input from the user
            Console.WriteLine("Enter scores of students one by one");
            for(int i = 0; i < scores.Length; i++)
            {

                scores[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"Avg score is {CalculateAverage(scores)}");
            Console.WriteLine($"Max score is {FindHighest(scores)}");
            Console.WriteLine($"Min score is {FindLowest(scores)}");
            DisplayAboveAverage(scores);
        }

        //method to calculate average 
        public double CalculateAverage(double[] scores)
        {
            double sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            return sum / scores.Length;
        }

        //method to find the highest score
        public double FindHighest(double[] scores)
        {
            double max = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > max)
                    max = scores[i];
            }
            return max;
        }

        //method to find the lowest score
        public double FindLowest(double[] scores)
        {
            double min = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min)
                    min = scores[i];
            }
            return min;
        }

        //method to find and display all above average scores
        public void DisplayAboveAverage(double[] scores)
        {
            double avg = CalculateAverage(scores);
            Console.WriteLine("Above average scores are:");

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > avg)
                {
                    Console.Write(scores[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }

}
