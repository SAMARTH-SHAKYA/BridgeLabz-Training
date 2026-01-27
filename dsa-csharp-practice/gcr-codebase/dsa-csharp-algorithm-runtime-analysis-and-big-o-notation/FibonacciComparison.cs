using System;
using System.Diagnostics;

class FibonacciComparison
{
    static void Main()
    {
        int n = 30;

        Stopwatch stopWatch = new Stopwatch();

        // Recursive Fibonacci
        stopWatch.Start();
        int recursiveResult = FibonacciRecursive(n);
        stopWatch.Stop();
        Console.WriteLine($"Recursive Fibonacci({n}) --> {recursiveResult}");
        Console.WriteLine($"Recursive Time --> {stopWatch.ElapsedMilliseconds} ms");

        stopWatch.Reset();

        // Iterative Fibonacci
        stopWatch.Start();
        int iterativeResult = FibonacciIterative(n);
        stopWatch.Stop();
        Console.WriteLine($"Iterative Fibonacci({n}) --> {iterativeResult}");
        Console.WriteLine($"Iterative Time --> {stopWatch.ElapsedMilliseconds} ms");
    }

    static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static int FibonacciIterative(int n)
    {
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
