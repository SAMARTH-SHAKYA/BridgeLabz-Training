public interface IAddressBook
{
    public AddressBook AddAddressBook(string name);

    public void SearchPersonByCity(AddressBook[] addressBooks, int count, string city);
}