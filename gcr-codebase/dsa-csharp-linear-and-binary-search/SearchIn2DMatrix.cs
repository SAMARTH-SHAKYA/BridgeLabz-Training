//using System;

//namespace BridgeLabzTraining.dsa_csharp_practice.linear_and_binary_search
//{
//    class SearchIn2DMatrix
//    {
//        static void Main()
//        {
//            Console.Write("Enter number of rows --> ");
//            int row = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter number of columns --> ");
//            int col = Convert.ToInt32(Console.ReadLine());

//            int[,] matrix = new int[row, col];

//            for (int i = 0; i < row; i++)
//            {
//                for (int j = 0; j < col; j++)
//                {
//                    Console.Write("Enter element --> ");
//                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//                }
//            }

//            Console.Write("Enter target --> ");
//            int target = Convert.ToInt32(Console.ReadLine());

//            int left = 0;
//            int right = row * col - 1;

//            while (left <= right)
//            {
//                int mid = left + (right - left) / 2;

//                int r = mid / col;
//                int c = mid % col;

//                if (matrix[r, c] == target)
//                {
//                    Console.WriteLine($"Target found {r} x {c}");
//                    return;
//                }
//                else if (matrix[r, c] < target)
//                {
//                    left = mid + 1;
//                }
//                else
//                {
//                    right = mid - 1;
//                }
//            }

//            Console.WriteLine("Target not found");
//        }
//    }
//}
