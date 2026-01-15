using System;
class Address
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program");
        AddressMenu addressMenu = new AddressMenu();
        addressMenu.Menu();
        
    }
}