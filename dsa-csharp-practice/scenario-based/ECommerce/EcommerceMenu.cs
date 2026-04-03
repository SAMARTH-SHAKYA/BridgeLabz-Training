/// <summary>
/// The EcommerceMenu class provides a console-based user interface for interacting
/// with the e-commerce system. It presents a menu-driven workflow that allows users
/// to add products, view the top discounted products, and exit the application.
/// The class acts as a bridge between user input and the underlying business logic
/// defined by the IEcommerce interface.
/// </summary>


using System;

class EcommerceMenu
{
  private IEcommerce ecommerceUtilityImpl;
  public void StartMenu()
  {
    ecommerceUtilityImpl = new EcommerceUtilityImpl(20);
    while (true)
    {
      Console.WriteLine("Select your actions:");
      Console.WriteLine("1. Add a product.");
      Console.WriteLine("2. Display top n number of discounted products.");
      Console.WriteLine("0. Exit");
      int choice;
      if (int.TryParse(Console.ReadLine(), out choice))
      {
        switch (choice)
        {
          case 1:
            Console.Write("Enter the product id --> ");
            string pId = Console.ReadLine();
            Console.Write("Enter the product name --> ");
            string pName = Console.ReadLine();
            Console.Write("Enter the discount percent on the product --> ");
            double d = double.Parse(Console.ReadLine());
            Product p = new Product(pId, pName, d);
            ecommerceUtilityImpl.AddProducts(p);
            break;

          case 2:
            Console.Write("Enter the number of top discounted products you want to see --> ");
            int n = int.Parse(Console.ReadLine());
            ecommerceUtilityImpl.DisplayTopDiscountedItems(n);
            break;

          case 0:
            return;
        }
      }
    }
  }
}