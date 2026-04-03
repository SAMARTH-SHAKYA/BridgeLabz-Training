using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_stack_queue_hashmap
{


    class QueueUsingStacks
    {
        private Stack<int> s1 = new Stack<int>(); // For enqueue
        private Stack<int> s2 = new Stack<int>(); // For dequeue

        // Enqueue operation
        public void Enqueue(int x)
        {
            s1.Push(x);
        }

        // Dequeue operation
        public int Dequeue()
        {
            if (s2.Count == 0)
            {
                if (s1.Count == 0)
                {
                    Console.WriteLine("Queue is empty");
                }
                    

                while (s1.Count > 0)
                    s2.Push(s1.Pop());
            }

            return s2.Pop();
        }

        // Peek front element
        public int Peek()
        {
            if (s2.Count == 0)
            {
                if (s1.Count == 0)
                {
                    Console.WriteLine("Queue is empty");
                }
                    

                while (s1.Count > 0)
                    s2.Push(s1.Pop());
            }

            return s2.Peek();
        }

        // Check if empty
        public bool IsEmpty()
        {
            return s1.Count == 0 && s2.Count == 0;
        }
    }

}
