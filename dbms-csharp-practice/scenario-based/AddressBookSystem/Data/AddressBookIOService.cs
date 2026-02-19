using System.Collections.Generic;
using System.Threading.Tasks;
using AddressBookSystem.Models;

namespace AddressBookSystem.Data;

// UC 17: Ensure IO operations are async and do not block the main thread while doing CRUD on CSV, JSON, or JSONServer - all Load/Save use async Task
// UC 18: Supports multiple data sources (File, CSV, JSON, JSONServer, Database) via IAddressBookDataSource - Open/Close Principle, new source can be added without modifying existing code
public class AddressBookIOService
{
    private readonly Dictionary<string, IAddressBookDataSource> _sources = new();

    public AddressBookIOService()
    {
        _sources["file"] = new FileDataSource();
        _sources["csv"] = new CsvDataSource();
        _sources["json"] = new JsonDataSource();
        _sources["jsonserver"] = new JsonServerDataSource();
        _sources["db"] = new DatabaseDataSource();
        _sources["sqlserver"] = new SqlServerDataSource(SqlServerDataSource.DefaultConnectionString);
    }

    public IAddressBookDataSource GetSource(string type) => _sources[type.ToLowerInvariant()];

    public async Task<AddressBook> LoadAddressBookAsync(string sourceType, string pathOrId)
    {
        var source = GetSource(sourceType);
        var data = await source.LoadAsync(pathOrId);
        return data.ToAddressBook();
    }

    public async Task SaveAddressBookAsync(string sourceType, AddressBook book, string pathOrId)
    {
        var source = GetSource(sourceType);
        var data = AddressBookData.FromAddressBook(book);
        await source.SaveAsync(data, pathOrId);
    }
}
