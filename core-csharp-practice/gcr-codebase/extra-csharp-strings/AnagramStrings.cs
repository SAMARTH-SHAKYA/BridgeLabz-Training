using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.extra
{
    internal class AnagramStrings
    {
        public static void main()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Strings are not anagrams");
                return;
            }
            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("Strings are not anagrams");
                    return;
                }
            }

            Console.WriteLine("Strings are anagrams");
        }
    }
}
