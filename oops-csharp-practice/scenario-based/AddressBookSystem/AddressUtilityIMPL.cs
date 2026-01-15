using System;

class AddressUtilityIMPL : IAddress
{
    private Contacts contact;

    //UC 02 : Ability to add a new contact to address book system.
    public Contacts AddContact()
    {
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter Address: ");
        string address = Console.ReadLine();
        Console.Write("Enter City: ");
        string city = Console.ReadLine();
        Console.Write("Enter State: ");
        string state = Console.ReadLine();
        Console.Write("Enter Zip: ");
        string zip = Console.ReadLine();
        Console.Write("Enter Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter Email: ");
        string email = Console.ReadLine();
        contact = new Contacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
        Console.WriteLine("Contact added successfully:");
        Console.WriteLine(contact.ToString());
        return contact;
    }
}