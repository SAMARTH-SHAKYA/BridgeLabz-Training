//using System;

//namespace BridgeLabzTraining.dsa_csharp_practice.linear_and_binary_search
//{
//    class MissingPositiveAndBinarySearch
//    {
//        static void Main()
//        {
//            Console.Write("Enter number of elements --> ");
//            int n = Convert.ToInt32(Console.ReadLine());

//            int[] nums = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write("Enter element --> ");
//                nums[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            bool[] flag = new bool[n + 1];

//            for (int i = 0; i < nums.Length; i++)
//            {
//                if (nums[i] > 0 && nums[i] <= n)
//                {
//                    flag[nums[i]] = true;
//                }
//            }

//            for (int i = 1; i <= n; i++)
//            {
//                if (!flag[i])
//                {
//                    Console.WriteLine($"Missing positive --> {i}");
//                    break;
//                }
//            }

//            Console.Write("Enter target --> ");
//            int target = Convert.ToInt32(Console.ReadLine());

//            Array.Sort(nums);

//            int left = 0;
//            int right = nums.Length - 1;

//            while (left <= right)
//            {
//                int mid = left + (right - left) / 2;

//                if (nums[mid] == target)
//                {
//                    Console.WriteLine($"Target idx --> {mid}");
//                    return;
//                }
//                else if (nums[mid] < target)
//                {
//                    left = mid + 1;
//                }
//                else
//                {
//                    right = mid - 1;
//                }
//            }

//            Console.WriteLine("Target not found --> -1");
//        }
//    }
//}
