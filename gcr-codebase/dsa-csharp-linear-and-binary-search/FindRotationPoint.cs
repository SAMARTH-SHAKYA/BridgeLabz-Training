//using System;

//namespace BridgeLabzTraining.dsa_csharp_practice.linear_and_binary_search
//{
//    class FindRotationPoint
//    {
//        static void Main()
//        {
//            Console.Write("Enter number of elements --> ");
//            int n = int.Parse(Console.ReadLine());

//            int[] nums = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write("Enter element --> ");
//                nums[i] = int.Parse(Console.ReadLine());
//            }

//            int left = 0;
//            int right = nums.Length - 1;

//            while (left < right)
//            {
//                int mid = left + (right - left) / 2;

//                if (nums[mid] > nums[right])
//                {
//                    left = mid + 1;
//                }
//                else
//                {
//                    right = mid;
//                }
//            }

//            Console.WriteLine($"Rotation point idx --> {left}");
//        }
//    }
//}
