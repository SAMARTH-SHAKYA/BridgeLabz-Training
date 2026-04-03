using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.vehicle_rental_system
{
    internal class Truck : Vehicle
    {
        public Truck(string vehicleNumber, double rentalRate)  : base(vehicleNumber, rentalRate)
        {
            this.VehicleType = "Truck";
        }

        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) + 500;
        }
    }
}
