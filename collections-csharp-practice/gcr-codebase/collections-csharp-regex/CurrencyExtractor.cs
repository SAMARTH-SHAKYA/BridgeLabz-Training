using System;
using System.Text.RegularExpressions;

class CurrencyExtractor
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();

        var matches = Regex.Matches(text, @"\$?\s?\d+\.\d{2}");
        foreach (Match m in matches)
            Console.WriteLine(m.Value.Trim());
    }
}
