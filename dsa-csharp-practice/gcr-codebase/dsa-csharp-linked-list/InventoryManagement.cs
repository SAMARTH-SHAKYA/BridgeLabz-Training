using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.dsa_csharp_linked_list
{
    public class Item
    {
        public string Name;
        public int ID;
        public int Quantity;
        public double Price;
        public Item Next;

        public Item(string name, int id, int quantity, double price)
        {
            Name = name;
            ID = id;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }



    public class InventoryManagement
    {
        private Item head;

        public void AddItem(string name, int id, int quantity, double price, int position)
        {
            Item newNode = new Item(name, id, quantity, price);

            if (position <= 0 || head == null)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }

            Item current = head;
            for (int i = 0; current.Next != null && i < position - 1; i++)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void RemoveItem(int id)
        {
            if (head == null) return;

            if (head.ID == id)
            {
                head = head.Next;
                return;
            }

            Item current = head;
            while (current.Next != null && current.Next.ID != id)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        public void UpdateQuantity(int id, int newQuantity)
        {
            Item current = head;
            while (current != null)
            {
                if (current.ID == id)
                {
                    current.Quantity = newQuantity;
                    return;
                }
                current = current.Next;
            }
        }

        public void Search(int? id = null, string name = null)
        {
            Item current = head;
            while (current != null)
            {
                if ((id.HasValue && current.ID == id.Value) ||
                    (name != null && current.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Found: {current.Name} (ID: {current.ID}), Qty: {current.Quantity}, Price: ${current.Price}");
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("Item not found.");
        }

        public void DisplayTotalValue()
        {
            double total = 0;
            Item current = head;
            while (current != null)
            {
                total += (current.Price * current.Quantity);
                current = current.Next;
            }
            Console.WriteLine($"Total Inventory Value: ${total:F2}");
        }

        public void Sort(bool byName, bool ascending)
        {
            if (head == null || head.Next == null) return;

            bool swapped;
            do
            {
                swapped = false;
                Item current = head;
                Item prev = null;

                while (current != null && current.Next != null)
                {
                    bool shouldSwap = false;
                    if (byName)
                    {
                        int comparison = string.Compare(current.Name, current.Next.Name);
                        shouldSwap = ascending ? comparison > 0 : comparison < 0;
                    }
                    else
                    {
                        shouldSwap = ascending ? current.Price > current.Next.Price : current.Price < current.Next.Price;
                    }

                    if (shouldSwap)
                    {
                        Item nextNode = current.Next;
                        current.Next = nextNode.Next;
                        nextNode.Next = current;

                        if (prev == null) head = nextNode;
                        else prev.Next = nextNode;

                        prev = nextNode;
                        swapped = true;
                    }
                    else
                    {
                        prev = current;
                        current = current.Next;
                    }
                }
            } while (swapped);
        }

        public void Display()
        {
            Item current = head;
            while (current != null)
            {
                Console.WriteLine($"ID: {current.ID} | {current.Name} | Qty: {current.Quantity} | Price: ${current.Price}");
                current = current.Next;
            }
        }

        public static void Main()
        {
            InventoryManagement inv = new InventoryManagement();
            inv.AddItem("Laptop", 1, 10, 1200.00, 0);
            inv.AddItem("Mouse", 2, 50, 25.50, 1);
            inv.AddItem("Keyboard", 3, 30, 45.00, 1);

            Console.WriteLine("Original Inventory:");
            inv.Display();

            inv.DisplayTotalValue();

            Console.WriteLine("Sorting by Price (Descending):");
            inv.Sort(false, false);
            inv.Display();

            Console.WriteLine("Updating Quantity of ID 2 to 60 and searching for 'Laptop':");
            inv.UpdateQuantity(2, 60);
            inv.Search(name: "Laptop");
        }
    }
}
