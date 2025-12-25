using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level3
{
    internal class Bonus
    {
        public static double CalculateBonusAmount(double amount,double yearOfservice)
        {
            double bonus = 0;
            if (yearOfservice > 5)
            {
                bonus = amount * 0.05;
            }
            else 
            {
                bonus = amount * 0.02;
            }

            return bonus;

            
        }
        public static double[,] NewSalaryBonus(double[,] currSalService)
        {
            double[,] newSalaryBonus = new double[10, 2];

            for (int i = 0; i < 10; i++) 
            {
                newSalaryBonus[i, 1] = CalculateBonusAmount(currSalService[i,0],currSalService[i, 1]);
                newSalaryBonus[i,0] = currSalService[i, 0] + newSalaryBonus[i,1];
            }

            return newSalaryBonus;
        }

        public static void Display(double[,] currSalService, double[,] newSalaryBonus)
        {
            double totalOld = 0;
            double totalNew = 0;
            double totalBonus = 0;
            for (int i = 0; i < 10; i++)
            {
                totalOld += currSalService[i,0];
                totalNew += newSalaryBonus[i,0];
                totalBonus += newSalaryBonus[i,1];
            }
            Console.WriteLine($"Total old salary:{totalOld}, Total new salary:{totalNew},total bonus {totalBonus}");
        }
        public static void CreateSalary()
        {
            double[,] currSalService = new double [10, 2];
            Random rand = new Random();
            for (int i = 0; i < 10; i++) 
            {
                currSalService[i,0] = rand.Next(10000,100000);
                currSalService[i,1] = rand.Next(0,31);
            }

            double[,] newSalaryBonus =  NewSalaryBonus(currSalService);
            Display(currSalService, newSalaryBonus);
        }
    }
}
