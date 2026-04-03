using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.SmartHomeAutomationSystem
{
    internal class ControllableUtility : IControllable
    {
        public void TurnOn(Fan fan)
        {
            if(fan.Status == "On")
            {
                Console.WriteLine("Already on");
            }
            fan.Status = "On";
            Console.WriteLine("fan on");
        }
        public void TurnOn(AC ac)
        {
            if (ac.Status == "On")
            {
                Console.WriteLine("Already on");
            }
            ac.Status = "On";
            Console.WriteLine("ac on");
        }
        public void TurnOn(Light light)
        {
            if (light.Status == "On")
            {
                Console.WriteLine("Already on");
            }
            light.Status = "On";
            Console.WriteLine("light on");
        }
        public void TurnOff(Fan fan)
        {
            if (fan.Status == "Off")
            {
                Console.WriteLine("Already off");
            }
            fan.Status = "Off";
            Console.WriteLine("light off");
        }
        public void TurnOff(AC ac)
        {
            if (ac.Status == "Off")
            {
                Console.WriteLine("Already off");
            }
            ac.Status = "Off";
            Console.WriteLine("ac off");
        }

        public void TurnOff(Light light)
        {
            if (light.Status == "Off")
            {
                Console.WriteLine("Already off");
            }
            light.Status = "Off";

            Console.WriteLine("ac off");
        }
    }
}
