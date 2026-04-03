using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.level1
{
    internal class LowerCase
    {
        public static void main()
        {
            //taing input fron the user
            string str = Console.ReadLine();
            //calling the method
            Console.WriteLine(ConvertToLower(str));
            //calling built in nethod
            Console.WriteLine(str.ToLower());
        }

        public static string ConvertToLower(string str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    res += Convert.ToChar(str[i] + 32);
                }
                else
                {
                    res += str[i];
                }
            }

            return res; 
        }
    }
}
