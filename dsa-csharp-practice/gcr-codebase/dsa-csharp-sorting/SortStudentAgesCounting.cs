using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_sorting
{
    internal class SortStudentAgesCounting
    {
        public void TakeInput()
        {
            // Taking number of students from the user
            Console.WriteLine("Enter number of students");
            int n = Convert.ToInt32(Console.ReadLine());

            // Making student ages array
            int[] StudentAgesArray = new int[n];

            Console.WriteLine("Enter student ages one by one (10 to 18)");
            for (int i = 0; i < StudentAgesArray.Length; i++)
            {
                StudentAgesArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] SortedArray = CountingSort(StudentAgesArray);

            Console.WriteLine("Sorted Student Ages:");
            for (int i = 0; i < SortedArray.Length; i++)
            {
                Console.WriteLine(SortedArray[i]);
            }
        }

        // Method to perform Counting Sort
        public int[] CountingSort(int[] arr)
        {
            int minAge = 10;
            int maxAge = 18;

            int range = maxAge - minAge + 1;
            int[] count = new int[range];
            int[] output = new int[arr.Length];

            // Step 1: Store frequency of each age
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - minAge]++;
            }

            // Step 2: Cumulative frequency
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            // Step 3: Place elements in correct position
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i] - minAge] - 1] = arr[i];
                count[arr[i] - minAge]--;
            }

            return output;
        }
    }
}

