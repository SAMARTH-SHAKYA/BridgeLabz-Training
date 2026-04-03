using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.extra
{
    internal class MostFreqChar
    {

        public static void Main()
        {
            //taking input from the user
            string str = Console.ReadLine();
            int max = 0;
            char res = str[0];

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == c)
                        count++;
                }
                if (count > max)
                {
                    max = count;
                    res = c;
                }
            }
            Console.WriteLine(res);
        }
        


    }
}
