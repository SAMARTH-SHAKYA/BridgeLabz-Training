using System;

class AmbulanceRoute
{
  private HospitalUnit head;
  private HospitalUnit current;

  // Create circular route from first unit
  public void AddUnit(string name)
  {
    HospitalUnit newUnit = new HospitalUnit(name);

    if (head == null)
    {
      head = newUnit;
      head.NextUnit = head;
      head.PrevUnit = head;
      current = head;
    }
    else
    {
      HospitalUnit tail = head.PrevUnit;

      tail.NextUnit = newUnit;
      newUnit.PrevUnit = tail;

      newUnit.NextUnit = head;
      head.PrevUnit = newUnit;
    }
  }

  // Find next available unit by rotating
  public HospitalUnit FindAvailableUnit()
  {
    if (current == null)
      return null;

    HospitalUnit start = current;

    do
    {
      if (!current.Occupied)
        return current;

      current = current.NextUnit;

    } while (current != start);

    return null; // all units occupied
  }

  // Mark a unit as occupied
  public void OccupyUnit(string name)
  {
    HospitalUnit unit = FindUnit(name);
    if (unit != null)
      unit.Occupied = true;
  }

  // Remove unit under maintenance
  public void RemoveUnit(string name)
  {
    HospitalUnit unit = FindUnit(name);
    if (unit == null)
      return;

    if (unit.NextUnit == unit) // only one unit left
    {
      head = null;
      current = null;
      return;
    }

    unit.PrevUnit.NextUnit = unit.NextUnit;
    unit.NextUnit.PrevUnit = unit.PrevUnit;

    if (unit == head)
      head = unit.NextUnit;

    if (unit == current)
      current = unit.NextUnit;
  }

  // Display circular route
  public void DisplayRoute()
  {
    if (head == null)
    {
      Console.WriteLine("No hospital units available.");
      return;
    }

    HospitalUnit temp = head;
    do
    {
      Console.Write($"{temp.Name} ({(temp.Occupied ? "Busy" : "Available")}) -> ");
      temp = temp.NextUnit;
    } while (temp != head);

    Console.WriteLine("(back to start)");
  }

  private HospitalUnit FindUnit(string name)
  {
    if (head == null)
      return null;

    HospitalUnit temp = head;
    do
    {
      if (temp.Name == name)
        return temp;

      temp = temp.NextUnit;
    } while (temp != head);

    return null;
  }
}
