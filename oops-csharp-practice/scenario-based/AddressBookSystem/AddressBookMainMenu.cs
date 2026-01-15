
using System;
using System.Collections.Generic;
class AddressBookMainMenu
{
    public void MainMenu()
    {

        //UC 06 : Ability to create multiple address books with unique names.
        
        Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();

        addressBooks.Add("Default", new AddressBook("Default"));

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Address Book Main Menu:");
            Console.WriteLine("1. Open Address Book");
            Console.WriteLine("2. Create New Address Book");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the name of the Address Book to open: ");
                    string bookName = Console.ReadLine();
                    if (addressBooks.ContainsKey(bookName))
                    {
                        AddressMenu addressMenu = new AddressMenu();
                        addressMenu.Menu(addressBooks[bookName]);
                    }
                    else
                    {
                        Console.WriteLine("Address Book not found.");
                    }
                    break;

                case 2:
                    Console.Write("Enter a name for the new Address Book: ");
                    string newBookName = Console.ReadLine();
                    if (!addressBooks.ContainsKey(newBookName))
                    {
                        addressBooks.Add(newBookName, new AddressBook(newBookName));
                        Console.WriteLine("Address Book created successfully.");
                    }
                    else
                    {
                        Console.WriteLine("An Address Book with that name already exists.");
                    }
                    break;

                case 3:
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}