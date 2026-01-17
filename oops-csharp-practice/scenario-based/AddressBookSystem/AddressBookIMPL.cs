
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


    public void ViewPersonsByCity(AddressBook[] addressBooks, int count)
    {
        string[] printedCities = new string[100];
        int cityCount = 0;

        bool foundAny = false;

        for (int i = 0; i < count; i++)
        {
            Contacts[] contacts = addressBooks[i].contacts;

            for (int j = 0; j < contacts.Length; j++)
            {
                if (contacts[j] != null)
                {
                    string city = contacts[j].City;

                    // Check if this city is already printed
                    bool alreadyPrinted = false;
                    for (int k = 0; k < cityCount; k++)
                    {
                        if (printedCities[k] == city)
                        {
                            alreadyPrinted = true;
                            break;
                        }
                    }

                    // If not printed, print all persons from this city
                    if (!alreadyPrinted)
                    {
                        printedCities[cityCount++] = city;
                        Console.WriteLine("\nCity: " + city);

                        for (int x = 0; x < count; x++)
                        {
                            Contacts[] innerContacts = addressBooks[x].contacts;

                            for (int y = 0; y < innerContacts.Length; y++)
                            {
                                if (innerContacts[y] != null &&
                                    innerContacts[y].City == city)
                                {
                                    Console.WriteLine(innerContacts[y]);
                                    foundAny = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        if (!foundAny)
        {
            Console.WriteLine("No contacts found.");
        }
    }



}