using System;


class AddressMenu
{
    private IAddress addressBook;

    public void Menu(AddressBook book)
    {
        addressBook = new AddressUtilityIMPL();


        bool isTrue = true;

        while (isTrue)
        {
            Console.WriteLine("Press 1 : Add Contact");
            Console.WriteLine("Press 2 : Edit Contact");
            Console.WriteLine("Press 3 : Delete Contact");
            Console.WriteLine("Press 4 : Add Multiple Contacts");
            Console.WriteLine("Press 6 : Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Contacts newContact = addressBook.AddContact();

                    bool canAdd = addressBook.NoDuplicate(book.contacts, book.AddressBookIdx, newContact);

                    if (canAdd)
                    {
                        book.contacts[book.AddressBookIdx] = newContact;
                        book.AddressBookIdx++;
                        Console.WriteLine("Contact added successfully:");
                        Console.WriteLine(newContact.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Duplicate contact not added.");
                    }

                    break;

                case 2:
                    Console.WriteLine("Enter your first name to edit contact:");
                    string firstName = Console.ReadLine();
                    for (int i = 0; i < book.AddressBookIdx; i++)
                    {
                        if (book.contacts[i].FirstName.Equals(firstName))
                        {
                            addressBook.EditContact(book.contacts[i]);
                            Console.WriteLine("Contact updated successfully:");
                            Console.WriteLine(book.contacts[i].ToString());
                            break;
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter your first name to delete contact:");
                    string fname = Console.ReadLine();
                    for (int i = 0; i < book.AddressBookIdx; i++)
                    {
                        if (book.contacts[i].FirstName.Equals(fname))
                        {
                            Console.WriteLine(book.contacts[i].ToString());
                            addressBook.DeleteContact(book.contacts[i]);
                            Console.WriteLine("Contact deleted successfully.");

                            // Shift contacts to fill the gap
                            for (int j = i; j < book.AddressBookIdx - 1; j++)
                            {
                                book.contacts[j] = book.contacts[j + 1];
                            }
                            book.contacts[book.AddressBookIdx - 1] = null;
                            book.AddressBookIdx--;
                            break;
                        }
                    }
                    break;

                //UC 05 : Ability to add multiple contact persons to Address Book.
                case 4:
                    Console.Write("Enter number of contacts to add: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        book.contacts[book.AddressBookIdx] = addressBook.AddContact();
                        book.AddressBookIdx++;
                    }
                    break;



                case 5:
                    isTrue = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}