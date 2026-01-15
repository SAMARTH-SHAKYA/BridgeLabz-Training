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
            Console.WriteLine("Press 3 : Exit");
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
                    isTrue = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}