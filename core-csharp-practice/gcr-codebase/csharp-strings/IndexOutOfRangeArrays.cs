using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.level1
{
    internal class IndexOutOfRangeArrays
    {
        public static void main()
        {
            try
            {
                int[] arr = { 1, 2, 3 };
                Console.WriteLine(arr[5]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
}
