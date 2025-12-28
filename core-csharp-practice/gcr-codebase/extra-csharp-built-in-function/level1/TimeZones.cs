using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.builtIn.level1
{
    internal class TimeZones
    {
        public static void main()
        {
            DateTimeOffset utc = DateTimeOffset.UtcNow;
            Console.WriteLine("UTC/GMT Time: " + utc);

            TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTimeOffset ist = TimeZoneInfo.ConvertTime(utc, istZone);
            Console.WriteLine("IST Time: " + ist);

            TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTimeOffset pst = TimeZoneInfo.ConvertTime(utc, pstZone);
            Console.WriteLine("PST Time: " + pst);
        }
    }
}
