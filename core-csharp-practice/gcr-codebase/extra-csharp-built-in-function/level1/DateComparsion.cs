using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.builtIn.level1
{
    internal class DateComparsion
    {
        public static void Main()
        {
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            if (date1 < date2)
                Console.WriteLine("First date is earlier than second date");
            else if (date1 > date2)
                Console.WriteLine("First date is later than second date");
            else
                Console.WriteLine("Both dates are the same");
        }
    }
}
