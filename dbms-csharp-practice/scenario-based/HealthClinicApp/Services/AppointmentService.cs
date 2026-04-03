using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinicApp.DBHelper;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Models;

namespace HealthClinicApp.Services;

public class AppointmentService : IAppointmentService
{
    private readonly DbConnectionFactory _connectionFactory;

    public AppointmentService(DbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<int> BookAppointmentAsync(int patientId, int doctorId, DateTime date, TimeSpan time)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand("sp_BookAppointment", (SqlConnection)connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add(DbHelper.CreateParameter("@patient_id", patientId));
        command.Parameters.Add(DbHelper.CreateParameter("@doctor_id", doctorId));
        command.Parameters.Add(DbHelper.CreateParameter("@date", SqlDbType.Date, date));
        command.Parameters.Add(DbHelper.CreateParameter("@time", SqlDbType.Time, time));

        await command.ExecuteNonQueryAsync();

        // Get the newly created appointment ID
        using var selectCommand = new SqlCommand(
            "SELECT TOP 1 appointment_id FROM Appointments WHERE patient_id = @patient_id AND doctor_id = @doctor_id ORDER BY appointment_id DESC",
            (SqlConnection)connection);
        selectCommand.Parameters.Add(DbHelper.CreateParameter("@patient_id", patientId));
        selectCommand.Parameters.Add(DbHelper.CreateParameter("@doctor_id", doctorId));
        
        var result = await selectCommand.ExecuteScalarAsync();
        return result != null ? Convert.ToInt32(result) : 0;
    }

    public async Task<bool> CancelAppointmentAsync(int appointmentId)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand("sp_CancelAppointment", (SqlConnection)connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add(DbHelper.CreateParameter("@appointment_id", appointmentId));

        var rowsAffected = await command.ExecuteNonQueryAsync();
        return rowsAffected > 0;
    }

    public async Task<List<Appointment>> GetAppointmentsByPatientAsync(int patientId)
    {
        var appointments = new List<Appointment>();
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            @"SELECT a.appointment_id, a.patient_id, a.doctor_id, a.appointment_date, a.appointment_time, a.status, a.created_at,
                     p.name as patient_name, d.name as doctor_name
              FROM Appointments a
              INNER JOIN Patients p ON a.patient_id = p.patient_id
              INNER JOIN Doctors d ON a.doctor_id = d.doctor_id
              WHERE a.patient_id = @patient_id
              ORDER BY a.appointment_date DESC, a.appointment_time DESC",
            (SqlConnection)connection);
        command.Parameters.Add(DbHelper.CreateParameter("@patient_id", patientId));

        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            appointments.Add(new Appointment
            {
                AppointmentId = reader.GetInt32(0),
                PatientId = reader.GetInt32(1),
                DoctorId = reader.GetInt32(2),
                AppointmentDate = reader.GetDateTime(3),
                AppointmentTime = reader.GetTimeSpan(4),
                Status = reader.GetString(5),
                CreatedAt = reader.GetDateTime(6),
                Patient = new Patient { Name = reader.GetString(7) },
                Doctor = new Doctor { Name = reader.GetString(8) }
            });
        }
        return appointments;
    }

    public async Task<List<Appointment>> GetAppointmentsByDoctorAsync(int doctorId)
    {
        var appointments = new List<Appointment>();
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            @"SELECT a.appointment_id, a.patient_id, a.doctor_id, a.appointment_date, a.appointment_time, a.status, a.created_at,
                     p.name as patient_name, d.name as doctor_name
              FROM Appointments a
              INNER JOIN Patients p ON a.patient_id = p.patient_id
              INNER JOIN Doctors d ON a.doctor_id = d.doctor_id
              WHERE a.doctor_id = @doctor_id
              ORDER BY a.appointment_date DESC, a.appointment_time DESC",
            (SqlConnection)connection);
        command.Parameters.Add(DbHelper.CreateParameter("@doctor_id", doctorId));

        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            appointments.Add(new Appointment
            {
                AppointmentId = reader.GetInt32(0),
                PatientId = reader.GetInt32(1),
                DoctorId = reader.GetInt32(2),
                AppointmentDate = reader.GetDateTime(3),
                AppointmentTime = reader.GetTimeSpan(4),
                Status = reader.GetString(5),
                CreatedAt = reader.GetDateTime(6),
                Patient = new Patient { Name = reader.GetString(7) },
                Doctor = new Doctor { Name = reader.GetString(8) }
            });
        }
        return appointments;
    }

    public async Task<Appointment?> GetAppointmentByIdAsync(int appointmentId)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            @"SELECT a.appointment_id, a.patient_id, a.doctor_id, a.appointment_date, a.appointment_time, a.status, a.created_at,
                     p.name as patient_name, d.name as doctor_name
              FROM Appointments a
              INNER JOIN Patients p ON a.patient_id = p.patient_id
              INNER JOIN Doctors d ON a.doctor_id = d.doctor_id
              WHERE a.appointment_id = @appointment_id",
            (SqlConnection)connection);
        command.Parameters.Add(DbHelper.CreateParameter("@appointment_id", appointmentId));

        using var reader = await command.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return new Appointment
            {
                AppointmentId = reader.GetInt32(0),
                PatientId = reader.GetInt32(1),
                DoctorId = reader.GetInt32(2),
                AppointmentDate = reader.GetDateTime(3),
                AppointmentTime = reader.GetTimeSpan(4),
                Status = reader.GetString(5),
                CreatedAt = reader.GetDateTime(6),
                Patient = new Patient { Name = reader.GetString(7) },
                Doctor = new Doctor { Name = reader.GetString(8) }
            };
        }
        return null;
    }

    public async Task<List<Appointment>> GetAllAppointmentsAsync()
    {
        var appointments = new List<Appointment>();
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            @"SELECT a.appointment_id, a.patient_id, a.doctor_id, a.appointment_date, a.appointment_time, a.status, a.created_at,
                     p.name as patient_name, d.name as doctor_name
              FROM Appointments a
              INNER JOIN Patients p ON a.patient_id = p.patient_id
              INNER JOIN Doctors d ON a.doctor_id = d.doctor_id
              ORDER BY a.appointment_date DESC, a.appointment_time DESC",
            (SqlConnection)connection);

        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            appointments.Add(new Appointment
            {
                AppointmentId = reader.GetInt32(0),
                PatientId = reader.GetInt32(1),
                DoctorId = reader.GetInt32(2),
                AppointmentDate = reader.GetDateTime(3),
                AppointmentTime = reader.GetTimeSpan(4),
                Status = reader.GetString(5),
                CreatedAt = reader.GetDateTime(6),
                Patient = new Patient { Name = reader.GetString(7) },
                Doctor = new Doctor { Name = reader.GetString(8) }
            });
        }
        return appointments;
    }
}

