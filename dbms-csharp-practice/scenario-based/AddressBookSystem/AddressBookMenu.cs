using System;
using System.Threading.Tasks;
using AddressBookSystem.Core;
using AddressBookSystem.Data;
using AddressBookSystem.Models;

namespace AddressBookSystem;

public class AddressBookMenu
{
    private IAddressBook addressBookUtility;
    private IContacts contactsUtility;
    private AddressBookIOService ioService;

    public async Task MenuAsync()
    {
        //refactor to add multiple address book to the system
        addressBookUtility = new AddressBookIMPL();
        contactsUtility = new ContactsIMPL();
        ioService = new AddressBookIOService();

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
            Console.WriteLine("Press 4 : View persons by city");
            Console.WriteLine("Press 5 : Count persons by city");
            Console.WriteLine("Press 6 : Count persons by state");
            Console.WriteLine("Press 7 : Sort contacts alphabetically");
            Console.WriteLine("Press 8 : Save to File (UC 13) / Load from File (UC 13)");
            Console.WriteLine("Press 9 : Save to CSV (UC 14) / Load from CSV (UC 14)");
            Console.WriteLine("Press 10 : Save to JSON (UC 15) / Load from JSON (UC 15)");
            Console.WriteLine("Press 11 : Save to JSON Server (UC 16) / Load from JSON Server (UC 16)");
            Console.WriteLine("Press 12 : Save to Database (UC 18) / Load from Database (UC 18)");
            Console.WriteLine("Press 13 : Save to SQL Server / Load from SQL Server");


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
                    Console.WriteLine("Address Book closed.");
                    break;

                case 1:
                    Console.WriteLine("Enter your address book name you want to add");
                    string name = Console.ReadLine()?.Trim() ?? "";
                    if (string.IsNullOrEmpty(name)) { Console.WriteLine("Name cannot be empty."); break; }
                    bool nameExists = false;
                    for (int i = 0; i < AddressBookIndex; i++)
                    {
                        if (name == addressBookDatabase[i].AddressBookName)
                        {
                            Console.WriteLine("Same name of Address Book already exists.");
                            nameExists = true;
                            break;
                        }
                    }
                    if (!nameExists)
                    {
                        if (AddressBookIndex >= addressBookDatabase.Length) { Console.WriteLine("Maximum address books reached."); break; }
                        addressBookDatabase[AddressBookIndex] = addressBookUtility.AddAddressBook(name);
                        AddressBookIndex++;
                        Console.WriteLine($"Address book '{name}' added.");
                    }
                    break;


                case 2:
                    Console.WriteLine("Enter name of address book you want to open");
                    string nameOfBook = Console.ReadLine()?.Trim() ?? "";

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
                                            if (contactsArray[j] != null && contactsArray[j].FirstName == userFirstName && contactsArray[j].LastName == userLastName)
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

                case 8:
                    await HandleFileIO(addressBookDatabase, AddressBookIndex);
                    break;

                case 9:
                    await HandleCsvIO(addressBookDatabase, AddressBookIndex);
                    break;

                case 10:
                    await HandleJsonIO(addressBookDatabase, AddressBookIndex);
                    break;

                case 11:
                    await HandleJsonServerIO(addressBookDatabase, AddressBookIndex);
                    break;

                case 12:
                    await HandleDatabaseIO(addressBookDatabase, AddressBookIndex);
                    break;

                case 13:
                    await HandleSqlServerIO(addressBookDatabase, AddressBookIndex);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;

            }

        }
    }

    // UC 13: Read/Write Address Book using C# File IO
    private async Task HandleFileIO(AddressBook[] addressBookDatabase, int addressBookIndex)
    {
        Console.WriteLine("1=Save 2=Load");
        if (!int.TryParse(Console.ReadLine(), out int op)) { Console.WriteLine("Invalid input."); return; }
        Console.WriteLine("Enter address book name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter file path (e.g. data.txt):");
        string path = Console.ReadLine();
        if (op == 1)
        {
            var book = FindBook(addressBookDatabase, addressBookIndex, name);
            if (book != null) { await ioService.SaveAddressBookAsync("file", book, path); Console.WriteLine("Saved to file."); }
            else Console.WriteLine("Address book not found.");
        }
        else
        {
            var loaded = await ioService.LoadAddressBookAsync("file", path);
            Console.WriteLine($"Loaded from file.");
            PrintAddressBookToConsole(loaded);
        }
    }

    // UC 14: Read/Write Address Book as CSV using CsvHelper (OpenCSV equivalent)
    private async Task HandleCsvIO(AddressBook[] addressBookDatabase, int addressBookIndex)
    {
        Console.WriteLine("1=Save 2=Load");
        if (!int.TryParse(Console.ReadLine(), out int op)) { Console.WriteLine("Invalid input."); return; }
        Console.WriteLine("Enter address book name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter CSV file path (e.g. contacts.csv):");
        string path = Console.ReadLine();
        if (op == 1)
        {
            var book = FindBook(addressBookDatabase, addressBookIndex, name);
            if (book != null) { await ioService.SaveAddressBookAsync("csv", book, path); Console.WriteLine("Saved to CSV."); }
            else Console.WriteLine("Address book not found.");
        }
        else
        {
            var loaded = await ioService.LoadAddressBookAsync("csv", path);
            Console.WriteLine($"Loaded from CSV.");
            PrintAddressBookToConsole(loaded);
        }
    }

    // UC 15: Read/Write Address Book as JSON using System.Text.Json (GSON equivalent)
    private async Task HandleJsonIO(AddressBook[] addressBookDatabase, int addressBookIndex)
    {
        Console.WriteLine("1=Save 2=Load");
        if (!int.TryParse(Console.ReadLine(), out int op)) { Console.WriteLine("Invalid input."); return; }
        Console.WriteLine("Enter address book name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter JSON file path (e.g. contacts.json):");
        string path = Console.ReadLine();
        if (op == 1)
        {
            var book = FindBook(addressBookDatabase, addressBookIndex, name);
            if (book != null) { await ioService.SaveAddressBookAsync("json", book, path); Console.WriteLine("Saved to JSON."); }
            else Console.WriteLine("Address book not found.");
        }
        else
        {
            var loaded = await ioService.LoadAddressBookAsync("json", path);
            Console.WriteLine($"Loaded from JSON.");
            PrintAddressBookToConsole(loaded);
        }
    }

    // UC 16: Read/Write Address Book to JSONServer using HttpClient (RESTAssured equivalent)
    private async Task HandleJsonServerIO(AddressBook[] addressBookDatabase, int addressBookIndex)
    {
        Console.WriteLine("1=Save 2=Load. Ensure json-server is running on localhost:3000");
        if (!int.TryParse(Console.ReadLine(), out int op)) { Console.WriteLine("Invalid input."); return; }
        Console.WriteLine("Enter address book id:");
        string id = Console.ReadLine();
        if (op == 1)
        {
            var book = FindBook(addressBookDatabase, addressBookIndex, id);
            if (book != null)
            {
                try { await ioService.SaveAddressBookAsync("jsonserver", book, id); Console.WriteLine("Saved to JSON Server."); }
                catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
            }
            else Console.WriteLine("Address book not found.");
        }
        else
        {
            try
            {
                var loaded = await ioService.LoadAddressBookAsync("jsonserver", id);
                Console.WriteLine($"Loaded from JSON Server.");
                PrintAddressBookToConsole(loaded);
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
        }
    }

    // UC 18: Save/Load Address Book to Database, Open/Close Principle
    private async Task HandleDatabaseIO(AddressBook[] addressBookDatabase, int addressBookIndex)
    {
        Console.WriteLine("1=Save 2=Load");
        if (!int.TryParse(Console.ReadLine(), out int op)) { Console.WriteLine("Invalid input."); return; }
        Console.WriteLine("Enter address book name:");
        string name = Console.ReadLine();
        if (op == 1)
        {
            var book = FindBook(addressBookDatabase, addressBookIndex, name);
            if (book != null) { await ioService.SaveAddressBookAsync("db", book, name); Console.WriteLine("Saved to database."); }
            else Console.WriteLine("Address book not found.");
        }
        else
        {
            var loaded = await ioService.LoadAddressBookAsync("db", name);
            Console.WriteLine($"Loaded from database.");
            PrintAddressBookToConsole(loaded);
        }
    }

    // Save/Load Address Book to SQL Server (ADO.NET). Open/Close: new source only, no change to file/csv/json/jsonserver/db.
    private async Task HandleSqlServerIO(AddressBook[] addressBookDatabase, int addressBookIndex)
    {
        Console.WriteLine("1=Save 2=Load (ensure SQL Server is running and Sql scripts run in SSMS)");
        if (!int.TryParse(Console.ReadLine(), out int op)) { Console.WriteLine("Invalid input."); return; }
        Console.WriteLine("Enter address book name:");
        string name = Console.ReadLine();
        if (op == 1)
        {
            var book = FindBook(addressBookDatabase, addressBookIndex, name);
            if (book != null)
            {
                try { await ioService.SaveAddressBookAsync("sqlserver", book, name); Console.WriteLine("Saved to SQL Server."); }
                catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
            }
            else Console.WriteLine("Address book not found.");
        }
        else
        {
            try
            {
                var loaded = await ioService.LoadAddressBookAsync("sqlserver", name);
                Console.WriteLine($"Loaded from SQL Server.");
                PrintAddressBookToConsole(loaded);
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
        }
    }

    private AddressBook FindBook(AddressBook[] db, int count, string name)
    {
        for (int i = 0; i < count; i++)
            if (db[i].AddressBookName == name) return db[i];
        return null;
    }

    private void PrintAddressBookToConsole(AddressBook book)
    {
        if (book == null) return;
        Console.WriteLine($"--- Address Book: {book.AddressBookName} ---");
        int count = 0;
        for (int i = 0; i < book.contacts.Length && book.contacts[i] != null; i++)
        {
            Console.WriteLine($"  {i + 1}. {book.contacts[i]}");
            count++;
        }
        if (count == 0)
            Console.WriteLine("  (no contacts)");
        Console.WriteLine("---");
    }
}