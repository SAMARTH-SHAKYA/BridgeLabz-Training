//using System;

//namespace BridgeLabzTraining.dsa_csharp_practice.linear_and_binary_search
//{
//    class FirstAndLastOccurrence
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

//            Console.Write("Enter target --> ");
//            int target = Convert.ToInt32(Console.ReadLine());

//            int f = -1;
//            int left = 0;
//            int right = nums.Length - 1;

//            while (left <= right)
//            {
//                int mid = left + (right - left) / 2;

//                if (nums[mid] == target)
//                {
//                    f = mid;
//                    right = mid - 1;
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

//            int l = -1;
//            left = 0;
//            right = nums.Length - 1;

//            while (left <= right)
//            {
//                int mid = left + (right - left) / 2;

//                if (nums[mid] == target)
//                {
//                    l = mid;
//                    left = mid + 1;
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

//            if (f == -1)
//            {
//                Console.WriteLine("Element not found");
//                return;
//            }
//            Console.WriteLine($"First occurrence --> {f}");
//            Console.WriteLine($"Last occurrence --> {l}");
//        }
//    }
//}
