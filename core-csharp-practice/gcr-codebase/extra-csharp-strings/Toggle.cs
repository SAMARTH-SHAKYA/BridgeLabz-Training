using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.extra
{
    internal class Toggle
    {
        public static void main()
        {
            string str = Console.ReadLine();
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c >= 'a' && c <= 'z')
                    result += Convert.ToChar(c - 32);
                else if (c >= 'A' && c <= 'Z')
                    result += Convert.ToChar(c + 32);
                else
                    result += c;
            }
            Console.WriteLine(result);
        }
    }
}
