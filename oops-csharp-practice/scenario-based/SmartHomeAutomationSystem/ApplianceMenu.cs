using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.SmartHomeAutomationSystem
{
    
    sealed class ApplianceMenu
    {
        private IControllable controllable;

        public void Menu()
        {
            controllable = new ControllableUtility();

            Light L1 = new Light(01, "Tubelight", "Luminous", 50, "Philips");

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : To close the appliance");
                Console.WriteLine("Press 2 : To on the appliance");
                Console.WriteLine("Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        controllable.TurnOn(L1);
                        break;
                    case 2:
                        controllable.TurnOff(L1);
                        break;
                    case 3:
                        isTrue = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }        
        }
    }
}
