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

    //UC 03 : Ability to edit existing contact person using their name.
    public void EditContact(Contacts contact)
    {
        Console.WriteLine("Press 1 : Edit First Name");
        Console.WriteLine("Press 2 : Edit Last Name");
        Console.WriteLine("Press 3 : Edit Address");
        Console.WriteLine("Press 4 : Edit City");
        Console.WriteLine("Press 5 : Edit State");
        Console.WriteLine("Press 6 : Edit Zip");
        Console.WriteLine("Press 7 : Edit Phone Number");
        Console.WriteLine("Press 8 : Edit Email");
        Console.Write("Enter your choice to edit: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter new First Name: ");
                string firstName = Console.ReadLine();
                contact.SetFirstName(firstName);
                break;
            case 2:
                Console.Write("Enter new Last Name: ");
                string lastName = Console.ReadLine();
                contact.SetLastName(lastName);
                break;
            case 3:
                Console.Write("Enter new Address: ");
                string address = Console.ReadLine();
                contact.SetAddress(address);
                break;
            case 4:
                Console.Write("Enter new City: ");
                string city = Console.ReadLine();
                contact.SetCity(city);
                break;
            case 5:
                Console.Write("Enter new State: ");
                string state = Console.ReadLine();
                contact.SetState(state);
                break;
            case 6:
                Console.Write("Enter new Zip: ");
                string zip = Console.ReadLine();
                contact.SetZip(zip);
                break;
            case 7:
                Console.Write("Enter new Phone Number: ");
                string phoneNumber = Console.ReadLine();
                contact.SetPhoneNumber(phoneNumber);
                break;
            case 8:
                Console.Write("Enter new Email: ");
                string email = Console.ReadLine();
                contact.SetEmail(email);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        
    }

    //UC 04 : Ability to delete a contact person using their name.
    public void DeleteContact(Contacts contact)
    {
        contact = null;
    }
}