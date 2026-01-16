public class AddressBook
{
    
    public Contacts[] contacts {get ; private set;}

    public string AddressBookName {get; private set;}   

    public int AddressBookIdx {get; private set;}
    public AddressBook(string name)
    {
        this.AddressBookName = name;
        contacts = new Contacts[20];
    } 


    public void SetContacts(Contacts[] contact)
    {
        this.contacts = contact;
    }

    public void SetAddressBookName(string name)
    {
        this.AddressBookName = name;
    }

    public void SetAddressBookIdx(int idx)
    {
        this.AddressBookIdx = idx;
    }
}