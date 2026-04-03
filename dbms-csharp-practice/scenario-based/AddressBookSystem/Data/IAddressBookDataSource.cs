using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AddressBookSystem.Models;

namespace AddressBookSystem.Data;

// UC 18: Open/Close Principle - Interface for data sources so new sources can be added without modifying existing code
public interface IAddressBookDataSource
{
    Task<AddressBookData> LoadAsync(string pathOrId);
    Task SaveAsync(AddressBookData data, string pathOrId);
}

public class AddressBookData
{
    public string Name { get; set; } = "";
    public List<ContactData> Contacts { get; set; } = new List<ContactData>();

    public static AddressBookData FromAddressBook(AddressBook book)
    {
        var data = new AddressBookData { Name = book.AddressBookName };
        for (int i = 0; i < book.contacts.Length && book.contacts[i] != null; i++)
            data.Contacts.Add(ContactData.FromContact(book.contacts[i]));
        return data;
    }

    public AddressBook ToAddressBook()
    {
        var book = new AddressBook(Name);
        var arr = new Contacts[Math.Max(20, Contacts.Count + 5)];
        for (int i = 0; i < Contacts.Count; i++)
            arr[i] = Contacts[i].ToContact();
        book.SetContacts(arr);
        return book;
    }
}
