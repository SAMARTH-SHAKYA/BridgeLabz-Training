public class WarehouseMenu
{
    private IWarehouse warehouseService;

    public WarehouseMenu()
    {
        warehouseService = new WarehouseIMPL(); // interface ref = impl object
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n====== Smart Warehouse Menu ======");
            Console.WriteLine("1. Add Electronics");
            Console.WriteLine("2. Add Groceries");
            Console.WriteLine("3. Add Furniture");
            Console.WriteLine("4. Show All Items");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    warehouseService.AddElectronics();
                    break;
                case 2:
                    warehouseService.AddGroceries();
                    break;
                case 3:
                    warehouseService.AddFurniture();
                    break;
                case 4:
                    warehouseService.ShowAll();
                    break;
                case 5:
                    return;
            }
        }
    }
}
