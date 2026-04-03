using System;
using System.Text.RegularExpressions;

class HexColorValidator
{
    static void Main()
    {
        Console.Write("Enter hex color: ");
        string color = Console.ReadLine();

        Console.WriteLine(Regex.IsMatch(color, @"^#[0-9A-Fa-f]{6}$") ? "Valid" : "Invalid");
    }
}
