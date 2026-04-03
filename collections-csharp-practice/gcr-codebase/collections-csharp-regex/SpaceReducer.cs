using System;
using System.Text.RegularExpressions;

class SpaceReducer
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();

        string result = Regex.Replace(text, @"\s+", " ");
        Console.WriteLine("Result: " + result);
    }
}
