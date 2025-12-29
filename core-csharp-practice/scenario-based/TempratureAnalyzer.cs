/*
 * TempratureAnalyzer is a C# class that simulates and analyzes weekly hourly temperature data using a 7×24 2D array. 
 * It generates random temperatures between 20°C and 35°C for each hour of the week. 
 * The class provides methods to identify and display the hottest and coldest temperatures along with their respective days, calculate and display the average temperature for the week, and display day names using a switch-case. 
 * It demonstrates array manipulation, nested loops, random number generation, and basic data analysis in a modular, non-static structure.

 */
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BridgeLabzTraining.Senario_based
{
    
    internal class TempratureAnalyzer
    {
        // method which will be called by Main
        public void AnalyzeTemp()
        {
            float[,] tempData = new float[7, 24];
            GetTemp(tempData);
            HottestColdest(tempData);
            AvgTemp(tempData);
        }

        //method to get random temp in our array
        public  void GetTemp(float[,] tempData) 
        { 
            Random rnd = new Random();
            for(int i = 0; i < 7; i++)
            {
                //DisplayDay(i);
                for(int j= 0;j<24; j++)
                {
                    tempData[i, j] = 20f + (float)rnd.NextDouble() * 15f;
                    //Console.WriteLine($"At this time {j} temp is {tempData[i, j]}");
                }
            }


        }

        // method to display the day according to the number
        public void DisplayDay(int x)
        {
            switch (x)
            {
                case 0:
                    Console.WriteLine("Monday");
                    break;
                case 1:
                    Console.WriteLine("TuesDay");
                    break;
                case 2:
                    Console.WriteLine("Wednesday");
                    break;
                case 3:
                    Console.WriteLine("Thrusday");
                    break;
                case 4:
                    Console.WriteLine("Friday");
                    break;
                case 5:
                    Console.WriteLine("Saturaday");
                    break;
                case 6:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    break;
            }
        }


        //method to find hottest and coldest day and print it
        public void HottestColdest(float[,] tempData) 
        {
            float max = int.MinValue;
            int maxday = 0;
            float min = int.MaxValue;
            int minday = 0;

            for (int i = 0; i < 7; i++)
            {
                
                for (int j = 0; j < 24; j++)
                {
                    if (tempData[i,j] > max)
                    {
                        max = tempData[i,j];
                        maxday = j;
                    }
                }
            }
            
            Console.Write($"Maximum temp is {max} at day ");
            DisplayDay(maxday);
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {

                for (int j = 0; j < 24; j++)
                {
                    if (tempData[i, j] < min)
                    {
                        min = tempData[i, j];
                        minday = j;
                    }
                }
            }
            Console.Write($"Minmum temp is {min} at day ");
            DisplayDay(minday);
            Console.WriteLine();

        }

        //method to find the average temperature for 7 days
        public void AvgTemp(float[,] tempData)
        {
            float total = 0;
            for (int i = 0; i < 7; i++)
            {

                for (int j = 0; j < 24; j++)
                {
                    total += tempData[i,j];
                }
            }
            float avg = total / (7 * 24);

            Console.WriteLine($"Avg temp accross the week is {avg}");
        }
    }
}
