namespace AddressBookSystem.Models;

public class Contacts
{
    //Created a Contact Class with the following properties.
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public string Address { get; private set; }

    public string City { get; private set; }

    public string State { get; private set; }

    public string Zip { get; private set; }
    public string PhoneNumber { get; private set; }

    public string Email { get; private set; }

    //contructor of this class
    public Contacts(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Address = address;
        this.City = city;
        this.State = state;
        this.Zip = zip;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
    }

    //adding layers of setter 
    public void SetAddress(string address)
    {
        this.Address = address;
    }
    public void SetCity(string city)
    {
        this.City = city;
    }
    public void SetState(string state)
    {
        this.State = state;
    }
    public void SetZip(string zip)
    {
        this.Zip = zip;
    }
    public void SetPhoneNumber(string phoneNumber)
    {
        this.PhoneNumber = phoneNumber;
    }
    public void SetEmail(string email)
    {
        this.Email = email;
    }
    public void SetLastName(string lastName)
    {
        this.LastName = lastName;
    }

    public void SetFirstName(string firstName)
    {
        this.FirstName = firstName;
    }

    //overriding to string method 
    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Address: {Address}, City: {City}, State: {State}, Zip: {Zip}, Phone: {PhoneNumber}, Email: {Email}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is Contacts))
            return false;

        Contacts other = (Contacts)obj;

        return FirstName == other.FirstName &&
               LastName == other.LastName &&
               Address == other.Address &&
               City == other.City &&
               State == other.State &&
               Zip == other.Zip &&
               PhoneNumber == other.PhoneNumber &&
               Email == other.Email;
    }

    public override int GetHashCode()
    {
        return 0; // simple and valid
    }




}
