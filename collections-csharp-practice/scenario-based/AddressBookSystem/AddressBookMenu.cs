using System;
public class AddressBookMenu
{
    private IAddressBook addressBookUtility;
    private IContacts contactsUtility;

    public void Menu()
    {
        //refactor to add multiple address book to the system
        addressBookUtility = new AddressBookIMPL();
        contactsUtility = new ContactsIMPL();

        AddressBook[] addressBookDatabase = new AddressBook[10];
        addressBookDatabase[0] = new AddressBook("Default");
        int AddressBookIndex = 1;

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


            int choice;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

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
                    for (int i = 0; i < AddressBookIndex; i++)
                    {
                        if (name == addressBookDatabase[i].AddressBookName)
                        {
                            Console.WriteLine("Same name of Address Book exists");
                        }
                        else
                        {
                            addressBookDatabase[AddressBookIndex] = addressBookUtility.AddAddressBook(name);
                            AddressBookIndex++;
                        }
                    }
                    break;


                case 2:
                    Console.WriteLine("Enter name of address book you want to open");
                    string nameOfBook = Console.ReadLine();

                    bool found = false;

                    for (int i = 0; i < AddressBookIndex; i++)
                    {
                        if (nameOfBook == addressBookDatabase[i].AddressBookName)
                        {
                            found = true;

                            Contacts[] contactsArray = addressBookDatabase[i].contacts;
                            int index = 0;

                            // Find existing count
                            while (index < contactsArray.Length && contactsArray[index] != null)
                            {
                                index++;
                            }

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

                                int choiceForBook;
                                try
                                {
                                    choiceForBook = Convert.ToInt32(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid input. Please enter a number.");
                                    continue;
                                }

                                switch (choiceForBook)
                                {
                                    case 1:
                                        Console.WriteLine("Enter First name");
                                        string userFirstName = Console.ReadLine();
                                        Console.WriteLine("Enter Last name");
                                        string userLastName = Console.ReadLine();
                                        //ensuring that there is no duplicate entrt of the same person in a particular address book
                                        for (int j = 0; j < index; j++)
                                        {
                                            if (contactsArray[j] != null && contactsArray[j].FirstName == userFirstName && contactsArray[i].LastName == userLastName)
                                            {
                                                Console.WriteLine("Same name of person already exists");
                                                Console.WriteLine("Enter again");
                                                break;
                                            }
                                        }
                                        contactsArray[index] = contactsUtility.AddContact(userFirstName, userLastName);
                                        index++;
                                        break;

                                    case 2:
                                        Console.WriteLine("Enter your first name");
                                        string firstName = Console.ReadLine();
                                        int idx = contactsUtility.FindContactIndex(contactsArray, firstName, index);

                                        if (idx == -1)
                                        {
                                            Console.WriteLine("Record Not Found");
                                        }
                                        else
                                        {
                                            contactsArray[idx] = contactsUtility.EditContacts(contactsArray[idx]);
                                            Console.WriteLine("Updated contact:");
                                            Console.WriteLine(contactsArray[idx]);
                                        }
                                        break;

                                    case 3:
                                        Console.WriteLine("Enter your first name to delete");
                                        string firstNameDelete = Console.ReadLine();
                                        int deleteIdx = contactsUtility.FindContactIndex(contactsArray, firstNameDelete, index);
                                        if (deleteIdx == -1)
                                        {
                                            Console.WriteLine("Record Not Found");
                                        }
                                        else
                                        {
                                            contactsUtility.DeleteContact(firstNameDelete, contactsArray, index);
                                            index--;
                                            Console.WriteLine("Contact deleted");
                                        }
                                        break;


                                    //ability to add multiple person to address book
                                    case 4:
                                        Console.WriteLine("Enter number of contacts");
                                        int numOfContacts;
                                        try
                                        {
                                            numOfContacts = Convert.ToInt32(Console.ReadLine());
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Invalid input. Please enter a number.");
                                            break;
                                        }

                                        if (numOfContacts > contactsArray.Length - index)
                                        {
                                            Console.WriteLine($"Remaining space: {contactsArray.Length - index}");
                                        }
                                        else
                                        {
                                            while (numOfContacts > 0)
                                            {
                                                Console.WriteLine("Enter First name");
                                                string userFirstNameM = Console.ReadLine();

                                                Console.WriteLine("Enter Last name");
                                                string userLastNameM = Console.ReadLine();

                                                bool duplicate = false;

                                                for (int j = 0; j < index; j++)
                                                {
                                                    if (contactsArray[j] != null &&
                                                        contactsArray[j].FirstName == userFirstNameM &&
                                                        contactsArray[j].LastName == userLastNameM)
                                                    {
                                                        Console.WriteLine("Same person already exists. Enter again.");
                                                        duplicate = true;
                                                        break;
                                                    }
                                                }

                                                if (!duplicate)
                                                {
                                                    contactsArray[index] = contactsUtility.AddContact(userFirstNameM, userLastNameM);
                                                    index++;
                                                    numOfContacts--;
                                                }
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

                            addressBookDatabase[i].SetContacts(contactsArray);
                            break; // IMPORTANT
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Address book not found");
                    }

                    break;


                //check a person in every address book for a city
                case 3:
                    Console.WriteLine("Enter city name:");
                    string cityName = Console.ReadLine();

                    addressBookUtility.SearchPersonByCity(addressBookDatabase, AddressBookIndex, cityName);
                    break;


                //ability to view persons by city or state
                case 4:
                    addressBookUtility.ViewPersonsByCity(addressBookDatabase, AddressBookIndex);
                    break;


                //ability to get number of contact persons
                case 5:
                    addressBookUtility.CountByCity(addressBookDatabase, AddressBookIndex);
                    break;

                case 6:
                    addressBookUtility.CountByState(addressBookDatabase, AddressBookIndex);
                    break;

                
                case 7:
                    Console.WriteLine("Enter address book name to sort:");
                    string sortBookName = Console.ReadLine();

                    bool sortFound = false;

                    for (int i = 0; i < AddressBookIndex; i++)
                    {
                        if (addressBookDatabase[i].AddressBookName == sortBookName)
                        {
                            addressBookDatabase[i] =
                                addressBookUtility.SortContactsByName(addressBookDatabase[i]);

                            Console.WriteLine("Contacts sorted successfully!");
                            sortFound = true;
                            break;
                        }
                    }

                    if (!sortFound)
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