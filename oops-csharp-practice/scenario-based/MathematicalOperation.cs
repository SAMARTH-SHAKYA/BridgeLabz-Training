using BridgeLabzTraining.arrays.level2;
using BridgeLabzTraining.builtIn.level2;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops
{
    internal class MathematicalOperation
    {
        public void Run()
        {
            Console.WriteLine("-------------------- Welcome to mathematical operations --------------------");
            
            bool isFalse = false;
            while (isFalse == false)
            {
                Console.WriteLine("Press 1 : calculate the factorial of a number");
                Console.WriteLine("Press 2 : check if a number is prime.");
                Console.WriteLine("Press 3 : find the greatest common divisor (GCD) of two numbers.");
                Console.WriteLine("Press 4 : find the nth Fibonacci number.");
                Console.WriteLine("Press 5 : Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        Factorial();
                        break;
                    case 2:
                        PrimeNumber();
                        break;
                    case 3:
                        Gcd();
                        break;
                    case 4:
                        Fibonnaci();                       
                        break;
                    case 5:
                        Console.WriteLine("Exit mathematical operations .....");
                        isFalse = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }
        }

        public void Factorial()
        {
            Console.WriteLine("Enter you number to calculate the factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            if (num <= 0)
            {
                Console.WriteLine("Invalid Input enter number greater than 0");
                return;
            }
            else
            {
                while (num >= 1)
                {
                    fact *= num;
                    num--;
                }
            }
            Console.WriteLine($"The factorial of your number is {fact}");

        }

        public void PrimeNumber()
        {
            Console.WriteLine("Enter you number to check it is prime or not");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num <= 1)
            {
                Console.WriteLine("Invalid Input enter number greater than 1");
                return;
            }
            else
            {
                for(int i = 2; i < num / 2; i++)
                {
                    if(num % i == 0)
                    {
                        Console.WriteLine("The number is not prime");
                        return;
                    }
                }
            }
            Console.WriteLine("Number is prime");
        }

        public void Gcd()
        {
            Console.WriteLine("Enter you first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter you second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if( num1 <= 0 || num2 <= 0)
            {
                Console.WriteLine("You have entered invalid input");
                return;
            }
            int max = Math.Max(num1, num2);
            int min = Math.Min(num1, num2);

            while (min != 0)
            {
                int rem = max % min;
                max = min;
                min = rem;
            }
            Console.WriteLine($"The GCD of both numbers is : {max}");
        }

        public void Fibonnaci()
        {
            Console.WriteLine("Enter the nth term for which you want the Fibonacci number:");
            int num = Convert.ToInt32(Console.ReadLine()); 

            if(num <= 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            int first = 0;
            int second = 1;

            if(num == 1)
            {
                Console.WriteLine("Finbonacci Number is : 0 ");
            }

            for(int i = 2; i <= num; i++)
            {
                int temp = first + second;
                first = second;
                second= temp;
            }

            Console.WriteLine($"Fibonacci Number is : {second}");
        }
    }
}
