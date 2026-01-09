using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_stack_queue_hashmap
{
    internal class SortStack
    {
        public void SortStackFun(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int temp = stack.Pop();
                SortStackFun(stack);
                InsertSorted(stack, temp);
            }
        }

        void InsertSorted(Stack<int> stack, int value)
        {
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
                return;
            }

            int temp = stack.Pop();
            InsertSorted(stack, value);
            stack.Push(temp);
        }

    }
}
