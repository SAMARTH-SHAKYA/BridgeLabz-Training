using System;
public class Electronics : WarehouseItem
{
    public Electronics(int id, string name) : base(id, name) { }

    public override void Display()
    {
        Console.WriteLine($"[Electronics] ID: {Id}, Name: {Name}");
    }
}
