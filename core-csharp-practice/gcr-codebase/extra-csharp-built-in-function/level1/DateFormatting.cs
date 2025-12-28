using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.builtIn.level1
{
    internal class DateFormatting
    {
        public static void main()
        {
            //taking input from the user
            DateTime today = DateTime.Now;

            string f1 = today.ToString("dd/MM/yyyy");
            string f2 = today.ToString("yyyy-MM-dd");
            string f3 = today.ToString("ddd, MMM dd, yyyy");

            Console.WriteLine("Format 1: " + f1);
            Console.WriteLine("Format 2: " + f2);
            Console.WriteLine("Format 3: " + f3);
        }
    }
}
