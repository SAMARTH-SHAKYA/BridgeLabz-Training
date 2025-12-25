using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level3
{
    internal class Calender
    {
        public static string GetMonth(int month)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int ans = month - 1;
            return months[ans];
        }
        public static bool LeapOrNot(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
               return true;
            }
            return false;
        }
        
        public static int DaysInMonth(int month,int year)
        {
            int[] days = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            if (month == 2 && LeapOrNot(year))
            {
                return 29;
            }
            int ans = month - 1;
            return days[ans];
        }

        public static int FirstDay(int month,int year)
        {
            int d = 1;
            int m = month;
            int y = year;
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            return d0; 
        }
        public static void main()
        {
            Console.WriteLine("Enter month and year");
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetMonth(month) + year);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            int firstDay = FirstDay(month, year);

            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("    ");
            }

            int daysInMonth = DaysInMonth(month, year);

            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,3} ");

                if ((day + firstDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }


        }
    }
}
