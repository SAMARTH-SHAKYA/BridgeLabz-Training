using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class AgeHeight
    {
        public void HeightAgeFind()
        {
            int[] height = new int[3];
            int[] age = new int[3];

            //taking input from the user
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter age:");
                age[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter height");
                height[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            //finding the youngest age
            int youngAge = age[0];
            for(int j = 1; j < 3; j++)
            {
                if (age[j] < youngAge)
                {
                    youngAge = age[j];
                }
            }
            Console.WriteLine($"Youngest age: {youngAge}");

            //finding the tallest age
            int tallHeight = height[0];
            for(int k = 0; k < 3; k++)
            {
                if (height[k] > tallHeight)
                {
                    tallHeight = height[k];
                }
            }
            Console.WriteLine($"Tallest height : {tallHeight}");

        }
    }
}
