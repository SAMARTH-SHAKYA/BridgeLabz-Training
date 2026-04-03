using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.level2
{
    internal class AgeHeight
    {
        public static void YoungestAge(int[] age)
        {
            //finding the youngest age
            int youngAge = age[0];
            for (int j = 1; j < 3; j++)
            {
                if (age[j] < youngAge)
                {
                    youngAge = age[j];
                }
            }
            Console.WriteLine($"Youngest age: {youngAge}");
        }

        public static void TallestHeight(int[] height)
        {
            //finding the tallest age
            int tallHeight = height[0];
            for (int k = 0; k < 3; k++)
            {
                if (height[k] > tallHeight)
                {
                    tallHeight = height[k];
                }
            }
            Console.WriteLine($"Tallest height : {tallHeight}");
        }
        public static void main()
        {
            int[] height = new int[3];
            int[] age = new int[3];

            //taking input from the user
            Console.WriteLine("Enter age:");
            for (int i = 0; i < 3; i++)
            {
                age[i] = Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine("Enter height");
            for (int i = 0; i < 3; i++)
            {
                height[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            YoungestAge(age);
            TallestHeight(height);

            

        }
    }
}
