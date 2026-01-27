using System;
using System.Text.RegularExpressions;

class LanguageExtractor
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();

        var matches = Regex.Matches(text, @"\b(Java|Python|JavaScript|Go)\b");
        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
