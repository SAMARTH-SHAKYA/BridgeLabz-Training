/// <summary>
/// The IEcommerce interface defines the core operations of the e-commerce system,
/// including adding products, displaying the top discounted products, and sorting
/// products based on discount values. It enforces a contract that ensures consistent
/// implementation of business logic related to product management and discount-based
/// ranking across different utility classes.
/// </summary>


interface IEcommerce
{
  void AddProducts(Product product);
  void DisplayTopDiscountedItems(int size = 5);
  void QuickSort();
}