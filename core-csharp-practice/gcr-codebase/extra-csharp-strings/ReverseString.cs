using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.extra
{
    internal class ReverseString
    {
        public static void main()
        {
            //taking input from the user
            string str = Console.ReadLine();
            string rev = "";
            //reversing the string and storing it in new var
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
                
            Console.WriteLine(rev);
        }
    }
}
