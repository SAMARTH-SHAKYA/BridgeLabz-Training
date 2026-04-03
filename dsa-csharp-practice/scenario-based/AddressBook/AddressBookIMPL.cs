using System;
using System.Collections.Generic;
using System.Linq;

public class AddressBookIMPL : IAddressBook
{
    private AddressBook addressBook;
    public AddressBook AddAddressBook(string name)
    {
        addressBook = new AddressBook(name);
        return addressBook;
    }

    public void SearchPersonByCity(Dictionary<string, AddressBook> addressBooks, string city)
    {
        bool found = false;

        foreach (var book in addressBooks.Values)
        {
            foreach (var contact in book.contacts.Values)
            {
                if (contact.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found in Address Book: {book.AddressBookName}");
                    Console.WriteLine(contact);
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No person found in this city.");
        }
    }

    //Ability to view Persons by City or State
    public void ViewPersonsByCity(Dictionary<string, AddressBook> addressBooks)
    {
        HashSet<string> printedCities = new HashSet<string>();
        bool foundAny = false;

        foreach (var book in addressBooks.Values)
        {
            foreach (var contact in book.contacts.Values)
            {
                string city = contact.City;

                // Check if this city is already printed
                if (!printedCities.Contains(city))
                {
                    printedCities.Add(city);
                    Console.WriteLine("\nCity: " + city);

                    foreach (var innerBook in addressBooks.Values)
                    {
                        foreach (var innerContact in innerBook.contacts.Values)
                        {
                            if (innerContact.City == city)
                            {
                                Console.WriteLine(innerContact);
                                foundAny = true;
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

    //ability to get number of contact persons
    public void CountByCity(Dictionary<string, AddressBook> addressBooks)
    {
        Dictionary<string, int> cityCounts = new Dictionary<string, int>();

        foreach (var book in addressBooks.Values)
        {
            foreach (var contact in book.contacts.Values)
            {
                string city = contact.City;
                if (cityCounts.ContainsKey(city))
                {
                    cityCounts[city]++;
                }
                else
                {
                    cityCounts[city] = 1;
                }
            }
        }

        Console.WriteLine("\n--- Count By City ---");
        foreach (var kvp in cityCounts)
        {
            Console.WriteLine(kvp.Key + " → " + kvp.Value);
        }

        if (cityCounts.Count == 0)
            Console.WriteLine("No contacts found.");
    }

    public void CountByState(Dictionary<string, AddressBook> addressBooks)
    {
        Dictionary<string, int> stateCounts = new Dictionary<string, int>();

        foreach (var book in addressBooks.Values)
        {
            foreach (var contact in book.contacts.Values)
            {
                string state = contact.State;
                if (stateCounts.ContainsKey(state))
                {
                    stateCounts[state]++;
                }
                else
                {
                    stateCounts[state] = 1;
                }
            }
        }

        Console.WriteLine("\n--- Count By State ---");
        foreach (var kvp in stateCounts)
        {
            Console.WriteLine(kvp.Key + " → " + kvp.Value);
        }

        if (stateCounts.Count == 0)
            Console.WriteLine("No contacts found.");
    }


    //Ability to get number of contact persons i.e. count by City or State - Search Result
    public AddressBook SortContactsByName(AddressBook book)
    {
        var sortedContacts = book.contacts.OrderBy(x => x.Value.FirstName).ToDictionary(x => x.Key, x => x.Value);
        book.SetContacts(sortedContacts);
        return book;
    }
}