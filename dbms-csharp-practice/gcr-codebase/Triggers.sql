-- Create Audit Table to store changes
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='EmployeeAudit' AND xtype='U')
BEGIN
    CREATE TABLE EmployeeAudit
    (
        AuditId INT PRIMARY KEY IDENTITY(1,1),
        EmployeeId INT,
        Name NVARCHAR(100),
        Gender NVARCHAR(10),
        Department NVARCHAR(100),
        Salary DECIMAL(10,2),
        ActionType NVARCHAR(10),   -- INSERT, UPDATE, DELETE
        ActionDate DATETIME DEFAULT GETDATE()
    )
END
GO


-- Trigger for INSERT
CREATE OR ALTER TRIGGER trg_AfterInsertEmployee
ON Employees
AFTER INSERT
AS
BEGIN
    INSERT INTO EmployeeAudit (EmployeeId, Name, Gender, Department, Salary, ActionType)
    SELECT Id, Name, Gender, Department, Salary, 'INSERT'
    FROM inserted
END
GO


-- Trigger for UPDATE
CREATE OR ALTER TRIGGER trg_AfterUpdateEmployee
ON Employees
AFTER UPDATE
AS
BEGIN
    INSERT INTO EmployeeAudit (EmployeeId, Name, Gender, Department, Salary, ActionType)
    SELECT Id, Name, Gender, Department, Salary, 'UPDATE'
    FROM inserted
END
GO


-- Trigger for DELETE
CREATE OR ALTER TRIGGER trg_AfterDeleteEmployee
ON Employees
AFTER DELETE
AS
BEGIN
    INSERT INTO EmployeeAudit (EmployeeId, Name, Gender, Department, Salary, ActionType)
    SELECT Id, Name, Gender, Department, Salary, 'DELETE'
    FROM deleted
END
GO


-- Example to test triggers

-- Insert
INSERT INTO Employees (Name, Gender, Department, Salary)
VALUES ('Samarth', 'Male', 'IT', 50000)

-- Update
UPDATE Employees
SET Salary = 60000
WHERE Id = 1

-- Delete
DELETE FROM Employees
WHERE Id = 1

-- Check audit table
SELECT * FROM EmployeeAudit