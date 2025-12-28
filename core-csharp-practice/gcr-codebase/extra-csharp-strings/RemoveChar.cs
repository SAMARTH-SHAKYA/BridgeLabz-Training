using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.extra
{
    internal class RemoveChar
    {
        public static void main()
        {
            // Taking input from the user
            string str = Console.ReadLine();
            char ch = Console.ReadLine()[0];

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ch)
                {
                    result += str[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
