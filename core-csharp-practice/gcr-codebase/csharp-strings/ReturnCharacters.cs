using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.level1
{
    internal class ReturnAllCharacters
    {
        public static void main()
        {
            //taking input from the user
            string str = Console.ReadLine();

            //calling method
            char[] res = GetChar(str);
            char[] builtRes = str.ToCharArray();
            Console.WriteLine("Using my method:");
            foreach (char c in res)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Using ToCharArray:");
            foreach (char c in builtRes)
            {
                Console.Write(c + " ");
            }
        }
        //method to convert into string array
        public static char[] GetChar(string str)
        {
            char[] res = new char[str.Length];

            for (int i = 0; i < str.Length;i++)
            {
                res[i] = str[i];
            }
            return res;
        }
    }
}
