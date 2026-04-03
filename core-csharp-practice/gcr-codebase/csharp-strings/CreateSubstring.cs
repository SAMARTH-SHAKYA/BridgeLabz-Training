using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.level1
{
    internal class CreateSubstring
    {
        public static void main()
        {
            string str = Console.ReadLine();
            int startIdx = Convert.ToInt32(Console.ReadLine());
            int endIdx = Convert.ToInt32(Console.ReadLine());
            if (endIdx > str.Length || startIdx > str.Length)
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine($"Substring using my method {CreateSubString(str,startIdx,endIdx)}");
            Console.WriteLine($"Substring using substring built in {str.Substring(startIdx,endIdx-startIdx+1)}");
        }

        public static string CreateSubString(string str, int startIdx, int endIdx)
        {
            string res = "";

            for (int i = startIdx; i <= endIdx; i++)
            {
                res += str[i];
            }
            return res;
        }
    }

}
