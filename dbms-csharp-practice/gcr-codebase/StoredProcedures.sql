-- Create Employees table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Employees' AND xtype='U')
BEGIN
    CREATE TABLE Employees
    (
        Id INT PRIMARY KEY IDENTITY(1,1),   -- primary key
        Name NVARCHAR(100) NOT NULL,        -- employee name
        Gender NVARCHAR(10) NOT NULL,       -- gender
        Department NVARCHAR(100) NOT NULL,  -- department
        Salary DECIMAL(10,2) NOT NULL,      -- salary
        CreatedAt DATETIME DEFAULT GETDATE() -- created date
    )
END
GO


-- Insert employee
CREATE OR ALTER PROCEDURE sp_AddEmployee
    @Name NVARCHAR(100),
    @Gender NVARCHAR(10),
    @Department NVARCHAR(100),
    @Salary DECIMAL(10,2),
    @NewId INT OUTPUT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        INSERT INTO Employees (Name, Gender, Department, Salary)
        VALUES (@Name, @Gender, @Department, @Salary)

        SET @NewId = SCOPE_IDENTITY()

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT ERROR_MESSAGE()
    END CATCH
END
GO


-- Get all employees
CREATE OR ALTER PROCEDURE sp_GetAllEmployees
AS
BEGIN
    SELECT * FROM Employees
END
GO


-- Get employee by id
CREATE OR ALTER PROCEDURE sp_GetEmployeeById
    @Id INT
AS
BEGIN
    SELECT * FROM Employees WHERE Id = @Id
END
GO


-- Update employee
CREATE OR ALTER PROCEDURE sp_UpdateEmployee
    @Id INT,
    @Name NVARCHAR(100),
    @Gender NVARCHAR(10),
    @Department NVARCHAR(100),
    @Salary DECIMAL(10,2)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        UPDATE Employees
        SET Name = @Name,
            Gender = @Gender,
            Department = @Department,
            Salary = @Salary
        WHERE Id = @Id

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT ERROR_MESSAGE()
    END CATCH
END
GO


-- Delete employee
CREATE OR ALTER PROCEDURE sp_DeleteEmployee
    @Id INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        DELETE FROM Employees WHERE Id = @Id

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        PRINT ERROR_MESSAGE()
    END CATCH
END
GO


-- Sample execution

DECLARE @NewId INT

EXEC sp_AddEmployee 
    @Name = 'Samarth',
    @Gender = 'Male',
    @Department = 'IT',
    @Salary = 50000,
    @NewId = @NewId OUTPUT

PRINT @NewId

EXEC sp_GetAllEmployees

EXEC sp_GetEmployeeById 1

EXEC sp_UpdateEmployee 1, 'Samarth', 'Male', 'HR', 60000

EXEC sp_DeleteEmployee 1
