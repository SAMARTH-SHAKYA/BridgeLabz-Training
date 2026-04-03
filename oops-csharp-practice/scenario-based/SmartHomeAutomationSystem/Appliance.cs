using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.SmartHomeAutomationSystem
{
    internal abstract class Appliance
    {
        public int RoomNumber { get; protected set; }
        public string RoomName { get; protected set; }

        
        public string RoomDescription { get; protected set; }

        public Appliance(int roomNumber, string roomName, string roomDescription)
        {
            this.RoomNumber = roomNumber;
            this.RoomName = roomName;
            this.RoomDescription = roomDescription;
            
        }

        public abstract string WorkingStatus();
    }
}
