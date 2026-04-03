using System;
using System.Diagnostics;

class SortingComparison
{
    static void Main()
    {
        int n = 10000;
        Random random = new Random();

        int[] original = new int[n];
        for (int i = 0; i < n; i++)
            original[i] = random.Next(1, n);

        Stopwatch stopWatch = new Stopwatch();

        int[] bubbleArray = (int[])original.Clone();// Create a separate copy to avoid modifying the original array
        stopWatch.Start();
        BubbleSort(bubbleArray);
        stopWatch.Stop();
        Console.WriteLine($"Bubble Sort Time --> {stopWatch.ElapsedMilliseconds} ms");

        stopWatch.Reset(); // used to reset the stopwatch timer

        int[] mergeArray = (int[])original.Clone(); // Create a separate copy to avoid modifying the original array
        stopWatch.Start();
        MergeSort(mergeArray, 0, mergeArray.Length - 1);
        stopWatch.Stop();
        Console.WriteLine($"Merge Sort Time --> {stopWatch.ElapsedMilliseconds} ms");

        stopWatch.Reset();

        int[] quickArray = (int[])original.Clone(); // Create a separate copy to avoid modifying the original array
        stopWatch.Start();
        QuickSort(quickArray, 0, quickArray.Length - 1);
        stopWatch.Stop();
        Console.WriteLine($"Quick Sort Time --> {stopWatch.ElapsedMilliseconds} ms");
    }

    // Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
    }

    // Merge Sort
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right) return;

        int mid = (left + right) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }
    // Merge Sort Helper Method
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
            temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];

        while (i <= mid) temp[k++] = arr[i++];
        while (j <= right) temp[k++] = arr[j++];

        Array.Copy(temp, 0, arr, left, temp.Length);
    }

    // Quick Sort
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }
}
