using System;


class AddressMenu
{
    private IAddress addressBook;

    public void Menu()
    {
        addressBook = new AddressUtilityIMPL();
        
        Contacts[] contacts = new Contacts[10];

        int idx = 0;
        bool isTrue = true;

        while (isTrue)
        {
            Console.WriteLine("Press 1 : Add Contact");
            Console.WriteLine("Press 2 : Edit Contact");
            Console.WriteLine("Press 3 : Delete Contact");
            Console.WriteLine("Press 4 : Add Multiple Contacts");
            Console.WriteLine("Press 5 : Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    contacts[idx] = addressBook.AddContact();
                    idx++;
                    break;

                case 2:
                    Console.WriteLine("Enter your first name to edit contact:");
                    string firstName = Console.ReadLine();
                    for(int i = 0; i < idx; i++)
                    {
                        if(contacts[i].FirstName.Equals(firstName))
                        {
                            addressBook.EditContact(contacts[i]);
                            Console.WriteLine("Contact updated successfully:");
                            Console.WriteLine(contacts[i].ToString());
                            break;
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter your first name to delete contact:");
                    string fname = Console.ReadLine();
                    for(int i = 0; i < idx; i++)
                    {
                        if(contacts[i].FirstName.Equals(fname))
                        {
                            Console.WriteLine(contacts[i].ToString());
                            addressBook.DeleteContact(contacts[i]);
                            Console.WriteLine("Contact deleted successfully.");
                            
                            // Shift contacts to fill the gap
                            for(int j = i; j < idx - 1; j++)
                            {
                                contacts[j] = contacts[j + 1];
                            }
                            contacts[idx - 1] = null;
                            idx--; 
                            break;
                        }
                    }
                    break;

                //UC 05 : Ability to add multiple contact persons to Address Book.
                case 4:
                    Console.Write("Enter number of contacts to add: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    for(int i = 0; i < n; i++)
                    {
                        contacts[idx] = addressBook.AddContact();
                        idx++;
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