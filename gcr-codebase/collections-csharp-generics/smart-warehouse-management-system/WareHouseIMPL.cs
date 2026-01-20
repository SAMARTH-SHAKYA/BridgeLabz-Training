using System;

public class WarehouseIMPL : IWarehouse
{
    private Storage<Electronics> electronicsStorage = new Storage<Electronics>();
    private Storage<Groceries> groceriesStorage = new Storage<Groceries>();
    private Storage<Furniture> furnitureStorage = new Storage<Furniture>();

    public void AddElectronics()
    {
        electronicsStorage.AddItem(new Electronics(1, "Laptop"));
        Console.WriteLine("Electronics item added!");
    }

    public void AddGroceries()
    {
        groceriesStorage.AddItem(new Groceries(2, "Milk"));
        Console.WriteLine("Groceries item added!");
    }

    public void AddFurniture()
    {
        furnitureStorage.AddItem(new Furniture(3, "Chair"));
        Console.WriteLine("Furniture item added!");
    }

    public void ShowAll()
    {
        Console.WriteLine("\n--- Electronics ---");
        electronicsStorage.DisplayAll();

        Console.WriteLine("\n--- Groceries ---");
        groceriesStorage.DisplayAll();

        Console.WriteLine("\n--- Furniture ---");
        furnitureStorage.DisplayAll();
    }
}
