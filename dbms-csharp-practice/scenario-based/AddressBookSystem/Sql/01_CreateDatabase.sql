-- =============================================
-- AddressBookSystem - SQL Server Database Setup
-- Run this script in SSMS (SQL Server Management Studio)
-- =============================================

-- Create database (change path if needed for your SQL Server instance)
USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'AddressBookDb')
BEGIN
    CREATE DATABASE AddressBookDb;
    PRINT 'Database AddressBookDb created.';
END
ELSE
    PRINT 'Database AddressBookDb already exists.';
GO

USE AddressBookDb;
GO
