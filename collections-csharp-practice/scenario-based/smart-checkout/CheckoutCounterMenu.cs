using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.smart_checkout
{
    internal class CheckoutCounterMenu
    {
        ICheckout checkoutSystem;
        public void Checkoutmenu()
        {
            checkoutSystem = new CheckoutCounterUtility();

            bool isRunning = true;

            while(isRunning){
                Console.WriteLine("1. Add a customer to the queue.");
                Console.WriteLine("2. Remove a customer from the queue.");
                Console.WriteLine("3. Fetch Item Prices.");
                Console.WriteLine("4. Exit.");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        checkoutSystem.AddACustomer();
                        break;
                    case 2:
                        checkoutSystem.RemoveCustomer();
                        break;
                    case 3: 
                        checkoutSystem.FetchItemPrice();
                        break;
                    case 4:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
