using System;
public class Furniture : WarehouseItem
{
    public Furniture(int id, string name) : base(id, name) { }

    public override void Display()
    {
        Console.WriteLine($"[Furniture] ID: {Id}, Name: {Name}");
    }
}
