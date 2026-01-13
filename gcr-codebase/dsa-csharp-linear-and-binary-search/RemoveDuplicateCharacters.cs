//using System;
//using System.Text;

//namespace BridgeLabzTraining.dsa_csharp_practice.stringbuilder_problems
//{
//    class RemoveDuplicateCharacters
//    {
//        static void Main()
//        {
//            Console.Write("Enter the string --> ");
//            StringBuilder sb1 = new StringBuilder(Console.ReadLine());
//            StringBuilder sb2 = new StringBuilder();

//            for (int i = 0; i < sb1.Length; i++)
//            {
//                if (!sb2.ToString().Contains(sb1[i]))
//                {
//                    sb2.Append(sb1[i]);
//                }
//            }

//            Console.WriteLine($"Result --> {sb2}");
//        }
//    }
//}
