using Microsoft.Data.Sqlite;
using System.Threading.Tasks;
using AddressBookSystem.Models;

namespace AddressBookSystem.Data;

// UC 18: Save Address Book to Database using SQLite, Open/Close Principle - new data source (Database) added without modifying CSV/JSON/JSONServer sources
public class DatabaseDataSource : IAddressBookDataSource
{
    private readonly string _dbPath;

    public DatabaseDataSource(string dbPath = "addressbook.db")
    {
        _dbPath = dbPath;
    }

    public async Task<AddressBookData> LoadAsync(string pathOrId)
    {
        await EnsureTablesAsync();
        var data = new AddressBookData { Name = pathOrId };
        await using var conn = new SqliteConnection($"Data Source={_dbPath}");
        await conn.OpenAsync();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email FROM Contacts WHERE AddressBookName = $name";
        cmd.Parameters.AddWithValue("$name", pathOrId);
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            data.Contacts.Add(new ContactData
            {
                FirstName = reader.GetString(0),
                LastName = reader.GetString(1),
                Address = reader.GetString(2),
                City = reader.GetString(3),
                State = reader.GetString(4),
                Zip = reader.GetString(5),
                PhoneNumber = reader.GetString(6),
                Email = reader.GetString(7)
            });
        }
        return data;
    }

    public async Task SaveAsync(AddressBookData data, string pathOrId)
    {
        await EnsureTablesAsync();
        await using var conn = new SqliteConnection($"Data Source={_dbPath}");
        await conn.OpenAsync();
        var deleteCmd = conn.CreateCommand();
        deleteCmd.CommandText = "DELETE FROM Contacts WHERE AddressBookName = $name";
        deleteCmd.Parameters.AddWithValue("$name", pathOrId);
        await deleteCmd.ExecuteNonQueryAsync();
        var insertCmd = conn.CreateCommand();
        insertCmd.CommandText = "INSERT INTO Contacts (AddressBookName, FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email) VALUES ($name, $fn, $ln, $addr, $city, $state, $zip, $phone, $email)";
        foreach (var c in data.Contacts)
        {
            insertCmd.Parameters.Clear();
            insertCmd.Parameters.AddWithValue("$name", pathOrId);
            insertCmd.Parameters.AddWithValue("$fn", c.FirstName);
            insertCmd.Parameters.AddWithValue("$ln", c.LastName);
            insertCmd.Parameters.AddWithValue("$addr", c.Address);
            insertCmd.Parameters.AddWithValue("$city", c.City);
            insertCmd.Parameters.AddWithValue("$state", c.State);
            insertCmd.Parameters.AddWithValue("$zip", c.Zip);
            insertCmd.Parameters.AddWithValue("$phone", c.PhoneNumber);
            insertCmd.Parameters.AddWithValue("$email", c.Email);
            await insertCmd.ExecuteNonQueryAsync();
        }
    }

    private async Task EnsureTablesAsync()
    {
        await using var conn = new SqliteConnection($"Data Source={_dbPath}");
        await conn.OpenAsync();
        var cmd = conn.CreateCommand();
        cmd.CommandText = "CREATE TABLE IF NOT EXISTS Contacts (AddressBookName TEXT, FirstName TEXT, LastName TEXT, Address TEXT, City TEXT, State TEXT, Zip TEXT, PhoneNumber TEXT, Email TEXT)";
        await cmd.ExecuteNonQueryAsync();
    }
}
