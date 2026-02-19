using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace AddressBookSystem.Data;

// UC 15: Ability to Read/Write Address Book with Persons Contact as JSON File using System.Text.Json (GSON equivalent) - implemented LoadAsync/SaveAsync with JsonSerializer
public class JsonDataSource : IAddressBookDataSource
{
    private static readonly JsonSerializerOptions Options = new() { WriteIndented = true };

    public async Task<AddressBookData> LoadAsync(string pathOrId)
    {
        var json = await File.ReadAllTextAsync(pathOrId);
        var data = JsonSerializer.Deserialize<AddressBookData>(json);
        return data ?? new AddressBookData();
    }

    public async Task SaveAsync(AddressBookData data, string pathOrId)
    {
        var json = JsonSerializer.Serialize(data, Options);
        await File.WriteAllTextAsync(pathOrId, json);
    }
}
