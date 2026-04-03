using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_sorting
{
    internal class SortStudentScoresBubble
    {
        public void TakeInput()
        {
            // taking number of students from the user
            Console.WriteLine("Enter number of students");
            int n = Convert.ToInt32(Console.ReadLine());

            // making a student array
            int[] StudentMarksArray = new int[n];

            Console.WriteLine("Enter marks of students one by one");
            for (int i = 0; i < StudentMarksArray.Length; i++)
            {
                StudentMarksArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] SortedArray = new int[n];

            SortedArray = BubbleSort(StudentMarksArray);

            Console.WriteLine("Sorted Marks:");
            for (int i = 0; i < SortedArray.Length; i++)
            {
                Console.WriteLine(SortedArray[i]);
            }
        }

        // Method to sort using Bubble Sort
        public int[] BubbleSort(int[] MarksArray)
        {
            int[] SortedArray = MarksArray;

            for (int i = 0; i < SortedArray.Length - 1; i++)
            {
                for (int j = 0; j < SortedArray.Length - i - 1; j++)
                {
                    if (SortedArray[j] > SortedArray[j + 1])
                    {
                        // swapping
                        int temp = SortedArray[j];
                        SortedArray[j] = SortedArray[j + 1];
                        SortedArray[j + 1] = temp;
                    }
                }
            }

            return SortedArray;
        }
    }
}
