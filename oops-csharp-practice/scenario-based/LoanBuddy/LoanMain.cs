using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.LoanBuddy
{
    internal class LoanMain
    {
        public static void Main(string[] args)
        {
            LoanMenu menu = new LoanMenu();
            menu.Menu();
        }
    }
}
