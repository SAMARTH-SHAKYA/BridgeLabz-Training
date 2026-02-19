using CsvHelper;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AddressBookSystem.Models;

namespace AddressBookSystem.Data;

// UC 14: Ability to Read/Write Address Book with Persons Contact as CSV File using CsvHelper (OpenCSV equivalent) - implemented LoadAsync/SaveAsync with CsvReader/CsvWriter
public class CsvDataSource : IAddressBookDataSource
{
    public async Task<AddressBookData> LoadAsync(string pathOrId)
    {
        using var reader = new StreamReader(pathOrId);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<ContactData>().ToList();
        var data = new AddressBookData();
        var pathName = Path.GetFileNameWithoutExtension(pathOrId);
        data.Name = pathName;
        data.Contacts = records;
        return await Task.FromResult(data);
    }

    public async Task SaveAsync(AddressBookData data, string pathOrId)
    {
        await using var writer = new StreamWriter(pathOrId);
        await using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        await csv.WriteRecordsAsync(data.Contacts);
    }
}
