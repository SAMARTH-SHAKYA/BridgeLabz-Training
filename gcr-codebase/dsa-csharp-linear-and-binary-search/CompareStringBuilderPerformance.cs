//using System;
//using System.Text;
//using System.Diagnostics;

//namespace BridgeLabzTraining.dsa_csharp_practice.linear_and_binary_search
//{
//    class CompareStringBuilderPerformance
//    {
//        static void Main()
//        {
//            int iters = 100000;

//            Stopwatch swA = new Stopwatch();
//            swA.Start();

//            string str = "";
//            for (int i = 0; i < iters; i++)
//            {
//                str += "x";
//            }

//            swA.Stop();
//            Console.WriteLine("String Time --> " + swA.ElapsedMilliseconds + " ms");

//            Stopwatch swB = new Stopwatch();
//            swB.Start();

//            StringBuilder sb = new StringBuilder();
//            for (int i = 0; i < iters; i++)
//            {
//                sb.Append("x");
//            }

//            swB.Stop();
//            Console.WriteLine("StringBuilder Time --> " + swB.ElapsedMilliseconds + " ms");
//        }
//    }
//}
