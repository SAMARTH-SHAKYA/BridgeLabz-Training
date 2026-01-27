using System.Collections.Generic;

public interface IContacts
{
    public Contacts AddContact(string firstName,string lastName);

    public Contacts EditContacts(Contacts contact);

    public bool CheckContactExists(Dictionary<string, Contacts> contactsDict, string firstName);

    public void DeleteContact(string firstName, Dictionary<string, Contacts> contactsDict);
}