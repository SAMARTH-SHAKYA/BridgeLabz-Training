using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_stack_queue_hashmap
{
    internal class LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            HashSet<int> set = new HashSet<int>(nums);
            int longest = 0;

            foreach (int num in nums)
            {
                
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int count = 1;

                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        count++;
                    }

                    longest = Math.Max(longest, count);
                }
            }

            return longest;
        }
    }
}
