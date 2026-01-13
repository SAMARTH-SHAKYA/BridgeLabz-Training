using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.CustomFurnitureMnufacturing
{
    internal interface IFurniture
    {
        public int MaxProfit(int n);
        public int MaxProfitWithWaste(int n, int wasteAllowed);
    }
}
