/* program implements a console-based quiz application in C#. It displays a welcome message,
presents 10 multiple-choice questions to the user, validates input to accept only A, B, C, or D,
stores user answers, and compares them with predefined correct answers. The program calculates
the final score and percentage, displays pass/fail status based on a 50% cutoff, and provides
feedback on each question indicating whether the answer was correct or incorrect.*/


using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Senario_based
{
    //Entry point of the program
    internal class StudentQuizGrader
    {
        public void QuizGrader()
        {
            Console.WriteLine("-------------------Welcome to the quiz-----------------------");
            Console.WriteLine("Press enter for start the quiz");
            Console.ReadLine();
            StartQuiz();
        }

        //method to start quiz
        public void StartQuiz() 
        {
            string[] printQues = StoreQues();
            char[] quesAns = StoreAns();
            char[] userAns = new char[10];

            Console.WriteLine("Answer your question in A B C D");

            //printing the question and taking their answer

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(printQues[i]);
                bool isTrue = true;
                char temp;
                while(isTrue == true)
                {
                    temp =char.ToUpper(Convert.ToChar(Console.ReadLine()));

                    if (temp == 'A' || temp =='B' || temp=='C' || temp == 'D')
                    {
                        isTrue = false;
                        userAns[i] = temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input enter again");
                    }
                }
                

                

            }

            //calling the calculate score
            double score = CalculateScore(userAns, quesAns);
            Console.WriteLine($"Your score is {score/10}/10");
            Console.WriteLine($"Percentage of you quiz {score}%");


            //cheking for the student is passed or not
            if(score >= 50)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed Your percentage is below 50");
            }

        }

        //method where the question are stored
        public string[] StoreQues()
        {
            string[] questions = {      "Which data type is used to store true or false values in C#? A) int B) string C) bool D) char",
                                        "Which keyword is used to create an object in C#? A) class B) new C) this D) static",
                                        "Which loop is guaranteed to execute at least once? A) for B) while C) do-while D) foreach",
                                        "Which symbol is used for single-line comments in C#? A) /* */ B) # C) // D) <!-- -->",
                                        "Which method is the entry point of a C# program? A) Start() B) Main() C) Run() D) Init()",
                                        "Which collection allows duplicate values in C#? A) HashSet B) Dictionary C) List D) SortedSet",
                                        "Which access modifier allows access only within the same class? A) public B) protected C) internal D) private",
                                        "Which operator is used for equality comparison? A) = B) == C) != D) <=",
                                        "Which keyword is used to inherit a class in C#? A) implement B) inherits C) extends D) :",
                                        "Which exception occurs when accessing an array index out of range? A) NullReferenceException B) IndexOutOfRangeException C) DivideByZeroException D) FormatException" };

            return questions;
        }

        //method wehere the ans are stored
        public char[] StoreAns()
        {
            char[] answers = {  'C', // bool
                                'B', // new
                                'C', // do-while
                                'C', // //
                                'B', // Main()
                                'C', // List
                                'D', // private
                                'B', // ==
                                'D', // :
                                'B'  // IndexOutOfRangeException
                             };

            return answers; 
        }

        //method to calcuate the score
        public double CalculateScore(char[] userAns, char[] userQues)
        {
            double score = 0;
            for (int i = 0; i < userAns.Length; i++) 
            {
                if (userAns[i] == userQues[i]) 
                {
                    Console.WriteLine($"Ques {i} correct");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Ques {i} incorrect");
                }
            }
            return (score/10)*100;
        }



    }
}
