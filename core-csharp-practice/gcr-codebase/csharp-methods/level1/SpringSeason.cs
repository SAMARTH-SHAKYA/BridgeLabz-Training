using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level1
{
    internal class SpringSeason
    {
        public void CheckSpring(int month,int day)
        {
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
            {
                Console.WriteLine("Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }
        public void main()
        {
            int month = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());
            CheckSpring(month,day);
            
        }
    }
}
