using System;
using System.Text.RegularExpressions;

class BadWordCensor
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        string[] badWords = { "damn", "stupid" };

        foreach (var word in badWords)
            text = Regex.Replace(text, $@"\b{word}\b", "****", RegexOptions.IgnoreCase);

        Console.WriteLine(text);
    }
}
