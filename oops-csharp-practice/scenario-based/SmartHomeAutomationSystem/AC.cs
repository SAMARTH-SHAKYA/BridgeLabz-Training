using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.SmartHomeAutomationSystem
{
    internal class AC : Appliance
    {
        public int ACTon { get; private set; }
        public string ACType { get; private set; }

        public string Status { get; set; }
        public AC(int roomNumber, string roomName, string roomDescription, int acTon, string acType) : base(roomNumber, roomName, roomDescription)
        {
            this.ACTon = acTon;
            this.ACType = acType;
            this.Status = "Off";
        }

        public override string WorkingStatus()
        {
            string workingStatus = "Yes";
            return workingStatus;
        }
    }
}
