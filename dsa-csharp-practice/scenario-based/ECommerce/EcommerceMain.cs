/// <summary>
/// The EcommerceMain class serves as the entry point of the e-commerce application.
/// It initializes the menu-driven user interface and starts the program execution
/// by invoking the StartMenu method, enabling users to interact with the system
/// through console-based operations.
/// </summary>


using System;
using System.ComponentModel.Design;

class EcommerceMain
{
  static void Main()
  {
    EcommerceMenu menu = new EcommerceMenu();
    menu.StartMenu();
  }
}