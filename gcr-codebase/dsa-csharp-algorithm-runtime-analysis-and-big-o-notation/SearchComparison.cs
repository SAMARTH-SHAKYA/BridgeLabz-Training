using System;
using System.Diagnostics;

class SearchComparison
{
    static void Main()
    {
        int num = 1000000;
        int target = 999999;

        int[] data = new int[num];
        for (int i = 0; i < num; i++)
            data[i] = i;

        Stopwatch stopWatch = new Stopwatch();

        // Linear Search
        stopWatch.Start();
        int linearResult = LinearSearch(data, target);
        stopWatch.Stop();
        Console.WriteLine($"Linear Search Index: {linearResult}");
        Console.WriteLine($"Linear Search Time: {stopWatch.ElapsedMilliseconds} ms");

        stopWatch.Reset();

        // Binary Search
        stopWatch.Start();
        int binaryResult = BinarySearch(data, target);
        stopWatch.Stop();
        Console.WriteLine($"Binary Search Index: {binaryResult}");
        Console.WriteLine($"Binary Search Time: {stopWatch.ElapsedMilliseconds} ms");
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == target)
                return i;
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}
