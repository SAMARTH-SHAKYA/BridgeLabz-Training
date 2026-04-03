using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.vehicle_rental_system
{
    internal abstract class Vehicle
    {
        public string VehicleNumber { get; private set; }
        public string VehicleType { get; protected set; }
        public double RentalRate { get; private set; }

        protected Vehicle(string vehicleNumber, double rentalRate)
        {
            this.VehicleNumber = vehicleNumber;
            this.RentalRate = rentalRate;
        }

        public abstract double CalculateRentalCost(int days);
    }
}
