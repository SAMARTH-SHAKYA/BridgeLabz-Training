using System;
using System.Text.RegularExpressions;

class LicensePlateValidator
{
    static void Main()
    {
        Console.Write("Enter license plate: ");
        string plate = Console.ReadLine();

        Console.WriteLine(Regex.IsMatch(plate, @"^[A-Z]{2}\d{4}$") ? "Valid" : "Invalid");
    }
}
