//using System;

//namespace BridgeLabzTraining.dsa_csharp_practice.linear_and_binary_search
//{
//    class FirstNegativeNumber
//    {
//        static void Main()
//        {
//            Console.Write("Enter number of elements --> ");
//            int n = Convert.ToInt32(Console.ReadLine());

//            int[] nums = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"Enter a element --> ");
//                nums[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            for (int i = 0; i < nums.Length; i++)
//            {
//                if (nums[i] < 0)
//                {
//                    Console.WriteLine($"First Negative Number --> {nums[i]}");
//                    return;
//                }
//            }
//            Console.WriteLine("No negative number found");
//        }
//    }
//}
