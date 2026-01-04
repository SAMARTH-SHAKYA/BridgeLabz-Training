using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritance
{
    interface Refuelable
    {
        void Refuel();
    }

    class Vehicles
    {
        public int MaxSpeed { get; set; }
        public string Model { get; set; }
    }

    class ElectricVehicle : Vehicles
    {
        public void Charge()
        {
            Console.WriteLine("Charging vehicle");
        }
    }

    class PetrolVehicle : Vehicles, Refuelable
    {
        public void Refuel()
        {
            Console.WriteLine("Refueling vehicle");
        }
    }

}
