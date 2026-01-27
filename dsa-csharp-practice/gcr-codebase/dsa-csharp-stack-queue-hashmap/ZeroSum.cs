using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_stack_queue_hashmap
{
    internal class ZeroSum
    {
        public void FindZeroSumSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int sum = 0;

            map[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (map.ContainsKey(sum))
                {
                    foreach (int startIndex in map[sum])
                    {
                        Console.WriteLine($"Subarray found from {startIndex + 1} to {i}");
                    }
                    map[sum].Add(i);
                }
                else
                {
                    map[sum] = new List<int> { i };
                }
            }
        }

    }
}
