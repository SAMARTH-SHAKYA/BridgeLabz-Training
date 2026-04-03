using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Sealed
{
    using System;

    class Vehicle
    {
        //global static variables
        public static double RegistrationFee = 5000;

        //non static global variables
        public string RegistrationNumber { get; private set; }
        public string OwnerName { get; set; }
        public string VehicleType { get; set; }


        //calling the costructor
        public Vehicle(string regNo, string owner, string type)
        {
            this.RegistrationNumber = regNo;
            this.OwnerName = owner;
            this.VehicleType = type;
        }


        //method to update registration fee
        public static void UpdateRegistrationFee(double fee)
        {
            RegistrationFee = fee;
        }

        //method to check the instance of the object
        public void Display(object obj)
        {
            if (obj is Vehicle)
            {
                Console.WriteLine($"Reg No: {RegistrationNumber}, Owner: {OwnerName}, Type: {VehicleType}, Fee: {RegistrationFee}");
            }
        }
    }

}
