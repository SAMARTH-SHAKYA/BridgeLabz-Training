using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinicApp.DBHelper;
using HealthClinicApp.DTOs;
using HealthClinicApp.Interfaces;

namespace HealthClinicApp.Services;

public class AdminService : IAdminService
{
    private readonly DbConnectionFactory _connectionFactory;

    public AdminService(DbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<decimal> GetRevenueReportAsync(DateTime startDate, DateTime endDate)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand("sp_RevenueReport", (SqlConnection)connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add(DbHelper.CreateParameter("@start_date", SqlDbType.Date, startDate));
        command.Parameters.Add(DbHelper.CreateParameter("@end_date", SqlDbType.Date, endDate));

        var result = await command.ExecuteScalarAsync();
        return result != null && result != DBNull.Value ? Convert.ToDecimal(result) : 0;
    }

    public async Task<List<OutstandingBillDTO>> GetOutstandingBillsReportAsync()
    {
        var outstandingBills = new List<OutstandingBillDTO>();
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand("sp_OutstandingBills", (SqlConnection)connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            outstandingBills.Add(new OutstandingBillDTO
            {
                PatientName = reader.GetString(0),
                TotalBills = reader.GetInt32(1),
                TotalDue = reader.GetDecimal(2)
            });
        }
        return outstandingBills;
    }
}

