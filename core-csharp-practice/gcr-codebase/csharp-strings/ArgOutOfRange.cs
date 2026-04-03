using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.level1
{
    internal class ArgOutOfRange
    {
        public static void main()
        {
            try
            {
                string str = "Hello";
                Console.WriteLine(str.Substring(5, 3));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
}
