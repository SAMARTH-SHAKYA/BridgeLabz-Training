using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.SmartHomeAutomationSystem
{
    internal interface IControllable
    {
        public void TurnOn(Fan fan);
        public void TurnOn(AC ac);
        public void TurnOn(Light light);
        public void TurnOff(Fan fan);
        public void TurnOff(AC ac);

        public void TurnOff(Light light);

    }
}
