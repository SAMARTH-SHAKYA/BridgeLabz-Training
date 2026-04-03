using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_stack_queue_hashmap
{
    internal class CheckForPair
    {
         public bool HasPairWithSum(int[] arr, int target)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in arr)
            {
                if (set.Contains(target - num))
                {
                    return true;
                }
                    

                set.Add(num);
            }

            return false;
        }

    }

}
