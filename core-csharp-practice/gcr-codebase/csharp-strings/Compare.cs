using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.level1
{
    internal class Compare
    {
        public static void main()
        {
            //taking input from the user
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Console.WriteLine($"Using charat logic {CompareCharAt(a,b)}");
            Console.WriteLine($"Using string.EqualsTo {a.Equals(b)}");
            
        }
        public static bool CompareCharAt(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
