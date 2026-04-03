using System.Collections.Generic;

public class AddressBook
{
    //created address book class
    public Dictionary<string, Contacts> contacts {get ; private set;}

    public string AddressBookName {get; private set;}   

    public AddressBook(string name)
    {
        this.AddressBookName = name;
        contacts = new Dictionary<string, Contacts>();
    } 


    public void SetContacts(Dictionary<string, Contacts> contact)
    {
        this.contacts = contact;
    }

    public void SetAddressBookName(string name)
    {
        this.AddressBookName = name;
    }
}