using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritance
{
    //main class vehicle
    class Vehicle
    {
        //global non static variables
        public int MaxSpeed { get; set; }
        public string FuelType { get; set; }

        //method to display information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Speed: {MaxSpeed}, Fuel: {FuelType}");
        }
    }

    //child class of vehicle
    class Car : Vehicle
    {
        public int SeatCapacity { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seats: {SeatCapacity}");
        }
    }
    //child class of vehicle
    class Truck : Vehicle
    {
        public int PayloadCapacity { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Payload: {PayloadCapacity}");
        }
    }

    //child class of vehicle
    class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Sidecar: {HasSidecar}");
        }
    }

}
