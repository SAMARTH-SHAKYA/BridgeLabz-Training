public class MarketplaceMenu
{
    private IMarketplace marketplaceService;

    public MarketplaceMenu()
    {
        marketplaceService = new MarketplaceIMPL();
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n====== Online Marketplace ======");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Add Clothing");
            Console.WriteLine("3. Show All Products");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    marketplaceService.AddBook();
                    break;
                case 2:
                    marketplaceService.AddClothing();
                    break;
                case 3:
                    marketplaceService.ShowAllProducts();
                    break;
                case 4:
                    return;
            }
        }
    }
}
