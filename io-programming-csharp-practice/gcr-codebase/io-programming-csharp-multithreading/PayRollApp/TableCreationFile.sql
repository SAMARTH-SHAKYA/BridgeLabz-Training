CREATE DATABASE payroll_service;
GO

USE payroll_service;
GO

CREATE TABLE EmployeePayroll
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Salary FLOAT,
    StartDate DATETIME
);