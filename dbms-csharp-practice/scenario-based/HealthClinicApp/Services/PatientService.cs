using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinicApp.DBHelper;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Models;
using HealthClinicApp.Utilities;

namespace HealthClinicApp.Services;

public class PatientService : IPatientService
{
    private readonly DbConnectionFactory _connectionFactory;

    public PatientService(DbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<int> RegisterPatientAsync(Patient patient)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand("sp_RegisterPatient", (SqlConnection)connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add(DbHelper.CreateParameter("@name", patient.Name));
        command.Parameters.Add(DbHelper.CreateParameter("@dob", SqlDbType.Date, patient.Dob));
        command.Parameters.Add(DbHelper.CreateParameter("@contact", patient.Contact));
        command.Parameters.Add(DbHelper.CreateParameter("@email", patient.Email));
        command.Parameters.Add(DbHelper.CreateParameter("@address", patient.Address));
        command.Parameters.Add(DbHelper.CreateParameter("@blood_group", patient.BloodGroup));

        await command.ExecuteNonQueryAsync();

        // Get the newly created patient ID
        using var selectCommand = new SqlCommand(
            "SELECT TOP 1 patient_id FROM Patients WHERE contact = @contact ORDER BY patient_id DESC",
            (SqlConnection)connection);
        selectCommand.Parameters.Add(DbHelper.CreateParameter("@contact", patient.Contact));
        
        var result = await selectCommand.ExecuteScalarAsync();
        return result != null ? Convert.ToInt32(result) : 0;
    }

    public async Task<bool> UpdatePatientAsync(Patient patient)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand("sp_UpdatePatient", (SqlConnection)connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add(DbHelper.CreateParameter("@patient_id", patient.PatientId));
        command.Parameters.Add(DbHelper.CreateParameter("@name", patient.Name));
        command.Parameters.Add(DbHelper.CreateParameter("@dob", SqlDbType.Date, patient.Dob));
        command.Parameters.Add(DbHelper.CreateParameter("@contact", patient.Contact));
        command.Parameters.Add(DbHelper.CreateParameter("@email", patient.Email));
        command.Parameters.Add(DbHelper.CreateParameter("@address", patient.Address));
        command.Parameters.Add(DbHelper.CreateParameter("@blood_group", patient.BloodGroup));

        var rowsAffected = await command.ExecuteNonQueryAsync();
        return rowsAffected > 0;
    }

    public async Task<Patient?> GetPatientByIdAsync(int patientId)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            "SELECT patient_id, name, dob, contact, email, address, blood_group, created_at FROM Patients WHERE patient_id = @patient_id",
            (SqlConnection)connection);
        command.Parameters.Add(DbHelper.CreateParameter("@patient_id", patientId));

        using var reader = await command.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return new Patient
            {
                PatientId = reader.GetInt32(0),
                Name = reader.GetString(1),
                Dob = reader.GetDateTime(2),
                Contact = reader.GetString(3),
                Email = reader.IsDBNull(4) ? null : reader.GetString(4),
                Address = reader.IsDBNull(5) ? null : reader.GetString(5),
                BloodGroup = reader.IsDBNull(6) ? null : reader.GetString(6),
                CreatedAt = reader.GetDateTime(7)
            };
        }
        return null;
    }

    public async Task<List<Patient>> GetAllPatientsAsync()
    {
        var patients = new List<Patient>();
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            "SELECT patient_id, name, dob, contact, email, address, blood_group, created_at FROM Patients ORDER BY name",
            (SqlConnection)connection);

        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            patients.Add(new Patient
            {
                PatientId = reader.GetInt32(0),
                Name = reader.GetString(1),
                Dob = reader.GetDateTime(2),
                Contact = reader.GetString(3),
                Email = reader.IsDBNull(4) ? null : reader.GetString(4),
                Address = reader.IsDBNull(5) ? null : reader.GetString(5),
                BloodGroup = reader.IsDBNull(6) ? null : reader.GetString(6),
                CreatedAt = reader.GetDateTime(7)
            });
        }
        return patients;
    }

    public async Task<bool> DeletePatientAsync(int patientId)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            "DELETE FROM Patients WHERE patient_id = @patient_id",
            (SqlConnection)connection);
        command.Parameters.Add(DbHelper.CreateParameter("@patient_id", patientId));

        var rowsAffected = await command.ExecuteNonQueryAsync();
        return rowsAffected > 0;
    }
}

