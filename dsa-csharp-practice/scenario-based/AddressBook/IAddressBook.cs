using System.Collections.Generic;

public interface IAddressBook
{
    public AddressBook AddAddressBook(string name);

    public void SearchPersonByCity(Dictionary<string, AddressBook> addressBooks, string city);

    void ViewPersonsByCity(Dictionary<string, AddressBook> addressBooks);

    void CountByCity(Dictionary<string, AddressBook> addressBooks);

    void CountByState(Dictionary<string, AddressBook> addressBooks);

    AddressBook SortContactsByName(AddressBook book);
}