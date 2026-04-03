using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.level1
{
    internal class UpperCase
    {
        public static void main()
        {
            //taking inout from the user
            string str = Console.ReadLine();
            //calling the method
            Console.WriteLine(ConvertToUpper(str));
            //calling the built in merthod
            Console.WriteLine(str.ToUpper());
        }

        public static string ConvertToUpper(string str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    res += Convert.ToChar(str[i] - 32);
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
