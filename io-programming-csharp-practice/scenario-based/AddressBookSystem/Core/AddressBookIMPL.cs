using System;
using System.Collections.Generic;
using AddressBookSystem.Models;

namespace AddressBookSystem.Core;

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

    //Ability to view Persons by City or State
    public void ViewPersonsByCity(AddressBook[] addressBooks, int count)
    {
        HashSet<string> printedCities = new HashSet<string>();

        bool foundAny = false;

        for (int i = 0; i < count; i++)
        {
            Contacts[] contacts = addressBooks[i].contacts;

            for (int j = 0; j < contacts.Length; j++)
            {
                if (contacts[j] != null)
                {
                    string city = contacts[j].City;

                    if (!printedCities.Contains(city))
                    {
                        printedCities.Add(city);
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

    //ability to get number of contact persons
    public void CountByCity(AddressBook[] addressBooks, int count)
    {
        Dictionary<string, int> cityCounts = new Dictionary<string, int>();

        for (int i = 0; i < count; i++)
        {
            Contacts[] contacts = addressBooks[i].contacts;

            for (int j = 0; j < contacts.Length; j++)
            {
                if (contacts[j] != null)
                {
                    string city = contacts[j].City;
                    if (cityCounts.ContainsKey(city))
                        cityCounts[city]++;
                    else
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

    public void CountByState(AddressBook[] addressBooks, int count)
    {
        Dictionary<string, int> stateCounts = new Dictionary<string, int>();

        for (int i = 0; i < count; i++)
        {
            Contacts[] contacts = addressBooks[i].contacts;

            for (int j = 0; j < contacts.Length; j++)
            {
                if (contacts[j] != null)
                {
                    string state = contacts[j].State;
                    if (stateCounts.ContainsKey(state))
                        stateCounts[state]++;
                    else
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
        Contacts[] contacts = book.contacts;

        int n = 0;
        while (n < contacts.Length && contacts[n] != null)
            n++;

        // Bubble Sort (Alphabetical by First Name)
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (string.Compare(contacts[j].FirstName, contacts[j + 1].FirstName, true) > 0)
                {
                    Contacts temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }

        book.SetContacts(contacts);
        return book;
    }


}
