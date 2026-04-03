namespace AddressBookSystem.Models;

public class ContactData
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Address { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string Zip { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string Email { get; set; } = "";

    public static ContactData FromContact(Contacts c)
    {
        return new ContactData
        {
            FirstName = c.FirstName,
            LastName = c.LastName,
            Address = c.Address,
            City = c.City,
            State = c.State,
            Zip = c.Zip,
            PhoneNumber = c.PhoneNumber,
            Email = c.Email
        };
    }

    public Contacts ToContact()
    {
        return new Contacts(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
    }
}
