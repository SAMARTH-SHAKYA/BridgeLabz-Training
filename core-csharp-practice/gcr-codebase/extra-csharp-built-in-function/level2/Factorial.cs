using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.builtIn.level2
{
    internal class Factorial
    {
        public static void main()
        {
            //taking input from the user
            int num = Convert.ToInt32 (Console.ReadLine());
            int ans = fact(num);
            Console.WriteLine(ans);

        }

        public static int fact(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            return num * fact(num - 1);
        }
    }
}
