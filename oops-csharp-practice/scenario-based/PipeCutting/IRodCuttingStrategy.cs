namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    interface IRodCuttingStrategy
    {
        int GetMaxProfit(int[] prices, int rodLength);
        int GetProfit(int[] prices, int rodLength);
    }
}
