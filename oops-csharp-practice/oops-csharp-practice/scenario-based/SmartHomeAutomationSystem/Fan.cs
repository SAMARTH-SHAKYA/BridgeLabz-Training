using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.SmartHomeAutomationSystem
{
    internal class Fan : Appliance
    {
        public int FanBlades { get; private set; }
        public string FanCompanyName { get; private set; }

        public string Status { get; set; }

        public Fan(int roomNumber, string roomName, string roomDescription, int fanBlades, string fanCompanyName) : base(roomNumber, roomName, roomDescription)
        {
            this.FanBlades = fanBlades;
            this.FanCompanyName = fanCompanyName;
            this.Status = "Off";
        }

        public override string WorkingStatus()
        {
            string workingStatus = "Yes";
            return workingStatus;
        }
    }
}
