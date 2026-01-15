class AddressBook
{
    //UC 06 : Ability to create multiple address books with unique names.
    public Contacts[] contacts {get ; set;}

    public string AddressBookName {get; set;}   

    public int AddressBookIdx {get; set;}
    public AddressBook(string name)
    {
        this.AddressBookName = name;
        contacts = new Contacts[20];
    } 

}