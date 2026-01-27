using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_sorting
{
    internal class SortExamsScoresSelection
    {
        public  void TakeInput()
        {
            //taking number of students from the user
            Console.WriteLine("Enter number of students");
            int n = Convert.ToInt32(Console.ReadLine());


            //making an student array
            int[] StudentMarksArray = new int[n];

            Console.WriteLine("Enter makrs of student one by one");
            for (int i = 0; i < StudentMarksArray.Length; i++)
            {
                StudentMarksArray[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            int[] SortedArray = new int[n];
            
            SortedArray = SelectionSort(StudentMarksArray);

            for (int i = 0; i < SortedArray.Length; i++)
            { 
                Console.WriteLine(SortedArray[i]);
            }

        }

        //method to sort using selection sort
        public int[] SelectionSort(int[] MarksArray)
        {
            int[] SortedArray = MarksArray;

            for(int i = 0; i < SortedArray.Length-1; i++)
            {
                int minIndex = i;
                for(int j = i+1; j < MarksArray.Length; j++)
                {
                    if(SortedArray[j] < SortedArray[minIndex])
                    {
                        minIndex = j;
                    }
                }
                //swapping elements
                int temp = SortedArray[i];
                SortedArray[i] = SortedArray[minIndex];
                SortedArray[minIndex] = temp;

            }
            return SortedArray;
        }
    }
}
