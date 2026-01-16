using System;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    public class BrowserUtility : IHistoryManager, ITabManager
    {
        private DoublyLinkedList currentHistory;
        private CustomStack closedHistoryStack;

        public BrowserUtility()
        {
            currentHistory = new DoublyLinkedList();
            closedHistoryStack = new CustomStack();
        }

        public void Visit(string url)
        {
            currentHistory.Visit(url);
        }

        public void Back()
        {
            currentHistory.Back();
        }

        public void Forward()
        {
            currentHistory.Forward();
        }

        public string GetCurrent()
        {
            return currentHistory.GetCurrent();
        }

        public void Close()
        {
            closedHistoryStack.Push(currentHistory);
            currentHistory = new DoublyLinkedList();
            Console.WriteLine("History closed.");
        }

        public void Restore()
        {
            if (closedHistoryStack.IsEmpty())
            {
                Console.WriteLine("No closed history to restore.");
                return;
            }

            currentHistory = (DoublyLinkedList)closedHistoryStack.Pop();
            Console.WriteLine("History restored.");
        }
    }
}
