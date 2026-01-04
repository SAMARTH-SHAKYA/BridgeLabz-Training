using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritance
{
    //main class device
    class Device
    {
        //using getter and setter to get the details
        public int DeviceId { get; set; }
        public string Status { get; set; }
    }

    //sub class thermostat
    class Thermostat : Device
    {
        public double TemperatureSetting { get; set; }
        
        //method to display status
        public void DisplayStatus()
        {
            Console.WriteLine($"Device {DeviceId}: {Status}, Temp: {TemperatureSetting}");
        }
    }

}
