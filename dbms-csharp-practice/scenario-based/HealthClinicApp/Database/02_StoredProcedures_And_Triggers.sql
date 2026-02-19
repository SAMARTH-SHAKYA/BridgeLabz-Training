/* =====================================================
   HEALTH CLINIC DATABASE - STORED PROCEDURES & TRIGGERS
   Run this script SECOND in SSMS (after 01_Schema_And_Data.sql).
   Make sure "HealthClinicDB" is selected as the database.
   ===================================================== */

USE HealthClinicDB;
GO

/* =====================================================
   STORED PROCEDURES
   ===================================================== */

-- 1) Register New Patient
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

-- 2) Update Patient
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

-- 3) Book Appointment
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

-- 4) Cancel Appointment (With Transaction)
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

-- 5) Complete Visit (Insert Visit + Update Appointment)
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

-- 6) Add Prescription
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

-- 7) Generate Bill
CREATE OR ALTER PROCEDURE sp_GenerateBill
    @visit_id INT,
    @total_amount DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Bills(visit_id, total_amount)
    VALUES(@visit_id, @total_amount);
END
GO

-- 8) Record Payment (Transaction)
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

-- 9) Revenue Report
CREATE OR ALTER PROCEDURE sp_RevenueReport
    @start_date DATE,
    @end_date DATE
AS
BEGIN
    SELECT SUM(total_amount) AS TotalRevenue
    FROM Bills
    WHERE payment_status = 'PAID'
      AND payment_date BETWEEN @start_date AND @end_date;
END
GO

-- 10) View Outstanding Bills
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

PRINT 'Stored procedures and triggers created successfully.';
