public class ClothingCategory : ProductBase
{
    public string Size { get; set; }

    public ClothingCategory(int id, string name, double price, string size)
        : base(id, name, price)
    {
        Size = size;
    }

    public override void Display()
    {
        Console.WriteLine($"[Clothing] ID: {Id}, Name: {Name}, Size: {Size}, Price: {Price}");
    }
}
