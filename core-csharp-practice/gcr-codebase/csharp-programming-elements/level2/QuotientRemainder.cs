using System;
using System.ComponentModel;
class QuotientRemainder
{
    public static void Main(string[] args)
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        double quotient = num1 / num2;
        double remainder = num1 % num2;

        Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {num1} and {num2}");
    }
}