using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    class RodCuttingMenu
    {
        private IRodCuttingStrategy strategy;
        private int rodLength = 8;
        private int[] prices = { 1, 5, 8, 9, 10, 17, 17, 20 };
        public void ScenarioA()
        {
            strategy = new RodCuttingUtility();
            
            Console.WriteLine("===== Optimized Strategy =====");
            Console.WriteLine("Max profit --> " + strategy.GetMaxProfit(prices, rodLength));
        }
        public void ScenarioB()
        {
            Console.Write("Enter the number of pieces --> ");
            int pieces = int.Parse(Console.ReadLine());
            if(rodLength % pieces == 0)
            {
                Console.WriteLine("Profit --> " + prices[((rodLength-1)/pieces)] * pieces);
            }
        }
        public void ScenarioC()
        {
            Console.Write("Enter the number of pieces --> ");
            int pieces = int.Parse(Console.ReadLine());
            if(pieces > rodLength || rodLength % pieces != 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            else
            {
                Console.WriteLine("Profit --> " + prices[rodLength-1/pieces] * pieces);
            }
        }
    }
}
