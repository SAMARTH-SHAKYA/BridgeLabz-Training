using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.extra
{
    internal class Lexographical
    {
        public static void main()
        {
            //taking inpout from the user
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            //calling the method
            CompareStrings(s1, s2);
        }

        static void CompareStrings(string s1, string s2)
        {
            int i = 0;
            while (i < s1.Length && i < s2.Length)
            {
                if (s1[i] < s2[i])
                {
                    Console.WriteLine($"{s1} comes before {s2}");
                    return;
                }
                else if (s1[i] > s2[i])
                {
                    Console.WriteLine($"{s2} comes before {s1}");
                    return;
                }
                i++;
            }

            if (s1.Length < s2.Length)
                Console.WriteLine($"{s1} comes before {s2}");
            else if (s1.Length > s2.Length)
                Console.WriteLine($"{s2} comes before {s1}");
            else
                Console.WriteLine("Both strings are equal");
        }
    }
}
