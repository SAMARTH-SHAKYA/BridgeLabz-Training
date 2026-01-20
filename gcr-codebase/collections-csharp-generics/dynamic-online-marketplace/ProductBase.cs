using System;
public abstract class ProductBase
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    protected ProductBase(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public abstract void Display();
}
