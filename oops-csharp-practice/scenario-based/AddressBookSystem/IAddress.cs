internal interface IAddress
{
    public Contacts AddContact();
    public void EditContact(Contacts contact);
    public void DeleteContact(Contacts contact);
    
    public void NoDuplicate(Contacts contacts);
}