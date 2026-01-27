using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTrainingCollectionsAAndFurther3.smart_checkout
{
    internal class SmartCheckoutMain
    {
        public static void Main(string[] args) {
            Console.WriteLine("Welcome to checkout system.\n");
            CheckoutCounterMenu menu = new CheckoutCounterMenu();
            menu.Checkoutmenu();
        }
    }
}
