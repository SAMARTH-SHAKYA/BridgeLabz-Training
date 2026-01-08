using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.SmartHomeAutomationSystem
{
    internal class SmartMain
    {
        public static void Main(string[] args)
        {
            ApplianceMenu menu = new ApplianceMenu();
            menu.Menu();
        }
    }
}
