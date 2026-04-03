using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.extra
{
    internal class StringOccurences
    {
        public static void main()
        {
            //taking input from the user
            string str = Console.ReadLine();
            string sub = Console.ReadLine();
            int count = 0;
            int lenSub = sub.Length;
            for (int i = 0; i <= str.Length - lenSub; i++)
            {
                int p1 = i;
                int p2;
                for (p2 = 0; p2 < lenSub; p2++)
                {
                    if (str[p1] != sub[p2])
                        break;
                    p1++;
                }
                if (p2 == lenSub)
                    count++;
            }

            Console.WriteLine($"Substring occurs { count} times.");
        }
    }
}
