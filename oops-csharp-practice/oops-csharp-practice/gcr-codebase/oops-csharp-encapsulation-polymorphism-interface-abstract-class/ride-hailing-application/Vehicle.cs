using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.ride_hailing_application
{
    internal abstract class Vehicle
    {
        public string VehicleId { get; private set; }
        public string DriverName { get; private set; }
        public double RatePerKm { get; protected set; }

        protected Vehicle(string vehicleId, string driverName, double ratePerKm)
        {
            this.VehicleId = vehicleId;
            this.DriverName = driverName;
            this.RatePerKm = ratePerKm;
        }

        public void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID : {VehicleId}");
            Console.WriteLine($"Driver Name : {DriverName}");
            Console.WriteLine($"Rate/Km : {RatePerKm}");
        }

        public abstract double CalculateFare(double distance);
    }
}
