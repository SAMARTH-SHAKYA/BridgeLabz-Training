using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinicApp.DBHelper;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Models;

namespace HealthClinicApp.Services;

public class BillingService : IBillingService
{
    private readonly DbConnectionFactory _connectionFactory;

    public BillingService(DbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<int> GenerateBillAsync(int visitId, decimal totalAmount)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand("sp_GenerateBill", (SqlConnection)connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add(DbHelper.CreateParameter("@visit_id", visitId));
        command.Parameters.Add(DbHelper.CreateParameter("@total_amount", totalAmount));

        await command.ExecuteNonQueryAsync();

        // Get the newly created bill ID
        using var selectCommand = new SqlCommand(
            "SELECT TOP 1 bill_id FROM Bills WHERE visit_id = @visit_id ORDER BY bill_id DESC",
            (SqlConnection)connection);
        selectCommand.Parameters.Add(DbHelper.CreateParameter("@visit_id", visitId));
        
        var result = await selectCommand.ExecuteScalarAsync();
        return result != null ? Convert.ToInt32(result) : 0;
    }

    public async Task<bool> RecordPaymentAsync(int billId, decimal amount, string paymentMode)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand("sp_RecordPayment", (SqlConnection)connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add(DbHelper.CreateParameter("@bill_id", billId));
        command.Parameters.Add(DbHelper.CreateParameter("@amount", amount));
        command.Parameters.Add(DbHelper.CreateParameter("@payment_mode", paymentMode));

        var rowsAffected = await command.ExecuteNonQueryAsync();
        return rowsAffected > 0;
    }

    public async Task<List<Bill>> GetBillsByVisitAsync(int visitId)
    {
        var bills = new List<Bill>();
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            "SELECT bill_id, visit_id, total_amount, payment_status, payment_date, payment_mode, created_at FROM Bills WHERE visit_id = @visit_id",
            (SqlConnection)connection);
        command.Parameters.Add(DbHelper.CreateParameter("@visit_id", visitId));

        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            bills.Add(new Bill
            {
                BillId = reader.GetInt32(0),
                VisitId = reader.GetInt32(1),
                TotalAmount = reader.GetDecimal(2),
                PaymentStatus = reader.GetString(3),
                PaymentDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                PaymentMode = reader.IsDBNull(5) ? null : reader.GetString(5),
                CreatedAt = reader.GetDateTime(6)
            });
        }
        return bills;
    }

    public async Task<Bill?> GetBillByIdAsync(int billId)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            "SELECT bill_id, visit_id, total_amount, payment_status, payment_date, payment_mode, created_at FROM Bills WHERE bill_id = @bill_id",
            (SqlConnection)connection);
        command.Parameters.Add(DbHelper.CreateParameter("@bill_id", billId));

        using var reader = await command.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return new Bill
            {
                BillId = reader.GetInt32(0),
                VisitId = reader.GetInt32(1),
                TotalAmount = reader.GetDecimal(2),
                PaymentStatus = reader.GetString(3),
                PaymentDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                PaymentMode = reader.IsDBNull(5) ? null : reader.GetString(5),
                CreatedAt = reader.GetDateTime(6)
            };
        }
        return null;
    }

    public async Task<List<Bill>> GetOutstandingBillsAsync()
    {
        var bills = new List<Bill>();
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            @"SELECT b.bill_id, b.visit_id, b.total_amount, b.payment_status, b.payment_date, b.payment_mode, b.created_at,
                     p.name as patient_name
              FROM Bills b
              INNER JOIN Visits v ON b.visit_id = v.visit_id
              INNER JOIN Appointments a ON v.appointment_id = a.appointment_id
              INNER JOIN Patients p ON a.patient_id = p.patient_id
              WHERE b.payment_status = 'UNPAID'
              ORDER BY b.created_at DESC",
            (SqlConnection)connection);

        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            bills.Add(new Bill
            {
                BillId = reader.GetInt32(0),
                VisitId = reader.GetInt32(1),
                TotalAmount = reader.GetDecimal(2),
                PaymentStatus = reader.GetString(3),
                PaymentDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                PaymentMode = reader.IsDBNull(5) ? null : reader.GetString(5),
                CreatedAt = reader.GetDateTime(6),
                Visit = new Visit
                {
                    Appointment = new Appointment
                    {
                        Patient = new Patient { Name = reader.GetString(7) }
                    }
                }
            });
        }
        return bills;
    }
}

