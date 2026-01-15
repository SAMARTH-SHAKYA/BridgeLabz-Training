internal class Contacts
{
    //UC 01 : Created a Contact Class with the following properties.
    public string FirstName {get; private set;}
    public string LastName {get; private set;}

    public string Address {get; private set;}

    public string City {get; private set;}

    public string State {get; private set;}

    public string Zip {get; private set;}
    public string PhoneNumber {get; private set;}

    public string Email {get; private set;}

    public Contacts(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Address = address;
        this.City = city;
        this.State = state;
        this.Zip = zip;
        this.PhoneNumber = phoneNumber;
        Email = email;
    }

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Address: {Address}, City: {City}, State: {State}, Zip: {Zip}, Phone: {PhoneNumber}, Email: {Email}";
    }
}