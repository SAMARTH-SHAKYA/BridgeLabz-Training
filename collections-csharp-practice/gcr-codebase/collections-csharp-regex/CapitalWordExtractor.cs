using System;
using System.Text.RegularExpressions;

class CapitalWordExtractor
{
    static void Main()
    {
        Console.WriteLine("Enter sentence:");
        string text = Console.ReadLine();

        var matches = Regex.Matches(text, @"\b[A-Z][a-z]*\b");
        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
