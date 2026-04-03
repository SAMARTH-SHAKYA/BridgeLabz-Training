using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.level1
{
    internal class FormatExcep
    {
        public static void main()
        {
            try
            {
                int num = int.Parse("abc");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
    
}
