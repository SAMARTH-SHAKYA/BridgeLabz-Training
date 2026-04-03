using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.level1
{
    internal class IndexOutOfRange
    {
        public static void main()
        {
            try
            {
                string str = "Hello";
                Console.WriteLine(str[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
}
