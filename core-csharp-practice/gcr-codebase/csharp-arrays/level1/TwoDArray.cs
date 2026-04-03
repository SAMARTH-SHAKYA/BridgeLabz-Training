using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class TwoDArray
    {
        public void TwoDArrayCopy() {
            //taking row and col size from the user
            int rows = Convert.ToInt32(Console.ReadLine());
            int cols = Convert.ToInt32(Console.ReadLine());

            //decalring a 2D array
            int[,] arr = new int[rows,cols];


            // taking input from the user for 2D array
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[] temp = new int[rows * cols];
            int counter = 0;

            //copying the 2D array into 1D array
            for(int k = 0; k < rows; k++)
            {
                for(int l = 0; l < cols; l++)
                {
                    temp[counter] = arr[k,l]; 
                    counter++;
                }
            }

            //printing the 1D array
            for(int m = 0; m < rows * cols; m++)
            {
                Console.WriteLine(temp[m]);
            }


        }
    }
}
