namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    public class CustomStack
    {
        private Node top;

        public void Push(object data)
        {
            Node node = new Node(data);
            node.Next = top;
            top = node;
        }

        public object Pop()
        {
            if (top == null)
                return null;

            object data = top.Data;
            top = top.Next;
            return data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
