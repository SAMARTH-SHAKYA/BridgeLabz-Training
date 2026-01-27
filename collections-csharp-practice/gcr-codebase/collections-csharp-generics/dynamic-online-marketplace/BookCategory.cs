using System;
public class BookCategory : ProductBase
{
    public string Author { get; set; }

    public BookCategory(int id, string name, double price, string author)
        : base(id, name, price)
    {
        Author = author;
    }

    public override void Display()
    {
        Console.WriteLine($"[Book] ID: {Id}, Name: {Name}, Author: {Author}, Price: {Price}");
    }
}
