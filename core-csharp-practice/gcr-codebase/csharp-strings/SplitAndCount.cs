using System;

namespace BridgeLabzTraining.String.level1
{
    internal class SplitWordsWithLengthDemo
    {
        public static void main()
        {
            // taking input from the user
            string str = Console.ReadLine();

            if (string.IsNullOrEmpty(str)) return;

            // calling the split words to store in 2d array
            string[,] result = SplitWords(str);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static string[,] SplitWords(string str)
        {
            int words = 0;
            bool isWord = false;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] != ' ')
                {
                    if (!isWord)
                    {
                        words++;
                        isWord = true;
                    }
                }
                else
                {
                    isWord = false;
                }
            }

            string[,] res = new string[words, 2];
            int idx = 0;
            string temp = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    temp = temp + str[i];
                }
                if ((str[i] == ' ' || i == str.Length - 1) && temp.Length > 0)
                {
                    res[idx, 0] = temp;
                    res[idx, 1] = Convert.ToString(GetLength(temp));
                    idx++;
                    temp = "";
                }
            }

            return res;
        }

        public static int GetLength(string str)
        {
            int count = 0;
            foreach (char c in str)
                count++;
            return count;
        }
    }
}