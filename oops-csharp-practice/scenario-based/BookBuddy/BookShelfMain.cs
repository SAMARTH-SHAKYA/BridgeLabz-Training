using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.BookBuddy
{
    internal class BookShelfMain
    {
        public static void main(string[] args)
        {
            BookShelfMenu menu = new BookShelfMenu();
            menu.Menu();
        }
    }
}
