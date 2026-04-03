/// <summary>
/// The Product class represents an individual item in the e-commerce system,
/// encapsulating essential details such as product ID, product name, and discount
/// percentage. This class serves as a data model used throughout the application
/// for storing product information, displaying product details, and performing
/// discount-based comparisons during sorting operations.
/// </summary>


class Product
{
  public string ProductId { get; set; }
  public string ProductName { get; set; }
  public double Discount { get; set; }

  public Product(string productId, string productName, double discount)
  {
    ProductId = productId;
    ProductName = productName;
    Discount = discount;
  }

  public override string ToString()
  {
    return $"Name --> {ProductName} || Discount --> {Discount}%";
  }
}