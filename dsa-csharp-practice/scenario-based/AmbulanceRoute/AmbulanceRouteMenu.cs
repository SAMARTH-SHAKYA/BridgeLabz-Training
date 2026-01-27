using System;

class AmbulanceRouteMenu
{
  private AmbulanceRoute route;

  public AmbulanceRouteMenu(AmbulanceRoute route)
  {
    this.route = route;
  }

  public void Start()
  {
    while (true)
    {
      Console.WriteLine("\n--- Ambulance Route Menu ---");
      Console.WriteLine("1. Show Hospital Route");
      Console.WriteLine("2. Ambulance Arrives (Find Available Unit)");
      Console.WriteLine("3. Mark Unit as Occupied");
      Console.WriteLine("4. Send Unit for Maintenance");
      Console.WriteLine("5. Exit");
      Console.Write("Enter choice: ");

      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          route.DisplayRoute();
          break;

        case "2":
          HandleAmbulanceArrival();
          break;

        case "3":
          MarkUnitOccupied();
          break;

        case "4":
          RemoveUnitForMaintenance();
          break;

        case "5":
          Console.WriteLine("Exiting system...");
          return;

        default:
          Console.WriteLine("Invalid choice. Try again.");
          break;
      }
    }
  }

  private void HandleAmbulanceArrival()
  {
    HospitalUnit unit = route.FindAvailableUnit();

    if (unit == null)
    {
      Console.WriteLine("No available hospital units!");
    }
    else
    {
      Console.WriteLine($"Patient redirected to: {unit.Name}");
      unit.Occupied = true;
    }
  }

  private void MarkUnitOccupied()
  {
    Console.Write("Enter unit name to mark occupied: ");
    string name = Console.ReadLine();

    route.OccupyUnit(name);
    Console.WriteLine($"{name} marked as occupied.");
  }

  private void RemoveUnitForMaintenance()
  {
    Console.Write("Enter unit name for maintenance: ");
    string name = Console.ReadLine();

    route.RemoveUnit(name);
    Console.WriteLine($"{name} removed from route (maintenance).");
  }
}
