using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the word");
        string input = Console.ReadLine();

        StringUtility util = new StringUtility();
        string output = util.CleanseAndInvert(input);

        if (string.IsNullOrEmpty(output))
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            Console.WriteLine("The generated key is - " + output);
        }
    }
}
