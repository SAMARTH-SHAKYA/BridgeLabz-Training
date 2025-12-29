using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


/*This program is a console-based Sentence Formatter that takes a paragraph from the user and allows them to perform different text-formatting operations using a menu-driven approach. 4
 * The user can add spaces after punctuation marks, remove extra spaces from the paragraph, or capitalize letters appropriately after sentence-ending punctuation such as periods, question marks, and exclamation marks. 
 * The program repeatedly displays a menu until the user chooses to exit. 
 * Each operation processes the input string character by character, builds a new formatted string, and displays the result without modifying the original input permanently.
*/
namespace BridgeLabzTraining.Senario_based
{
    internal class SentenceFormator
    {

        public void FormatSentence()
        {
            Console.WriteLine("------Welcome to the Sentence Formattor------");
            TakeInput();

        }

        // Method to take the input 
        public void TakeInput()
        {
            // Taking input from the user 
            Console.WriteLine("Enter your paragraph");
            string strFromUser = Console.ReadLine();

            Menu(strFromUser);
        }

        //Method for Taking operation from the user and printing menu
        public  void Menu(string strFromUser)
        {
            bool isExit = false;
            while (isExit == false)
            {

                Console.WriteLine("Choose the operation you want to perform");
                Console.WriteLine("Press 1 : Add spacing after punctuation");
                Console.WriteLine("Press 2 : Trimming extra spaces");
                Console.WriteLine("Press 3 : Capital letter after period/question/exclamation marks");
                Console.WriteLine("Press 4 : Do all operations");
                Console.WriteLine("Press 5 : For new input");
                Console.WriteLine("Press 6 : Exit");

                int menu = Convert.ToInt32(Console.ReadLine());
                if (menu < 1 && menu > 4)
                {
                    Console.WriteLine("Invaild menu input");
                    Menu(strFromUser);
                }

                else
                {
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Adding spacing after punctuation");
                            Console.WriteLine(AddSpacesAfterPunctuation(strFromUser));
                            break;
                        case 2:
                            Console.WriteLine("Trimming extra spaces");
                            Console.WriteLine(RemoveExtraSpaces(strFromUser));
                            break;
                        case 3:
                            Console.WriteLine("Capital letter after period/question/exclamation marks");
                            Console.WriteLine(CapitalParagraph(strFromUser));
                            break;
                        case 4:
                            Console.WriteLine("Do All");
                            Console.WriteLine(CapitalParagraph(RemoveExtraSpaces(AddSpacesAfterPunctuation(strFromUser))));
                            break;
                        case 5:
                            TakeInput();
                            break;
                        case 6:
                            Console.WriteLine("Exit");
                            return;
                            break;
                        default:
                            Console.WriteLine("Invalid Action");
                            break;
                    }
                }
            }

        }

        // method for removing extra spaces
        public string RemoveExtraSpaces(string strFromUser)
        {
            string res = "";

            int startIdx = 0;
            if (strFromUser[startIdx] == ' ')
            {
                while (strFromUser[startIdx] == ' ')
                {
                    startIdx++;
                }
            }

            int endIdx = strFromUser.Length - 1;
            if (strFromUser[endIdx] == ' ')
            {
                while (strFromUser[endIdx] == ' ')
                {
                    endIdx--;
                }
            }
            for (int i = startIdx; i <= endIdx; i++)
            {
                if (i != endIdx && strFromUser[i] != ' ' && strFromUser[i + 1] == ' ')
                {
                    res += strFromUser[i];
                    res += ' ';
                }
                else if (strFromUser[i] != ' ')
                {
                    res += strFromUser[i];
                }
                else
                {
                    continue;
                }

            }

            return res;

        }

        //method for making valid letter to capital
        public  string CapitalParagraph(string strFromUser)
        {
            string res = "";
            if (char.IsLower(strFromUser[0])){
                res += char.ToUpper(strFromUser[0]);
            }
            else
            {
                res += strFromUser[0];
            }
                int index = 1;
            while(index < strFromUser.Length)
            {
                if(strFromUser[index] == '.' ||  strFromUser[index] == '?' ||  strFromUser[index] == '!' || strFromUser[index] == ',')
                {
                    res += strFromUser[index];
                    index++;
                    while(index < strFromUser.Length && strFromUser[index] == ' ')
                    {
                        res += strFromUser[index];
                        index++;
                    }
                    if (index < strFromUser.Length && char.IsLower(strFromUser[index]))
                    {

                        res += char.ToUpper(strFromUser[index]);
                        index++;
                    }
                }
                else
                {
                    res += strFromUser[index];
                    index++;
                }
            }
            return res;
        }

        //method for adding spaces after punctuation
        public  string AddSpacesAfterPunctuation(string strFromUser)
        {
            string res = "";

            int index = 0;

            while (index < strFromUser.Length) 
            { 
                if((strFromUser[index] == '.' || strFromUser[index] == '?' || strFromUser[index] == '!' || strFromUser[index] == ',') && index < strFromUser.Length - 1 && strFromUser[index+1]!=' ')
                {
                    res += strFromUser[index];
                    res += " ";
                    index++;
                }
                res += strFromUser[index];
                index++;

            }

            return res;
        }

    } 
}
