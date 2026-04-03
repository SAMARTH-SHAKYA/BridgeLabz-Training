using System;
using System.Diagnostics;

public class PasswordCracker : IPasswordCracker
{
    private const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private bool found = false;
    private long attempts = 0;

    // Scenario A — Generate all strings of length n
    public void GenerateAll(int length)
    {
        Console.WriteLine("\nGenerating all combinations...\n");
        attempts = 0;
        GenerateRecursive("", length);
        Console.WriteLine($"\nTotal combinations generated: {attempts}");
    }

    private void GenerateRecursive(string current, int maxLen)
    {
        if (current.Length == maxLen)
        {
            Console.WriteLine(current);
            attempts++;
            return;
        }

        foreach (char c in chars)
        {
            GenerateRecursive(current + c, maxLen);
        }
    }

    // Scenario B — Stop when password matches
    public bool CrackPassword(string target)
    {
        Console.WriteLine("\nCracking password...\n");
        found = false;
        attempts = 0;

        Stopwatch sw = Stopwatch.StartNew();
        CrackRecursive("", target);
        sw.Stop();

        if (found)
        {
            Console.WriteLine($"\nPassword found: {target}");
            Console.WriteLine($"Attempts: {attempts}");
            Console.WriteLine($"Time taken: {sw.ElapsedMilliseconds} ms");
        }
        else
        {
            Console.WriteLine("Password not found.");
        }

        return found;
    }

    private void CrackRecursive(string current, string target)
    {
        if (found) return;

        if (current.Length == target.Length)
        {
            attempts++;
            if (current == target)
                found = true;

            return;
        }

        foreach (char c in chars)
        {
            CrackRecursive(current + c, target);
        }
    }
}
