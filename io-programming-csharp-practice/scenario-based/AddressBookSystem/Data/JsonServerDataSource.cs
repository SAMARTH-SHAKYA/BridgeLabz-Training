using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace AddressBookSystem.Data;

// UC 16: Ability to Read/Write Address Book with Persons Contact to a JSONServer using HttpClient (RESTAssured equivalent) - implemented LoadAsync/SaveAsync with HTTP GET/PUT to localhost:3000
public class JsonServerDataSource : IAddressBookDataSource
{
    private readonly HttpClient _httpClient;
    private const string BaseUrl = "http://localhost:3000";

    public JsonServerDataSource()
    {
        _httpClient = new HttpClient { BaseAddress = new Uri(BaseUrl) };
    }

    public async Task<AddressBookData> LoadAsync(string pathOrId)
    {
        var response = await _httpClient.GetAsync($"/addressBooks/{pathOrId}");
        if (!response.IsSuccessStatusCode)
            return new AddressBookData { Name = pathOrId };
        var json = await response.Content.ReadAsStringAsync();
        var data = JsonSerializer.Deserialize<AddressBookData>(json);
        return data ?? new AddressBookData { Name = pathOrId };
    }

    public async Task SaveAsync(AddressBookData data, string pathOrId)
    {
        data.Name = pathOrId;
        var response = await _httpClient.PutAsJsonAsync($"/addressBooks/{pathOrId}", data);
        response.EnsureSuccessStatusCode();
    }
}
