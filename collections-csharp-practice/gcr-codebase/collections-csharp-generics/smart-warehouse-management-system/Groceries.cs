using System;
public class Groceries : WarehouseItem
{
    public Groceries(int id, string name) : base(id, name) { }

    public override void Display()
    {
        Console.WriteLine($"[Groceries] ID: {Id}, Name: {Name}");
    }
}
