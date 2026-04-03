using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level2
{
    internal class LeapYear
    {
        public static void LeapOrNot(int year)
        {
            //applying logic to this code
            if ((year % 4 == 0 && year % 100 != 0 && year>=1582) || (year % 400 == 0 && year>=1582))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }
        public static void main()
        {
            //taking input from the user
            int year = Convert.ToInt32(Console.ReadLine());
            LeapOrNot(year);
        }
    }
}
