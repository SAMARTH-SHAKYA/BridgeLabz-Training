using System;

public class Roundabout
{
    private VehicleNode head = null;

    public void AddVehicle(string number)
    {
        VehicleNode newNode = new VehicleNode(number);

        if (head == null)
        {
            head = newNode;
            newNode.next = head;
        }
        else
        {
            VehicleNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            temp.next = newNode;
            newNode.next = head;
        }

        Console.WriteLine($"{number} entered the roundabout.");
    }

    public void RemoveVehicle()
    {
        if (head == null)
        {
            Console.WriteLine("No vehicles in roundabout.");
            return;
        }

        if (head.next == head)
        {
            Console.WriteLine($"{head.VehicleNumber} exited.");
            head = null;
        }
        else
        {
            VehicleNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            Console.WriteLine($"{head.VehicleNumber} exited.");
            temp.next = head.next;
            head = head.next;
        }
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        VehicleNode temp = head;
        Console.Write("Roundabout: ");
        do
        {
            Console.Write(temp.VehicleNumber + " → ");
            temp = temp.next;
        } while (temp != head);

        Console.WriteLine("(back to start)");
    }
}
