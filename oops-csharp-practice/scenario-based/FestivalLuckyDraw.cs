using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace BridgeLabzTraining.Scenario_oops
{
    internal class FestivalLuckyDraw
    {
        //method which will be callled by main method
        public void Run()
        {
            Console.WriteLine("-------------------- Diwali Lucky Draw --------------------");

            bool isExit = false;

            while (isExit == false)
            {
                //taking input from the user
                Console.WriteLine("Enter your lucky number:");
                int number = Convert.ToInt32(Console.ReadLine());


                //checking num is less than equal to 0
                if (number <= 0)
                {
                    Console.WriteLine("Invalid number");
                    continue;
                }

                //cheking the modulo condition
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Congratulations! You won a gift 🎁");
                }
                else
                {
                    Console.WriteLine("Sorry, better luck next time");
                }

                Console.WriteLine("Is there another visitor? (yes/no)");
                string choice = Console.ReadLine().ToLower();

                if (choice == "no")
                {
                    isExit = true;
                    Console.WriteLine("Lucky draw ended");
                }
            }
        }
    }
}

