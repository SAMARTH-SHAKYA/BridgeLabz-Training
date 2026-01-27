using System;
using System.Text.RegularExpressions;

class DateExtractor
{
    static void Main()
    {
        Console.WriteLine("Enter text with dates:");
        string text = Console.ReadLine();

        var matches = Regex.Matches(text, @"\b\d{2}/\d{2}/\d{4}\b");
        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
