using System;


class AddressMenu
{
    private IAddress addressBook;

    public void Menu()
    {
        addressBook = new AddressUtilityIMPL();
        
        Contacts[] contacts = new Contacts[10];

        bool isTrue = true;

        while (isTrue)
        {
            Console.WriteLine("1. Add Contact");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    addressBook.AddContact();
                    break;
                case 2:
                    isTrue = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}