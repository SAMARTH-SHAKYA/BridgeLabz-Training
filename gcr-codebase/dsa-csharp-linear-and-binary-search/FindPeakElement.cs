//using System;

//namespace BridgeLabzTraining.dsa_csharp_practice.linear_and_binary_search
//{
//    class FindPeakElement
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

//            int left = 0;
//            int right = nums.Length - 1;

//            while (left < right)
//            {
//                int mid = left + (right - left) / 2;

//                if (nums[mid] < nums[mid + 1])
//                {
//                    left = mid + 1;
//                }
//                else
//                {
//                    right = mid;
//                }
//            }
//            Console.WriteLine($"Peak element idx --> {left}");
//            Console.WriteLine($"Peak element val --> {nums[left]}");
//        }
//    }
//}
