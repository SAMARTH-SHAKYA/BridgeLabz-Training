using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_sorting
{
    internal class SortEmployeeIdsInsertion
    {
        public void TakeInput()
        {
            // Taking number of employees from the user
            Console.WriteLine("Enter number of employees");
            int n = Convert.ToInt32(Console.ReadLine());

            // Making an employee ID array
            int[] EmployeeIdsArray = new int[n];

            Console.WriteLine("Enter employee IDs one by one");
            for (int i = 0; i < EmployeeIdsArray.Length; i++)
            {
                EmployeeIdsArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] SortedArray = new int[n];

            SortedArray = InsertionSort(EmployeeIdsArray);

            Console.WriteLine("Sorted Employee IDs:");
            for (int i = 0; i < SortedArray.Length; i++)
            {
                Console.WriteLine(SortedArray[i]);
            }
        }

        // Method to sort using Insertion Sort
        public int[] InsertionSort(int[] IdsArray)
        {
            int[] SortedArray = IdsArray;

            for (int i = 1; i < SortedArray.Length; i++)
            {
                int key = SortedArray[i];
                int j = i - 1;

                while (j >= 0 && SortedArray[j] > key)
                {
                    SortedArray[j + 1] = SortedArray[j];
                    j--;
                }

                SortedArray[j + 1] = key;
            }

            return SortedArray;
        }
    }
}
