using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.extra
{
    internal class LongestWord
    {
        public static void main()
        {
            //taking input from the user
            string str = Console.ReadLine();
            int ans = 0;
            int temp = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] !=' ')
                {
                    temp++;
                }
                else
                {
                    if (temp > ans)
                    {
                        ans = temp;
                    }
                    temp = 0;
                }
            }
            if (temp > ans)
            {
                ans = temp;
            }
                
            Console.WriteLine(ans);
        }
    }
}
