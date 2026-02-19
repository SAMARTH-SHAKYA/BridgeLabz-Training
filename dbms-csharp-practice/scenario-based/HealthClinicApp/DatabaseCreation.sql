USE HealthClinicDB;
GO

/* =====================================================
   STORED PROCEDURES
   ===================================================== */

---------------------------------------------------------
-- 1?? Register New Patient
---------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_RegisterPatient
    @name VARCHAR(100),
    @dob DATE,
    @contact VARCHAR(15),
    @email VARCHAR(100),
    @address VARCHAR(255),
    @blood_group VARCHAR(5)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Patients(name, dob, contact, email, address, blood_group)
    VALUES(@name, @dob, @contact, @email, @address, @blood_group);
END
GO


---------------------------------------------------------
-- 2?? Update Patient
---------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_UpdatePatient
    @patient_id INT,
    @name VARCHAR(100),
    @dob DATE,
    @contact VARCHAR(15),
    @email VARCHAR(100),
    @address VARCHAR(255),
    @blood_group VARCHAR(5)
AS
BEGIN
    UPDATE Patients
    SET name = @name,
        dob = @dob,
        contact = @contact,
        email = @email,
        address = @address,
        blood_group = @blood_group
    WHERE patient_id = @patient_id;
END
GO


---------------------------------------------------------
-- 3?? Book Appointment
---------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_BookAppointment
    @patient_id INT,
    @doctor_id INT,
    @date DATE,
    @time TIME
AS
BEGIN
    INSERT INTO Appointments(patient_id, doctor_id, appointment_date, appointment_time)
    VALUES(@patient_id, @doctor_id, @date, @time);
END
GO


---------------------------------------------------------
-- 4?? Cancel Appointment (With Transaction)
---------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_CancelAppointment
    @appointment_id INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE Appointments
        SET status = 'CANCELLED'
        WHERE appointment_id = @appointment_id;

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH
END
GO


---------------------------------------------------------
-- 5?? Complete Visit (Insert Visit + Update Appointment)
---------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_CompleteVisit
    @appointment_id INT,
    @diagnosis VARCHAR(255),
    @notes VARCHAR(500)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO Visits(appointment_id, diagnosis, notes)
        VALUES(@appointment_id, @diagnosis, @notes);

        UPDATE Appointments
        SET status = 'COMPLETED'
        WHERE appointment_id = @appointment_id;

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH
END
GO


---------------------------------------------------------
-- 6?? Add Prescription (Batch friendly)
---------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_AddPrescription
    @visit_id INT,
    @medicine_name VARCHAR(100),
    @dosage VARCHAR(50),
    @duration VARCHAR(50)
AS
BEGIN
    INSERT INTO Prescriptions(visit_id, medicine_name, dosage, duration)
    VALUES(@visit_id, @medicine_name, @dosage, @duration);
END
GO


---------------------------------------------------------
-- 7?? Generate Bill
---------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_GenerateBill
    @visit_id INT,
    @total_amount DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Bills(visit_id, total_amount)
    VALUES(@visit_id, @total_amount);
END
GO


---------------------------------------------------------
-- 8?? Record Payment (Transaction)
---------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_RecordPayment
    @bill_id INT,
    @amount DECIMAL(10,2),
    @payment_mode VARCHAR(50)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE Bills
        SET payment_status = 'PAID',
            payment_date = GETDATE(),
            payment_mode = @payment_mode
        WHERE bill_id = @bill_id;

        INSERT INTO Payment_Transactions(bill_id, amount)
        VALUES(@bill_id, @amount);

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH
END
GO


---------------------------------------------------------
-- 9?? Revenue Report
---------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_RevenueReport
    @start_date DATE,
    @end_date DATE
AS
BEGIN
    SELECT 
        SUM(total_amount) AS TotalRevenue
    FROM Bills
    WHERE payment_status = 'PAID'
      AND payment_date BETWEEN @start_date AND @end_date;
END
GO


---------------------------------------------------------
-- ?? View Outstanding Bills
---------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_OutstandingBills
AS
BEGIN
    SELECT 
        P.name,
        COUNT(B.bill_id) AS TotalBills,
        SUM(B.total_amount) AS TotalDue
    FROM Bills B
    INNER JOIN Visits V ON B.visit_id = V.visit_id
    INNER JOIN Appointments A ON V.appointment_id = A.appointment_id
    INNER JOIN Patients P ON A.patient_id = P.patient_id
    WHERE B.payment_status = 'UNPAID'
    GROUP BY P.name;
END
GO


/* =====================================================
   AUDIT TRIGGERS
   ===================================================== */

---------------------------------------------------------
-- Trigger for Patients
---------------------------------------------------------
CREATE OR ALTER TRIGGER trg_Patients_Audit
ON Patients
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO Audit_Log(table_name, operation, changed_by)
    SELECT 
        'Patients',
        CASE 
            WHEN EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted) THEN 'UPDATE'
            WHEN EXISTS (SELECT * FROM inserted) THEN 'INSERT'
            ELSE 'DELETE'
        END,
        SYSTEM_USER;
END
GO


---------------------------------------------------------
-- Trigger for Doctors
---------------------------------------------------------
CREATE OR ALTER TRIGGER trg_Doctors_Audit
ON Doctors
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO Audit_Log(table_name, operation, changed_by)
    SELECT 
        'Doctors',
        CASE 
            WHEN EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted) THEN 'UPDATE'
            WHEN EXISTS (SELECT * FROM inserted) THEN 'INSERT'
            ELSE 'DELETE'
        END,
        SYSTEM_USER;
END
GO


---------------------------------------------------------
-- Trigger for Appointments
---------------------------------------------------------
CREATE OR ALTER TRIGGER trg_Appointments_Audit
ON Appointments
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO Audit_Log(table_name, operation, changed_by)
    SELECT 
        'Appointments',
        CASE 
            WHEN EXISTS (SELECT * FROM inserted) AND EXISTS (SELECT * FROM deleted) THEN 'UPDATE'
            WHEN EXISTS (SELECT * FROM inserted) THEN 'INSERT'
            ELSE 'DELETE'
        END,
        SYSTEM_USER;
END
GO


PRINT 'Stored Procedures and Triggers Created Successfully!';

/* =====================================================
   HEALTH CLINIC DATABASE - COMPLETE SETUP SCRIPT
   ===================================================== */

-- 1?? Create Database
IF DB_ID('HealthClinicDB') IS NOT NULL
    DROP DATABASE HealthClinicDB;
GO

CREATE DATABASE HealthClinicDB;
GO

USE HealthClinicDB;
GO


/* =====================================================
   2?? SPECIALTIES TABLE
   ===================================================== */

CREATE TABLE Specialties (
    specialty_id INT IDENTITY(1,1) PRIMARY KEY,
    specialty_name VARCHAR(100) NOT NULL UNIQUE
);
GO


/* =====================================================
   3?? PATIENTS TABLE
   ===================================================== */

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


/* =====================================================
   4?? DOCTORS TABLE
   ===================================================== */

CREATE TABLE Doctors (
    doctor_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    specialty_id INT NOT NULL,
    contact VARCHAR(15),
    consultation_fee DECIMAL(10,2) NOT NULL,
    is_active BIT DEFAULT 1,
    created_at DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_Doctor_Specialty
    FOREIGN KEY (specialty_id)
    REFERENCES Specialties(specialty_id)
);
GO


/* =====================================================
   5?? APPOINTMENTS TABLE
   ===================================================== */

CREATE TABLE Appointments (
    appointment_id INT IDENTITY(1,1) PRIMARY KEY,
    patient_id INT NOT NULL,
    doctor_id INT NOT NULL,
    appointment_date DATE NOT NULL,
    appointment_time TIME NOT NULL,
    status VARCHAR(20) DEFAULT 'SCHEDULED',
    created_at DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_Appointments_Patient
    FOREIGN KEY (patient_id)
    REFERENCES Patients(patient_id),

    CONSTRAINT FK_Appointments_Doctor
    FOREIGN KEY (doctor_id)
    REFERENCES Doctors(doctor_id)
);
GO


/* =====================================================
   6?? VISITS TABLE
   ===================================================== */

CREATE TABLE Visits (
    visit_id INT IDENTITY(1,1) PRIMARY KEY,
    appointment_id INT NOT NULL,
    diagnosis VARCHAR(255),
    notes VARCHAR(500),
    visit_date DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_Visit_Appointment
    FOREIGN KEY (appointment_id)
    REFERENCES Appointments(appointment_id)
);
GO


/* =====================================================
   7?? PRESCRIPTIONS TABLE
   ===================================================== */

CREATE TABLE Prescriptions (
    prescription_id INT IDENTITY(1,1) PRIMARY KEY,
    visit_id INT NOT NULL,
    medicine_name VARCHAR(100) NOT NULL,
    dosage VARCHAR(50),
    duration VARCHAR(50),

    CONSTRAINT FK_Prescription_Visit
    FOREIGN KEY (visit_id)
    REFERENCES Visits(visit_id)
);
GO


/* =====================================================
   8?? BILLS TABLE
   ===================================================== */

CREATE TABLE Bills (
    bill_id INT IDENTITY(1,1) PRIMARY KEY,
    visit_id INT NOT NULL,
    total_amount DECIMAL(10,2) NOT NULL,
    payment_status VARCHAR(20) DEFAULT 'UNPAID',
    payment_date DATETIME NULL,
    payment_mode VARCHAR(50),
    created_at DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_Bill_Visit
    FOREIGN KEY (visit_id)
    REFERENCES Visits(visit_id)
);
GO


/* =====================================================
   9?? PAYMENT TRANSACTIONS TABLE
   ===================================================== */

CREATE TABLE Payment_Transactions (
    transaction_id INT IDENTITY(1,1) PRIMARY KEY,
    bill_id INT NOT NULL,
    amount DECIMAL(10,2) NOT NULL,
    transaction_date DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_Transaction_Bill
    FOREIGN KEY (bill_id)
    REFERENCES Bills(bill_id)
);
GO


/* =====================================================
   ?? AUDIT LOG TABLE
   ===================================================== */

CREATE TABLE Audit_Log (
    log_id INT IDENTITY(1,1) PRIMARY KEY,
    table_name VARCHAR(100),
    operation VARCHAR(20),
    changed_by VARCHAR(100),
    change_time DATETIME DEFAULT GETDATE()
);
GO


/* =====================================================
   1??1?? PERFORMANCE INDEXES
   ===================================================== */

CREATE INDEX IDX_Patient_Name
ON Patients(name);

CREATE INDEX IDX_Doctor_Specialty
ON Doctors(specialty_id);

CREATE INDEX IDX_Appointment_Date
ON Appointments(appointment_date);

CREATE INDEX IDX_Bill_Status
ON Bills(payment_status);
GO


/* =====================================================
   1??2?? INSERT DEFAULT SPECIALTIES
   ===================================================== */

INSERT INTO Specialties (specialty_name)
VALUES
('Cardiology'),
('Dermatology'),
('Neurology'),
('Orthopedics'),
('Pediatrics');
GO


/* =====================================================
   ? DATABASE SETUP COMPLETE
   ===================================================== */
PRINT 'HealthClinicDB created successfully!';




