using System;
public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayAll()
    {
        foreach (var item in items)
        {
            item.Display();
        }
    }
}
