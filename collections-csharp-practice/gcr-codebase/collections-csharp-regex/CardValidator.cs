using System;
using System.Text.RegularExpressions;

class CardValidator
{
    static void Main()
    {
        Console.Write("Enter card number: ");
        string card = Console.ReadLine();

        Console.WriteLine(Regex.IsMatch(card, @"^(4\d{15}|5\d{15})$") ? "Valid" : "Invalid");
    }
}
