using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinicApp.DBHelper;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Models;

namespace HealthClinicApp.Services;

public class VisitService : IVisitService
{
    private readonly DbConnectionFactory _connectionFactory;

    public VisitService(DbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<int> CompleteVisitAsync(int appointmentId, string diagnosis, string notes)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand("sp_CompleteVisit", (SqlConnection)connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add(DbHelper.CreateParameter("@appointment_id", appointmentId));
        command.Parameters.Add(DbHelper.CreateParameter("@diagnosis", diagnosis));
        command.Parameters.Add(DbHelper.CreateParameter("@notes", notes));

        await command.ExecuteNonQueryAsync();

        // Get the newly created visit ID
        using var selectCommand = new SqlCommand(
            "SELECT TOP 1 visit_id FROM Visits WHERE appointment_id = @appointment_id ORDER BY visit_id DESC",
            (SqlConnection)connection);
        selectCommand.Parameters.Add(DbHelper.CreateParameter("@appointment_id", appointmentId));
        
        var result = await selectCommand.ExecuteScalarAsync();
        return result != null ? Convert.ToInt32(result) : 0;
    }

    public async Task<bool> AddPrescriptionAsync(int visitId, string medicineName, string dosage, string duration)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand("sp_AddPrescription", (SqlConnection)connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add(DbHelper.CreateParameter("@visit_id", visitId));
        command.Parameters.Add(DbHelper.CreateParameter("@medicine_name", medicineName));
        command.Parameters.Add(DbHelper.CreateParameter("@dosage", dosage));
        command.Parameters.Add(DbHelper.CreateParameter("@duration", duration));

        var rowsAffected = await command.ExecuteNonQueryAsync();
        return rowsAffected > 0;
    }

    public async Task<List<Prescription>> GetPrescriptionsByVisitAsync(int visitId)
    {
        var prescriptions = new List<Prescription>();
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            "SELECT prescription_id, visit_id, medicine_name, dosage, duration FROM Prescriptions WHERE visit_id = @visit_id",
            (SqlConnection)connection);
        command.Parameters.Add(DbHelper.CreateParameter("@visit_id", visitId));

        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            prescriptions.Add(new Prescription
            {
                PrescriptionId = reader.GetInt32(0),
                VisitId = reader.GetInt32(1),
                MedicineName = reader.GetString(2),
                Dosage = reader.IsDBNull(3) ? null : reader.GetString(3),
                Duration = reader.IsDBNull(4) ? null : reader.GetString(4)
            });
        }
        return prescriptions;
    }

    public async Task<Visit?> GetVisitByIdAsync(int visitId)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            @"SELECT v.visit_id, v.appointment_id, v.diagnosis, v.notes, v.visit_date,
                     a.appointment_date, a.appointment_time
              FROM Visits v
              INNER JOIN Appointments a ON v.appointment_id = a.appointment_id
              WHERE v.visit_id = @visit_id",
            (SqlConnection)connection);
        command.Parameters.Add(DbHelper.CreateParameter("@visit_id", visitId));

        using var reader = await command.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return new Visit
            {
                VisitId = reader.GetInt32(0),
                AppointmentId = reader.GetInt32(1),
                Diagnosis = reader.IsDBNull(2) ? null : reader.GetString(2),
                Notes = reader.IsDBNull(3) ? null : reader.GetString(3),
                VisitDate = reader.GetDateTime(4),
                Appointment = new Appointment
                {
                    AppointmentDate = reader.GetDateTime(5),
                    AppointmentTime = reader.GetTimeSpan(6)
                }
            };
        }
        return null;
    }
}

