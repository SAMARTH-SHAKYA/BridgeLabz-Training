using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class VechileRegistration
    {
        //instance variables
        public string ownerName;
        public string vehicleType;

        //class variable
        public static double registrationFee = 5000;

        //calling the constructor
        public VechileRegistration(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        //method to display vehicle details
        public void DisplayVehicle()
        {
            Console.WriteLine($"Owner Name: {ownerName}");
            Console.WriteLine($"Vehicle Type: {vehicleType}");
            Console.WriteLine($"Registration Fee: {registrationFee}");
            Console.WriteLine("---------------------------");
        }

        //class method to update registration fee
        public static void UpdateFee(double newFee)
        {
            registrationFee = newFee;
        }
    }
}
