namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    public interface IHistoryManager
    {
        void Visit(string url);
        void Back();
        void Forward();
        string GetCurrent();
    }
}
