using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.builtIn.level1
{
    internal class DateArithematic
    {
        public static void main()
        {
            Console.WriteLine("Enter a date (yyyy-MM-dd):");
            DateTime date = DateTime.Parse(Console.ReadLine());

            DateTime newDate = date.AddDays(7);   
            newDate = newDate.AddMonths(1);        
            newDate = newDate.AddYears(2);         
            newDate = newDate.AddDays(-21);        

            Console.WriteLine("Final Date: " + newDate.ToString("yyyy-MM-dd"));
        }
    }
}
