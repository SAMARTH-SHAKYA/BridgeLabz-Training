using System;
using System.Text.RegularExpressions;

class SSNValidator
{
    static void Main()
    {
        Console.Write("Enter SSN: ");
        string ssn = Console.ReadLine();

        Console.WriteLine(Regex.IsMatch(ssn, @"^\d{3}-\d{2}-\d{4}$") ? "Valid" : "Invalid");
    }
}
