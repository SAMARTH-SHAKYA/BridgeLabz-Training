using System;
using System.Collections.Generic;

public class AddressBookMenu
{
    private IAddressBook addressBookUtility;
    private IContacts contactsUtility;

    public void Menu()
    {
        //refactor to add multiple address book to the system
        addressBookUtility = new AddressBookIMPL();
        contactsUtility = new ContactsIMPL();

        Dictionary<string, AddressBook> addressBookDatabase = new Dictionary<string, AddressBook>();
        addressBookDatabase.Add("Default", new AddressBook("Default"));

        bool isTrue = true;

        while (isTrue)
        {
            Console.WriteLine("Press 0 : To Exit");
            Console.WriteLine("Press 1 : To Add New Address Book");
            Console.WriteLine("Press 2 : To open Address Book");
            Console.WriteLine("Press 3 : To check person across city ");
            Console.WriteLine("Press 4 : Veiw persons by city");
            Console.WriteLine("Press 5 : Count persons by city");
            Console.WriteLine("Press 6 : Count persons by state");
            Console.WriteLine("Press 7 : Sort contacts alphabetically");


            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {

                case 0:
                    isTrue = false;
                    Console.WriteLine("Current Adress Book Closed");
                    break;

                case 1:
                    //each address book has a unique name
                    Console.WriteLine("Enter your address book name you want to add");
                    string name = Console.ReadLine();

                    if (addressBookDatabase.ContainsKey(name))
                    {
                        Console.WriteLine("Same name of Address Book exists");
                    }
                    else
                    {
                        addressBookDatabase.Add(name, addressBookUtility.AddAddressBook(name));
                    }
                    break;


                case 2:
                    Console.WriteLine("Enter name of address book you want to open");
                    string nameOfBook = Console.ReadLine();

                    if (addressBookDatabase.ContainsKey(nameOfBook))
                    {
                        Dictionary<string, Contacts> contactsDict = addressBookDatabase[nameOfBook].contacts;

                        bool exit = false;
                        while (!exit)
                        {
                            Console.WriteLine("Contacts Menu:");
                            Console.WriteLine("Press 1 : Add Contact");
                            Console.WriteLine("Press 2 : Edit Contact");
                            Console.WriteLine("Press 3 : Delete Contact");
                            Console.WriteLine("Press 4 : Add multiple contacts");
                            Console.WriteLine("5. Exit");
                            Console.Write("Enter your choice: ");

                            int choiceForBook = Convert.ToInt32(Console.ReadLine());

                            switch (choiceForBook)
                            {
                                case 1:
                                    Console.WriteLine("Enter First name");
                                    string userFirstName = Console.ReadLine();
                                    Console.WriteLine("Enter Last name");
                                    string userLastName = Console.ReadLine();
                                    //ensuring that there is no duplicate entrt of the same person in a particular address book
                                    if (contactsDict.ContainsKey(userFirstName))
                                    {
                                        Console.WriteLine("Same name of person already exists");
                                        Console.WriteLine("Enter again");
                                    }
                                    else
                                    {
                                        contactsDict.Add(userFirstName, contactsUtility.AddContact(userFirstName, userLastName));
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine("Enter your first name");
                                    string firstName = Console.ReadLine();
                                    
                                    if (!contactsUtility.CheckContactExists(contactsDict, firstName))
                                    {
                                        Console.WriteLine("Record Not Found");
                                    }
                                    else
                                    {
                                        Contacts contact = contactsDict[firstName];
                                        contactsDict[firstName] = contactsUtility.EditContacts(contact);
                                        Console.WriteLine("Updated contact:");
                                        Console.WriteLine(contactsDict[firstName]);
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("Enter your first name to delete");
                                    string firstNameDelete = Console.ReadLine();
                                    contactsUtility.DeleteContact(firstNameDelete, contactsDict);
                                    Console.WriteLine("Contact deleted");
                                    break;


                                //ability to add multiple person to address book
                                case 4:
                                    Console.WriteLine("Enter number of contacts");
                                    int numOfContacts = Convert.ToInt32(Console.ReadLine());

                                    while (numOfContacts > 0)
                                    {
                                        Console.WriteLine("Enter First name");
                                        string userFirstNameM = Console.ReadLine();

                                        Console.WriteLine("Enter Last name");
                                        string userLastNameM = Console.ReadLine();

                                        if (contactsDict.ContainsKey(userFirstNameM))
                                        {
                                            Console.WriteLine("Same person already exists. Enter again.");
                                        }
                                        else
                                        {
                                            contactsDict.Add(userFirstNameM, contactsUtility.AddContact(userFirstNameM, userLastNameM));
                                            numOfContacts--;
                                        }
                                    }
                                    break;


                                case 5:
                                    exit = true;
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice.");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Address book not found");
                    }
                    break;


                //check a person in every address book for a city
                case 3:
                    Console.WriteLine("Enter city name:");
                    string cityName = Console.ReadLine();

                    addressBookUtility.SearchPersonByCity(addressBookDatabase, cityName);
                    break;


                //ability to view persons by city or state
                case 4:
                    addressBookUtility.ViewPersonsByCity(addressBookDatabase);
                    break;


                //ability to get number of contact persons
                case 5:
                    addressBookUtility.CountByCity(addressBookDatabase);
                    break;

                case 6:
                    addressBookUtility.CountByState(addressBookDatabase);
                    break;

                
                case 7:
                    Console.WriteLine("Enter address book name to sort:");
                    string sortBookName = Console.ReadLine();

                    if (addressBookDatabase.ContainsKey(sortBookName))
                    {
                        addressBookDatabase[sortBookName] = addressBookUtility.SortContactsByName(addressBookDatabase[sortBookName]);
                        Console.WriteLine("Contacts sorted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Address Book not found.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;

            }

        }
    }
}