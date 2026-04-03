using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.builtIn.level2
{
    internal class NumberGuess
    {
        static Random random = new Random();
        public static void main()
        {
            Console.WriteLine("Think of a number between 1 and 100 and type high low or correct");
            int start = 1;
            int end = 100;
            bool isGuessed = false;

            while (!isGuessed)
            {
                int currentGuess = GenerateGuess(start, end);
                Console.WriteLine("Computer guessed: " + currentGuess);

                string userResponse = TakeFeedback();

                int[] range = UpdateRange(userResponse, currentGuess, start, end);
                start = range[0];
                end = range[1];

                if (userResponse == "correct")
                {
                    isGuessed = true;
                }
            }

            Console.WriteLine("Game over. Number guessed!");
        }

        public static int GenerateGuess(int min, int max)
        {
            return random.Next(min, max + 1);
        }

        public static string TakeFeedback()
        {
            Console.WriteLine("Enter feedback:");
            return Console.ReadLine().ToLower();
        }

        public static int[] UpdateRange(string feedback, int guess, int min, int max)
        {
            if (feedback == "high")
            {
                max = guess - 1;
            }
            else if (feedback == "low")
            {
                min = guess + 1;
            }

            return new int[] { min, max };
        }
    }
}
