namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    public class DoublyNode
    {
        public string Data;
        public DoublyNode Prev;
        public DoublyNode Next;

        public DoublyNode(string data)
        {
            Data = data;
            Prev = null;
            Next = null;
        }
    }
}
