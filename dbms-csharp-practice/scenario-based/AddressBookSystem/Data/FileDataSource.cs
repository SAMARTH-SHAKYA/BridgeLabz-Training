using System.IO;
using System.Text;
using System.Threading.Tasks;
using AddressBookSystem.Models;

namespace AddressBookSystem.Data;

// UC 13: Ability to Read/Write Address Book with Persons Contact into a File using C# File IO - implemented LoadAsync/SaveAsync with File.ReadAllLinesAsync and File.WriteAllTextAsync
public class FileDataSource : IAddressBookDataSource
{
    public async Task<AddressBookData> LoadAsync(string pathOrId)
    {
        var lines = await File.ReadAllLinesAsync(pathOrId);
        var data = new AddressBookData();
        if (lines.Length == 0) return data;
        data.Name = lines[0];
        for (int i = 1; i < lines.Length; i++)
        {
            var parts = lines[i].Split('|');
            if (parts.Length >= 8)
                data.Contacts.Add(new ContactData
                {
                    FirstName = parts[0],
                    LastName = parts[1],
                    Address = parts[2],
                    City = parts[3],
                    State = parts[4],
                    Zip = parts[5],
                    PhoneNumber = parts[6],
                    Email = parts[7]
                });
        }
        return data;
    }

    public async Task SaveAsync(AddressBookData data, string pathOrId)
    {
        var sb = new StringBuilder();
        sb.AppendLine(data.Name);
        foreach (var c in data.Contacts)
            sb.AppendLine($"{c.FirstName}|{c.LastName}|{c.Address}|{c.City}|{c.State}|{c.Zip}|{c.PhoneNumber}|{c.Email}");
        await File.WriteAllTextAsync(pathOrId, sb.ToString());
    }
}
