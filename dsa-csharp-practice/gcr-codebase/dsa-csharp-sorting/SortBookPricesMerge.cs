using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_sorting
{
    internal class SortBookPricesMerge
    {
        public void TakeInput()
        {
            // Taking number of books from the user
            Console.WriteLine("Enter number of books");
            int n = Convert.ToInt32(Console.ReadLine());

            // Making a book prices array
            int[] BookPricesArray = new int[n];

            Console.WriteLine("Enter book prices one by one");
            for (int i = 0; i < BookPricesArray.Length; i++)
            {
                BookPricesArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calling Merge Sort
            MergeSort(BookPricesArray, 0, BookPricesArray.Length - 1);

      
            for (int i = 0; i < BookPricesArray.Length; i++)
            {
                Console.WriteLine(BookPricesArray[i]);
            }
        }

        // Method to perform Merge Sort
        public void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        // Method to merge two halves
        public void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
                L[i] = arr[left + i];

            for (int j = 0; j < n2; j++)
                R[j] = arr[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (L[iIndex] <= R[jIndex])
                {
                    arr[k] = L[iIndex];
                    iIndex++;
                }
                else
                {
                    arr[k] = R[jIndex];
                    jIndex++;
                }
                k++;
            }

            while (iIndex < n1)
            {
                arr[k] = L[iIndex];
                iIndex++;
                k++;
            }

            while (jIndex < n2)
            {
                arr[k] = R[jIndex];
                jIndex++;
                k++;
            }
        }
    }
}
