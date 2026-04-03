using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.String.level1
{
    internal class NullRefExcep
    {
        public static void main()
        {
            string str = null;

            try
            {
                Console.WriteLine(str.Length);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.GetType().Name);
            }
        }
    }
}
