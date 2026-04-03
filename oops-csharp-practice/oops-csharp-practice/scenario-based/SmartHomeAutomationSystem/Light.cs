using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.SmartHomeAutomationSystem
{
    internal class Light : Appliance
    {
        public int LightEnergy { get;  private set; }
        public string LightCompanyName { get; private set; }

        public string Status { get; set; }

        public Light(int roomNumber, string roomName, string roomDescription, int lightEnergy, string lightCompanyName) : base(roomNumber, roomName, roomDescription)
        {
            this.LightEnergy = lightEnergy;
            this.LightCompanyName = lightCompanyName;
            this.Status = "Off";
        }

        public override string WorkingStatus()
        {
            string workingStatus = "Yes";
            return workingStatus;
        }

    }
}
