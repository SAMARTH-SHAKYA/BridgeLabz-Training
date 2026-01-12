using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    class RodCuttingMain
    {
        static void Main()
        {
            RodCuttingMenu rodCutting = new RodCuttingMenu();
            rodCutting.ScenarioA();
            rodCutting.ScenarioB();
            rodCutting.ScenarioC();
            
        }
    }
}
