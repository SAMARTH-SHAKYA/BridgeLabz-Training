using System;
public abstract class WarehouseItem
{
    public int Id { get; set; }
    public string Name { get; set; }

    protected WarehouseItem(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public abstract void Display();
}
