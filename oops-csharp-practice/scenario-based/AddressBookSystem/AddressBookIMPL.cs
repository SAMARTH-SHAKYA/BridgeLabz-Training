
using System;

public class AddressBookIMPL : IAddressBook
{
    private AddressBook addressBook;
    public AddressBook AddAddressBook(string name)
    {
        addressBook = new AddressBook(name);
        return addressBook;
    }

    public void SearchPersonByCity(AddressBook[] addressBooks, int count, string city)
    {
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            Contacts[] contacts = addressBooks[i].contacts;

            for (int j = 0; j < contacts.Length; j++)
            {
                if (contacts[j] != null &&
                    contacts[j].City.Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found in Address Book: {addressBooks[i].AddressBookName}");
                    Console.WriteLine(contacts[j]);
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No person found in this city.");
        }
    }

}