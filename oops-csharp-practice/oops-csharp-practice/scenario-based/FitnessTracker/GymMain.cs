using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.FitnessTracker
{
    internal class GymMain
    {
        //entry point for the application
        public static void Main(string[] args)
        {
            GymMenu menu = new GymMenu();
            menu.GymUserMenu();
        }
    }
}
