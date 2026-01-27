using System;
using System.Text.RegularExpressions;

class LinkExtractor
{
    static void Main()
    {
        Console.WriteLine("Enter text with links:");
        string text = Console.ReadLine();

        var matches = Regex.Matches(text, @"https?://[^\s]+");
        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
