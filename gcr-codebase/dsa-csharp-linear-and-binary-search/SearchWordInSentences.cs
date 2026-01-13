//using System;

//namespace BridgeLabzTraining.dsa_csharp_practice.linear_and_binary_search
//{
//    class SearchWordInSentences
//    {
//        static void Main()
//        {
//            Console.Write("Enter number of sentences --> ");
//            int n = Convert.ToInt32(Console.ReadLine());

//            string[] sentences = new string[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.Write("Enter a sentence --> ");
//                sentences[i] = Console.ReadLine();
//            }

//            Console.Write("Enter the word to search --> ");
//            string word = Console.ReadLine();

//            for (int i = 0; i < sentences.Length; i++)
//            {
//                if (sentences[i].Contains(word))
//                {
//                    Console.WriteLine(sentences[i]);
//                    return;
//                }
//            }
//            Console.WriteLine("Word not found");
//        }
//    }
//}
