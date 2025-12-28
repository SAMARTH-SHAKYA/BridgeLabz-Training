using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.extra
{
    internal class RemoveDup
    {
        public static void main()
        {
            //taking input from the user
            string str = Console.ReadLine();
            string res = "";

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                bool temp = false;
                for (int j = 0; j < res.Length; j++)
                {
                    if (res[j] == c)
                    {
                        temp = true;
                        break;
                    }
                }
                if (!temp)
                {
                    res += c;
                }
            }
            Console.WriteLine(res);
        }
    }
}
