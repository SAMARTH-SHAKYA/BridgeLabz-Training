using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.smart_checkout
{
    internal class CheckoutCounterUtility : ICheckout
    {
        private Dictionary<string,int> ItemPrice;
        private Dictionary<string, int> ItemStock;

        Queue<List<String>> customers; 

        public CheckoutCounterUtility()
        {
            ItemPrice = new Dictionary<string, int>()
            {
                {"bread", 30 },
                {"butter", 10 },
                {"jam", 50 },
                {"coldrink", 100 },
                {"chips", 20 }
            };

            ItemStock = new Dictionary<string, int>()
            {
                {"bread", 10 },
                {"butter", 10 },
                {"jam", 10 },
                {"coldrink", 10 },
                {"chips", 10 }
            };


            customers = new Queue<List<string>>();
        }

        public void AddACustomer()
        {
            

            bool isAdding = true;

            List<string> items = new List<string>();

            while( isAdding)
            {
                Console.WriteLine("Items: ");
                int i = 1;
                foreach (string key in ItemPrice.Keys)
                {
                    if (ItemStock[key] > 0)
                    {
                        Console.WriteLine($"{i}. {key}");
                        i++;
                    }
                }
                Console.WriteLine("\n Choose the task you want to do: ");
                Console.WriteLine("1. Choose Item. ");
                Console.WriteLine("2. Stop choosing.");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("\nChoose the item you want to add: ");
                        string item = Console.ReadLine();
                        items.Add(item);
                        ItemStock[item] = ItemStock[item]--;
                        break;
                    case 2:
                        isAdding = false;
                        Console.WriteLine("Wait while your order is processed.\n");
                        break;
                    default:
                        Console.WriteLine("Wrong Choice!\n");
                        break;
                }
            }

            if(items.Count == 0)
            {
                Console.WriteLine("Customer can't be added to the queue.\nAtleast one item needed!" );
                return;
            }

            customers.Enqueue(items);

        }


        public void RemoveCustomer()
        {
            int bill = 0;

            List<string> customerList = customers.Dequeue();

            foreach (string customerItem in customerList)
            {
                bill += ItemPrice[customerItem];
            }

            Console.WriteLine("Removed Customer from the queue.");
            Console.WriteLine($"Total bill amount for the removed customer is : {bill}\n");
        }


        public void FetchItemPrice()
        {
            foreach (string key in ItemPrice.Keys)
            {
                Console.WriteLine($"Item: {key}, Price: {ItemPrice[key]}");
            }
            Console.WriteLine();
        }
    }
}
