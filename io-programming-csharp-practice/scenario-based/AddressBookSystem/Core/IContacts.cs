using AddressBookSystem.Models;

namespace AddressBookSystem.Core;

public interface IContacts
{
    public Contacts AddContact(string firstName,string lastName);

    public Contacts EditContacts(Contacts contact);

    public int FindContactIndex(Contacts[] contactArray,string firstName,int index);

    public Contacts[] DeleteContact(string firstName,Contacts[] contactArray,int index);
}
