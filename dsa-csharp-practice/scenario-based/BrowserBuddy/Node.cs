namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    public class Node
    {
        public object Data;
        public Node Next;

        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }
}
