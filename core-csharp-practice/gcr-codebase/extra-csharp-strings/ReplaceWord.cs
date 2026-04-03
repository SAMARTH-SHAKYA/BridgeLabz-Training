using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.extra
{
    internal class ReplaceWord
    {
        public static void main()
        {
            //taking input from the user
            string str = Console.ReadLine();
            string wordToRep = Console.ReadLine();
            string newWord = Console.ReadLine();

            string result = "";
            string[] words = str.Split(' ');
            //creplaing the word with the new word
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == wordToRep)
                    result += newWord + " ";
                else
                    result += words[i] + " ";
            }
            //printing the result
            Console.WriteLine(result);
        }
    }
}
