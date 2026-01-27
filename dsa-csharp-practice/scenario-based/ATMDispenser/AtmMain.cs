using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.ATMDispenser
{
    internal class AtmMain
    {
        public static void Main(string[] args)
        {
            AtmMenu  menu = new AtmMenu();
            menu.AtmMenuDispense();

        }
    }
}
