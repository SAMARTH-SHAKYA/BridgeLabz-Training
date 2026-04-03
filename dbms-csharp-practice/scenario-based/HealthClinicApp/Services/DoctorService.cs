using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinicApp.DBHelper;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Models;

namespace HealthClinicApp.Services;

public class DoctorService : IDoctorService
{
    private readonly DbConnectionFactory _connectionFactory;

    public DoctorService(DbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<List<Doctor>> GetAllDoctorsAsync()
    {
        var doctors = new List<Doctor>();
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            @"SELECT d.doctor_id, d.name, d.specialty_id, d.contact, d.consultation_fee, d.is_active, d.created_at,
                     s.specialty_name
              FROM Doctors d
              INNER JOIN Specialties s ON d.specialty_id = s.specialty_id
              WHERE d.is_active = 1
              ORDER BY d.name",
            (SqlConnection)connection);

        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            doctors.Add(new Doctor
            {
                DoctorId = reader.GetInt32(0),
                Name = reader.GetString(1),
                SpecialtyId = reader.GetInt32(2),
                Contact = reader.IsDBNull(3) ? null : reader.GetString(3),
                ConsultationFee = reader.GetDecimal(4),
                IsActive = reader.GetBoolean(5),
                CreatedAt = reader.GetDateTime(6),
                Specialty = new Specialty
                {
                    SpecialtyId = reader.GetInt32(2),
                    SpecialtyName = reader.GetString(7)
                }
            });
        }
        return doctors;
    }

    public async Task<Doctor?> GetDoctorByIdAsync(int doctorId)
    {
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            @"SELECT d.doctor_id, d.name, d.specialty_id, d.contact, d.consultation_fee, d.is_active, d.created_at,
                     s.specialty_name
              FROM Doctors d
              INNER JOIN Specialties s ON d.specialty_id = s.specialty_id
              WHERE d.doctor_id = @doctor_id",
            (SqlConnection)connection);
        command.Parameters.Add(DbHelper.CreateParameter("@doctor_id", doctorId));

        using var reader = await command.ExecuteReaderAsync();
        if (await reader.ReadAsync())
        {
            return new Doctor
            {
                DoctorId = reader.GetInt32(0),
                Name = reader.GetString(1),
                SpecialtyId = reader.GetInt32(2),
                Contact = reader.IsDBNull(3) ? null : reader.GetString(3),
                ConsultationFee = reader.GetDecimal(4),
                IsActive = reader.GetBoolean(5),
                CreatedAt = reader.GetDateTime(6),
                Specialty = new Specialty
                {
                    SpecialtyId = reader.GetInt32(2),
                    SpecialtyName = reader.GetString(7)
                }
            };
        }
        return null;
    }

    public async Task<List<Doctor>> GetDoctorsBySpecialtyAsync(int specialtyId)
    {
        var doctors = new List<Doctor>();
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            @"SELECT d.doctor_id, d.name, d.specialty_id, d.contact, d.consultation_fee, d.is_active, d.created_at,
                     s.specialty_name
              FROM Doctors d
              INNER JOIN Specialties s ON d.specialty_id = s.specialty_id
              WHERE d.specialty_id = @specialty_id AND d.is_active = 1
              ORDER BY d.name",
            (SqlConnection)connection);
        command.Parameters.Add(DbHelper.CreateParameter("@specialty_id", specialtyId));

        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            doctors.Add(new Doctor
            {
                DoctorId = reader.GetInt32(0),
                Name = reader.GetString(1),
                SpecialtyId = reader.GetInt32(2),
                Contact = reader.IsDBNull(3) ? null : reader.GetString(3),
                ConsultationFee = reader.GetDecimal(4),
                IsActive = reader.GetBoolean(5),
                CreatedAt = reader.GetDateTime(6),
                Specialty = new Specialty
                {
                    SpecialtyId = reader.GetInt32(2),
                    SpecialtyName = reader.GetString(7)
                }
            });
        }
        return doctors;
    }

    public async Task<List<Specialty>> GetAllSpecialtiesAsync()
    {
        var specialties = new List<Specialty>();
        using var connection = _connectionFactory.CreateConnection();
        await connection.OpenAsync();

        using var command = new SqlCommand(
            "SELECT specialty_id, specialty_name FROM Specialties ORDER BY specialty_name",
            (SqlConnection)connection);

        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            specialties.Add(new Specialty
            {
                SpecialtyId = reader.GetInt32(0),
                SpecialtyName = reader.GetString(1)
            });
        }
        return specialties;
    }
}

