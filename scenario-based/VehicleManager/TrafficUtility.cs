using System;

public class TrafficUtility : IVehicleManager
{
    private Roundabout roundabout;
    private VehicleQueue queue;

    public TrafficUtility()
    {
        roundabout = new Roundabout();
        queue = new VehicleQueue(5);
    }

    public void AddVehicleToQueue()
    {
        Console.Write("Enter vehicle number: ");
        string v = Console.ReadLine();
        queue.Enqueue(v);
    }

    public void MoveVehicleToRoundabout()
    {
        string vehicle = queue.Dequeue();
        if (vehicle != null)
            roundabout.AddVehicle(vehicle);
    }

    public void ExitVehicleFromRoundabout()
    {
        roundabout.RemoveVehicle();
    }

    public void DisplayRoundabout()
    {
        roundabout.Display();
    }

    public void DisplayQueue()
    {
        queue.DisplayQueue();
    }

    public void ShowMenu()
    {
        Console.WriteLine("\n--- Traffic Manager ---");
        Console.WriteLine("1. Add Vehicle to Queue");
        Console.WriteLine("2. Move Vehicle to Roundabout");
        Console.WriteLine("3. Exit Vehicle from Roundabout");
        Console.WriteLine("4. Display Roundabout");
        Console.WriteLine("5. Display Queue");
        Console.WriteLine("6. Exit");
        Console.Write("Choose: ");
    }

    public void HandleChoice(int choice)
    {
        if (choice == 1) AddVehicleToQueue();
        else if (choice == 2) MoveVehicleToRoundabout();
        else if (choice == 3) ExitVehicleFromRoundabout();
        else if (choice == 4) DisplayRoundabout();
        else if (choice == 5) DisplayQueue();
        else if (choice == 6) Environment.Exit(0);
        else Console.WriteLine("Invalid choice.");
    }
}
