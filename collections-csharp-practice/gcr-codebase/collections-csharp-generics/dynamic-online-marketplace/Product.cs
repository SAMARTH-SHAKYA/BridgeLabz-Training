using System;

public class Product<T> where T : ProductBase
{
    private List<T> products = new List<T>();

    public void AddProduct(T product)
    {
        products.Add(product);
    }

    public List<T> GetAll()
    {
        return products;
    }

    public void DisplayAll()
    {
        foreach (var p in products)
        {
            p.Display();
        }
    }
}
