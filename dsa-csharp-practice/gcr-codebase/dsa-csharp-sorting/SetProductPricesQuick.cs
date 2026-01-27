using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_sorting
{
    internal class SetProductPricesQuick
    {
        public void TakeInput()
        {
            // Taking number of products from the user
            Console.WriteLine("Enter number of products");
            int n = Convert.ToInt32(Console.ReadLine());

            // Making product prices array
            int[] ProductPricesArray = new int[n];

            Console.WriteLine("Enter product prices one by one");
            for (int i = 0; i < ProductPricesArray.Length; i++)
            {
                ProductPricesArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calling Quick Sort
            QuickSort(ProductPricesArray, 0, ProductPricesArray.Length - 1);

            Console.WriteLine("Sorted Product Prices:");
            for (int i = 0; i < ProductPricesArray.Length; i++)
            {
                Console.WriteLine(ProductPricesArray[i]);
            }
        }

        // Method to perform Quick Sort
        public void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        // Method to partition the array
        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[low]; // Choosing first element as pivot
            int i = low;
            int j = high;

            while (i < j)
            {
                while (arr[i] <= pivot && i <= high - 1)
                {
                    i++;
                }

                while (arr[j] > pivot && j >= low + 1)
                {
                    j--;
                }

                if (i < j)
                {
                    Swap(arr, i, j);
                }
            }

            Swap(arr, low, j);
            return j;
        }

        // Method to swap two elements
        public void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

