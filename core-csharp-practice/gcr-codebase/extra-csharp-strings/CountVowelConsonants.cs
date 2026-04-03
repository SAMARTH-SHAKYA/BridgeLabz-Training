using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.extra
{
    internal class CountVowelConsonants
    {
        public static void main()
        {
            //taking input from the user
            string str = Console.ReadLine();
            str.ToLower();
            int vol = 0;
            int con = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vol++;
                }
                else
                {
                    con++;
                }
            }
            Console.WriteLine($"Vowels : {vol} and Consonants : {con}");

        }
    }
}
