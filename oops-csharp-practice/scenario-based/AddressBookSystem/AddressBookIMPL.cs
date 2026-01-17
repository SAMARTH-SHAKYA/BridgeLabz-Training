
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

    public void CountByCity(AddressBook[] addressBooks, int count)
    {
        string[] cities = new string[100];
        int[] cityCounts = new int[100];
        int cityIndex = 0;

        for (int i = 0; i < count; i++)
        {
            Contacts[] contacts = addressBooks[i].contacts;

            for (int j = 0; j < contacts.Length; j++)
            {
                if (contacts[j] != null)
                {
                    string city = contacts[j].City;
                    bool found = false;

                    for (int k = 0; k < cityIndex; k++)
                    {
                        if (cities[k] == city)
                        {
                            cityCounts[k]++;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        cities[cityIndex] = city;
                        cityCounts[cityIndex] = 1;
                        cityIndex++;
                    }
                }
            }
        }

        Console.WriteLine("\n--- Count By City ---");
        for (int i = 0; i < cityIndex; i++)
        {
            Console.WriteLine(cities[i] + " → " + cityCounts[i]);
        }

        if (cityIndex == 0)
            Console.WriteLine("No contacts found.");
    }

    public void CountByState(AddressBook[] addressBooks, int count)
    {
        string[] states = new string[100];
        int[] stateCounts = new int[100];
        int stateIndex = 0;

        for (int i = 0; i < count; i++)
        {
            Contacts[] contacts = addressBooks[i].contacts;

            for (int j = 0; j < contacts.Length; j++)
            {
                if (contacts[j] != null)
                {
                    string state = contacts[j].State;
                    bool found = false;

                    for (int k = 0; k < stateIndex; k++)
                    {
                        if (states[k] == state)
                        {
                            stateCounts[k]++;
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        states[stateIndex] = state;
                        stateCounts[stateIndex] = 1;
                        stateIndex++;
                    }
                }
            }
        }

        Console.WriteLine("\n--- Count By State ---");
        for (int i = 0; i < stateIndex; i++)
        {
            Console.WriteLine(states[i] + " → " + stateCounts[i]);
        }

        if (stateIndex == 0)
            Console.WriteLine("No contacts found.");
    }


}