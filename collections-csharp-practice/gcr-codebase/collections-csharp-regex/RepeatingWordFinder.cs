using System;
using System.Text.RegularExpressions;

class RepeatingWordFinder
{
    static void Main()
    {
        Console.WriteLine("Enter sentence:");
        string text = Console.ReadLine();

        var matches = Regex.Matches(text, @"\b(\w+)\s+\1\b", RegexOptions.IgnoreCase);
        foreach (Match m in matches)
            Console.WriteLine(m.Groups[1].Value);
    }
}
