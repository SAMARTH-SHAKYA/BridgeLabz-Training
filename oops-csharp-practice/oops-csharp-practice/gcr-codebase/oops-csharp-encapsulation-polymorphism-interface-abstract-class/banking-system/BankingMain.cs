using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.banking_system
{
    internal class BankingMain
    {
        public static void main(string[] args)
        {
            BankingMenu menu = new BankingMenu();
            menu.Menu();
        }
    }
}
