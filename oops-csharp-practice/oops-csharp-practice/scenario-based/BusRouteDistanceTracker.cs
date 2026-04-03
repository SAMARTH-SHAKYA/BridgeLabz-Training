
using System.Collections.Generic;
using System.Text;

using System;

namespace BridgeLabzTraining.Scenario_oops
{
    internal class BusRouteDistanceTracker
    {
        //method which will be called by the main
        public void Run()
        {
            Console.WriteLine("-------------------- Bus Route Distance Tracker --------------------");

            int totalDistance = 0;
            bool isExit = false;

            while (isExit == false)
            {
                //taking input from the user
                Console.WriteLine("Enter distance for next stop (in km):");
                int distance = Convert.ToInt32(Console.ReadLine());

                if (distance <= 0)
                {
                    Console.WriteLine("Invalid distance");
                    continue;
                }

                //calculating the total distance
                totalDistance += distance;
                Console.WriteLine($"Total Distance Travelled: {totalDistance} km");

                Console.WriteLine("Do you want to get off at this stop? (yes/no)");
                string choice = Console.ReadLine().ToLower();


                //if choice yes the exit
                if (choice == "yes")
                {
                    Console.WriteLine("Passenger got off the bus.");
                    Console.WriteLine($"Final Distance Travelled: {totalDistance} km");
                    isExit = true;
                }
            }
        }
    }
}

