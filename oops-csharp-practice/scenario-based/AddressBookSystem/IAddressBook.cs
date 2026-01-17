public interface IAddressBook
{
    public AddressBook AddAddressBook(string name);

    public void SearchPersonByCity(AddressBook[] addressBooks, int count, string city);

    void ViewPersonsByCity(AddressBook[] addressBooks, int count);

    void CountByCity(AddressBook[] addressBooks, int count);
    
    void CountByState(AddressBook[] addressBooks, int count);

}