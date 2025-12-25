using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level3
{
    internal class ScoreCard
    {

        //program to calculate grades
        public static string CalculateGrades(double percentage)
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
        public static int[,] GenerateScores(int students)
        {
            int[,] pcm = new int[students, 3];
            Random rand = new Random();

            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pcm[i, j] = rand.Next(10, 100);
                }
            }
            return pcm;
        }

        public static double[,] CalculateStats(int[,] pcm)
        {
            int students = pcm.GetLength(0);
            double[,] result = new double[students, 3];

            for (int i = 0; i < students; i++)
            {
                double total = pcm[i, 0] + pcm[i, 1] + pcm[i, 2];
                double avg = total / 3;
                double percent = (total / 300) * 100;
                result[i, 0] = Math.Round(total, 2);
                result[i, 1] = Math.Round(avg, 2);
                result[i, 2] = Math.Round(percent, 2);
            }
            return result;
        }

        public static void Display(int[,] pcm, double[,] stats)
        {
            Console.WriteLine("Stu\tMath\tPhy\tChem\tTotal\tAvg\t%\tGrade");

            for (int i = 0; i < pcm.GetLength(0); i++)
            {
                string grade = CalculateGrades(stats[i, 2]);

                Console.WriteLine(
                    $"{i + 1}\t{pcm[i, 0]}\t{pcm[i, 1]}\t{pcm[i, 2]}\t{stats[i, 0]}\t{stats[i, 1]}\t{stats[i, 2]}\t{grade}"
                );
            }
        }

        public static void CalPer2D()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            int[,] pcmScores = GenerateScores(num);
            double[,] stats = CalculateStats(pcmScores);

            Display(pcmScores, stats);
        }
    }
}
