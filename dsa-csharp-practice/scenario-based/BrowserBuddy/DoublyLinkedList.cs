using System;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    public class DoublyLinkedList
    {
        private DoublyNode head;
        private DoublyNode current;

        public void Visit(string data)
        {
            DoublyNode node = new DoublyNode(data);

            if (head == null)
            {
                head = node;
                current = node;
                return;
            }

            current.Next = null;
            node.Prev = current;
            current.Next = node;
            current = node;
        }

        public void Back()
        {
            if (current != null && current.Prev != null)
                current = current.Prev;
            else
                Console.WriteLine("No previous page.");
        }

        public void Forward()
        {
            if (current != null && current.Next != null)
                current = current.Next;
            else
                Console.WriteLine("No page after this...");
        }

        public string GetCurrent()
        {
            if(current == null)
            {
                return "Empty";
            }
            else
            {
                return current.Data;
            }
        }
    }
}
