using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_stack_queue_hashmap
{
    internal class TwoSum
    {
        //method to calcute the two sum
        public int[] CalculateTwoSum(int[] nums, int target)
        {
            //creating the dictnary
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                // checking if the dict contains
                if (map.ContainsKey(diff))
                {
                    return new int[] { map[diff], i };
                }

                if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
                    
            }

            // if there is no solution return negative
            return new int[] { -1, -1 };
        }
    }

    

}
