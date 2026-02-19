using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using AddressBookSystem.Models;

namespace AddressBookSystem.Data;

// UC 18: Open/Close Principle - New data source (SQL Server) added without modifying CSV/JSON/JSONServer/SQLite sources.
// Uses ADO.NET (Microsoft.Data.SqlClient) for CRUD: Load = SELECT, Save = DELETE + INSERT.
public class SqlServerDataSource : IAddressBookDataSource
{
    /// <summary>Default connection string after running Sql\01 and 02 in SSMS. Change for named instance (e.g. .\SQLEXPRESS).</summary>
    public const string DefaultConnectionString = "Server=.;Database=AddressBookDb;Integrated Security=True;TrustServerCertificate=True;";

    private readonly string _connectionString;

    public SqlServerDataSource(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<AddressBookData> LoadAsync(string pathOrId)
    {
        var data = new AddressBookData { Name = pathOrId };
        await using var conn = new SqlConnection(_connectionString);
        await conn.OpenAsync();
        const string sql = "SELECT FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email FROM dbo.Contacts WHERE AddressBookName = @name";
        await using var cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@name", pathOrId);
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
        await using var conn = new SqlConnection(_connectionString);
        await conn.OpenAsync();

        const string deleteSql = "DELETE FROM dbo.Contacts WHERE AddressBookName = @name";
        await using (var deleteCmd = new SqlCommand(deleteSql, conn))
        {
            deleteCmd.Parameters.AddWithValue("@name", pathOrId);
            await deleteCmd.ExecuteNonQueryAsync();
        }

        const string insertSql = "INSERT INTO dbo.Contacts (AddressBookName, FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email) VALUES (@name, @fn, @ln, @addr, @city, @state, @zip, @phone, @email)";
        foreach (var c in data.Contacts)
        {
            await using var insertCmd = new SqlCommand(insertSql, conn);
            insertCmd.Parameters.AddWithValue("@name", pathOrId);
            insertCmd.Parameters.AddWithValue("@fn", c.FirstName ?? "");
            insertCmd.Parameters.AddWithValue("@ln", c.LastName ?? "");
            insertCmd.Parameters.AddWithValue("@addr", c.Address ?? "");
            insertCmd.Parameters.AddWithValue("@city", c.City ?? "");
            insertCmd.Parameters.AddWithValue("@state", c.State ?? "");
            insertCmd.Parameters.AddWithValue("@zip", c.Zip ?? "");
            insertCmd.Parameters.AddWithValue("@phone", c.PhoneNumber ?? "");
            insertCmd.Parameters.AddWithValue("@email", c.Email ?? "");
            await insertCmd.ExecuteNonQueryAsync();
        }
    }
}
