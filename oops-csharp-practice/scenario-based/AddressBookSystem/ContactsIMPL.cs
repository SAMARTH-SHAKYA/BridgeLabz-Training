using System;
public class ContactsIMPL : IContacts
{
    private Contacts contacts;

    //added a method to add contacts to the contacts array
    public Contacts AddContact(string firstName,string lastName)
    {
        Console.Write("Enter Address: ");
        string address = Console.ReadLine();
        Console.Write("Enter City: ");
        string city = Console.ReadLine();
        Console.Write("Enter State: ");
        string state = Console.ReadLine();
        Console.Write("Enter Zip: ");
        string zip = Console.ReadLine();
        Console.Write("Enter Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter Email: ");
        string email = Console.ReadLine();
        contacts = new Contacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
        Console.WriteLine("The data which you have entered has successfully added to contacts");
        Console.WriteLine(contacts.ToString());
        return contacts;
    }


    //this method will return the index which you want from the firstname
    public int FindContactIndex(Contacts[] contactArray, string firstName, int index)
    {
        for (int i = 0; i < index; i++)
        {
            if (contactArray[i] != null && contactArray[i].FirstName == firstName)
            {
                return i;
            }
        }
        return -1;
    }

    //method to delete contact from the contacts array
    public Contacts[] DeleteContact(string firstName,Contacts[] contactArray,int index)
    {
        int idx = FindContactIndex(contactArray,firstName,index);

        for(int i = idx; i < contactArray.Length-1; i++)
        {
            contactArray[i] = contactArray[i+1];
        }

        return contactArray;
    }

    //method to editcontacts in the contact array
    public Contacts EditContacts(Contacts contactToEdit)
    {
        contacts = contactToEdit;

        Console.WriteLine("Press 1 : To change First Name");
        Console.WriteLine("Press 2 : To change Last Name");
        Console.WriteLine("Press 3 : To change Address");
        Console.WriteLine("Press 4 : To change City");
        Console.WriteLine("Press 5 : To change State");
        Console.WriteLine("Press 6 : To change Zip");
        Console.WriteLine("Press 7 : To change PhoneNumber");
        Console.WriteLine("Press 8 : To change Email");


        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter new First Name: ");
                string firstName = Console.ReadLine();
                contacts.SetFirstName(firstName);
                break;
            case 2:
                Console.Write("Enter new Last Name: ");
                string lastName = Console.ReadLine();
                contacts.SetLastName(lastName);
                break;
            case 3:
                Console.Write("Enter new Address: ");
                string address = Console.ReadLine();
                contacts.SetAddress(address);
                break;
            case 4:
                Console.Write("Enter new City: ");
                string city = Console.ReadLine();
                contacts.SetCity(city);
                break;
            case 5:
                Console.Write("Enter new State: ");
                string state = Console.ReadLine();
                contacts.SetState(state);
                break;
            case 6:
                Console.Write("Enter new Zip: ");
                string zip = Console.ReadLine();
                contacts.SetZip(zip);
                break;
            case 7:
                Console.Write("Enter new Phone Number: ");
                string phoneNumber = Console.ReadLine();
                contacts.SetPhoneNumber(phoneNumber);
                break;
            case 8:
                Console.Write("Enter new Email: ");
                string email = Console.ReadLine();
                contacts.SetEmail(email);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        return contacts;
    }
}