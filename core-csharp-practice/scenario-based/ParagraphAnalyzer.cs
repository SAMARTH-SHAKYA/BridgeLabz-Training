/*
 * ParagraphAnalyzer is a menu - driven console application that analyzes a user-entered paragraph. 
 * It allows the user to count the total number of words, find the longest word, and replace a specific word with another throughout the paragraph. 
 * The program uses modular, non-static methods, switch-case for menu selection, and loop - based string processing.
 * It continues running until the user chooses to exit, making it suitable for practicing string handling and scenario - based problem solving in C#.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Senario_based
{
    internal class ParagraphAnalyzer
    {

        //The main method which will be called in Main
        public void AnalyzeParagraph()
        {
            Console.WriteLine("-------Welcome to Program Analyzer---------");
            TakeInput();
        }

        //method to take input
        public void TakeInput()
        {
            Console.WriteLine("Enter your paragraph");
            string str = Console.ReadLine();

            Menu(str);


        }

        //method to print menu and call other methods as user needs
        public  void Menu(string str) 
        {
            bool isExit = false;

            while (isExit == false)
            {
                
                Console.WriteLine("Menu : Choose which operation you want to perform");
                Console.WriteLine("Press 1 : Total words in paragraph ");
                Console.WriteLine("Press 2 : Longest word in the paragraph");
                Console.WriteLine("Press 3 : For replacing a word with another in the whole paragraph");
                Console.WriteLine("Press 4 : Exit");

                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu){
                    case 1:
                        Console.WriteLine($"Total Words in paragraph are : {TotalWords(str)}");
                        break;
                    case 2:
                        Console.WriteLine($"Longest word in the paragraph is : {LongestWord(str)}");
                        break;
                    case 3:
                        Console.WriteLine("Enter word you want to replace");
                        string word = Console.ReadLine();
                        Console.WriteLine("Enter word you want to replace with");
                        string wordToReplaceWith = Console.ReadLine();
                        Console.WriteLine($"After replacing your paragraph is : {ReplaceWord(str,word,wordToReplaceWith)}");
                        break;
                    case 4:
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Error occured some invalid input");
                        isExit = true;
                        break;
                }

            }
            
        }

        // method to count total words
        public  int TotalWords(string str)
        {
            int index = 0;
            int count = 0;

            while (index < str.Length)
            {
                if( str[index] != ' ')
                {
                    while (str[index] != ' ')
                    {
                        index++;
                    }
                    count++;
                }

                index++;
            }

            return count;
        }

        //method the find the longest word
        public  string LongestWord(string str)
        {
            int index = 0;
            int max = 0;
            int start = 0;
            int end = 0;
            
            while (index < str.Length)
            {
                if (str[index] != ' ')
                {
                    int startIdx = index;
                    while (str[index] != ' '  && index < str.Length)
                    {
                        index++;
                    }
                    int endIdx = index;
                    if(max < endIdx - startIdx + 1)
                    {
                        start = startIdx;
                        end = endIdx;
                        max = endIdx - startIdx + 1;
                    }

                    
                }
                index++;
            }

            string res = "";
            for(int i = start; i <= end; i++)
            {
                res += str[i];
            }
            return res;
            
        }

        //method to replace the word with the desired word

        public  string ReplaceWord(string str, string word, string wordToReplaceWith)
        {
            string[] words = str.Split(' ');
            string res = "";
            for (int i = 0; i < words.Length; i++) 
            {
                if(words[i] == word)
                {
                    res += wordToReplaceWith + " ";
                    continue;
                }
                res += words[i] +" ";
            }
            return res;
        }
    }
}
