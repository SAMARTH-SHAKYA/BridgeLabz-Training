using System;

public class Program
{
    public static void Main(string[] args)
    {
        LexicalProcessor processor = new LexicalProcessor();

        Console.WriteLine("Enter the first word");
        string firstWord = Console.ReadLine();

        if (processor.IsInvalidWord(firstWord))
        {
            Console.WriteLine(firstWord + " is an invalid word");
            return;
        }

        Console.WriteLine("Enter the second word");
        string secondWord = Console.ReadLine();

        if (processor.IsInvalidWord(secondWord))
        {
            Console.WriteLine(secondWord + " is an invalid word");
            return;
        }

        if (processor.IsReverse(firstWord, secondWord))
        {
            string result = processor.ProcessReverseCase(firstWord);
            Console.WriteLine(result);
        }
        else
        {
            string result = processor.ProcessNonReverseCase(firstWord, secondWord);
            Console.WriteLine(result);
        }
    }
}
