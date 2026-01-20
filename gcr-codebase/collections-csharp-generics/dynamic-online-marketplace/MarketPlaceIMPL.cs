public class MarketplaceIMPL : IMarketplace
{
    private Product<BookCategory> books = new Product<BookCategory>();
    private Product<ClothingCategory> clothes = new Product<ClothingCategory>();

    public void AddBook()
    {
        BookCategory book = new BookCategory(1, "C# in Depth", 500, "Jon Skeet");
        DiscountUtility.ApplyDiscount(book, 10);
        books.AddProduct(book);
        Console.WriteLine("Book added with discount!");
    }

    public void AddClothing()
    {
        ClothingCategory cloth = new ClothingCategory(2, "T-Shirt", 800, "L");
        DiscountUtility.ApplyDiscount(cloth, 20);
        clothes.AddProduct(cloth);
        Console.WriteLine("Clothing added with discount!");
    }

    public void ShowAllProducts()
    {
        Console.WriteLine("\n--- Books ---");
        books.DisplayAll();

        Console.WriteLine("\n--- Clothing ---");
        clothes.DisplayAll();
    }
}
