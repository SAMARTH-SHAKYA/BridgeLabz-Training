/* =====================================================
   HEALTH CLINIC DATABASE - SCHEMA & SEED DATA
   Run this script FIRST in SSMS (e.g. on master or default DB).
   ===================================================== */

-- Create database (run in context of master or any DB)
IF DB_ID('HealthClinicDB') IS NOT NULL
    DROP DATABASE HealthClinicDB;
GO

CREATE DATABASE HealthClinicDB;
GO

USE HealthClinicDB;
GO

/* =====================================================
   TABLES
   ===================================================== */

CREATE TABLE Specialties (
    specialty_id INT IDENTITY(1,1) PRIMARY KEY,
    specialty_name VARCHAR(100) NOT NULL UNIQUE
);
GO

CREATE TABLE Patients (
    patient_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    dob DATE NOT NULL,
    contact VARCHAR(15) NOT NULL UNIQUE,
    email VARCHAR(100) UNIQUE,
    address VARCHAR(255),
    blood_group VARCHAR(5),
    created_at DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE Doctors (
    doctor_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    specialty_id INT NOT NULL,
    contact VARCHAR(15),
    consultation_fee DECIMAL(10,2) NOT NULL,
    is_active BIT DEFAULT 1,
    created_at DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Doctor_Specialty
    FOREIGN KEY (specialty_id) REFERENCES Specialties(specialty_id)
);
GO

CREATE TABLE Appointments (
    appointment_id INT IDENTITY(1,1) PRIMARY KEY,
    patient_id INT NOT NULL,
    doctor_id INT NOT NULL,
    appointment_date DATE NOT NULL,
    appointment_time TIME NOT NULL,
    status VARCHAR(20) DEFAULT 'SCHEDULED',
    created_at DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Appointments_Patient
    FOREIGN KEY (patient_id) REFERENCES Patients(patient_id),
    CONSTRAINT FK_Appointments_Doctor
    FOREIGN KEY (doctor_id) REFERENCES Doctors(doctor_id)
);
GO

CREATE TABLE Visits (
    visit_id INT IDENTITY(1,1) PRIMARY KEY,
    appointment_id INT NOT NULL,
    diagnosis VARCHAR(255),
    notes VARCHAR(500),
    visit_date DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Visit_Appointment
    FOREIGN KEY (appointment_id) REFERENCES Appointments(appointment_id)
);
GO

CREATE TABLE Prescriptions (
    prescription_id INT IDENTITY(1,1) PRIMARY KEY,
    visit_id INT NOT NULL,
    medicine_name VARCHAR(100) NOT NULL,
    dosage VARCHAR(50),
    duration VARCHAR(50),
    CONSTRAINT FK_Prescription_Visit
    FOREIGN KEY (visit_id) REFERENCES Visits(visit_id)
);
GO

CREATE TABLE Bills (
    bill_id INT IDENTITY(1,1) PRIMARY KEY,
    visit_id INT NOT NULL,
    total_amount DECIMAL(10,2) NOT NULL,
    payment_status VARCHAR(20) DEFAULT 'UNPAID',
    payment_date DATETIME NULL,
    payment_mode VARCHAR(50),
    created_at DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Bill_Visit
    FOREIGN KEY (visit_id) REFERENCES Visits(visit_id)
);
GO

CREATE TABLE Payment_Transactions (
    transaction_id INT IDENTITY(1,1) PRIMARY KEY,
    bill_id INT NOT NULL,
    amount DECIMAL(10,2) NOT NULL,
    transaction_date DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Transaction_Bill
    FOREIGN KEY (bill_id) REFERENCES Bills(bill_id)
);
GO

CREATE TABLE Audit_Log (
    log_id INT IDENTITY(1,1) PRIMARY KEY,
    table_name VARCHAR(100),
    operation VARCHAR(20),
    changed_by VARCHAR(100),
    change_time DATETIME DEFAULT GETDATE()
);
GO

/* =====================================================
   INDEXES
   ===================================================== */

CREATE INDEX IDX_Patient_Name ON Patients(name);
CREATE INDEX IDX_Doctor_Specialty ON Doctors(specialty_id);
CREATE INDEX IDX_Appointment_Date ON Appointments(appointment_date);
CREATE INDEX IDX_Bill_Status ON Bills(payment_status);
GO

/* =====================================================
   SEED DATA - Specialties
   ===================================================== */

INSERT INTO Specialties (specialty_name)
VALUES
('Cardiology'),
('Dermatology'),
('Neurology'),
('Orthopedics'),
('Pediatrics');
GO

PRINT 'HealthClinicDB schema and seed data created successfully.';
