using System;
public static class ScreeningUtility
{
    public static void ProcessResume<T>(T candidate) where T : JobRole
    {
        Console.WriteLine("Processing Resume...");
        candidate.Screen();
    }
}
