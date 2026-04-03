/// <summary>
/// The EcommerceUtilityImpl class provides the core implementation of the e-commerce
/// business logic by managing a collection of products using a fixed-size array and
/// performing discount-based sorting using the Quick Sort algorithm. It supports
/// adding new products, displaying the top discounted items, and efficiently
/// organizing product data to simulate a flash-sale scenario with fast retrieval
/// of high-discount products.
/// </summary>


using System;

class EcommerceUtilityImpl : IEcommerce
{
  private Product[] products;
  private int count;
  private int capacity;

  public EcommerceUtilityImpl(int capacity)
  {
    products = new Product[]
        {
            new Product("P1", "Laptop", 25),
            new Product("P2", "Phone", 40),
            new Product("P3", "Headphones", 15),
            new Product("P4", "Monitor", 30),
            new Product("P5", "Keyboard", 10)
        };

    count = products.Length;
    this.capacity = capacity;
  }

  public void AddProducts(Product product)
  {
    if (count >= capacity)
    {
      Console.WriteLine("Warehouse is full already.");
      return;
    }
    products[count] = product;
    count++;
  }

  public void DisplayTopDiscountedItems(int n)
  {
    int limit = n <= count ? n : count;
    Console.WriteLine($"Top {limit} discounted products are: ");
    QuickSort();
    for (int i = 0; i < limit; i++)
    {
      Console.Write(products[i]);
      Console.WriteLine();
    }
  }

  public void QuickSort()
  {
    QuickSortHelper(0, count - 1);
  }

  private void QuickSortHelper(int low, int high)
  {
    if (low < high)
    {
      int partitionIndex = Partition(low, high);
      QuickSortHelper(low, partitionIndex - 1);
      QuickSortHelper(partitionIndex + 1, high);
    }
  }

  private int Partition(int low, int high)
  {
    Product pivot = products[low];
    int i = low;
    int j = high;

    while (i < j)
    {
      // move i right while element >= pivot
      while (i <= high - 1 && products[i].Discount >= pivot.Discount)
      {
        i++;
      }

      // move j left while element < pivot
      while (products[j].Discount < pivot.Discount)
      {
        j--;
      }

      if (i < j)
      {
        Swap(i, j);
      }
    }

    // place pivot at correct position
    Swap(low, j);
    return j;
  }


  private void Swap(int i, int j)
  {
    Product temp = products[i];
    products[i] = products[j];
    products[j] = temp;
  }

}