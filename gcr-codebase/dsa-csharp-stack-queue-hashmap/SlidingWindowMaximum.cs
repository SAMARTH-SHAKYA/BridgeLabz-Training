using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_stack_queue_hashmap
{
    internal class SlidingWindowMaximum
    {
        public int[] SlidingWindowMaximumCal(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0)
            {
                return new int[0];
            }
                

            LinkedList<int> deque = new LinkedList<int>();
            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
           
                if (deque.Count > 0 && deque.First.Value <= i - k) 
                {
                    deque.RemoveFirst();
                }
                    

                while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                {
                    deque.RemoveLast();
                }
                    

                deque.AddLast(i);

                if (i >= k - 1)
                {
                    result.Add(nums[deque.First.Value]);
                }
                    
            }

            return result.ToArray();
        }

    }
}
