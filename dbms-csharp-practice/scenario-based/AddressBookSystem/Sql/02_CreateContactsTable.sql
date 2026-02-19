-- =============================================
-- Create Contacts table for AddressBookSystem
-- Run after 01_CreateDatabase.sql (with USE AddressBookDb)
-- =============================================

USE AddressBookDb;
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'Contacts')
BEGIN
    CREATE TABLE dbo.Contacts
    (
        AddressBookName NVARCHAR(128) NOT NULL,
        FirstName       NVARCHAR(100) NOT NULL,
        LastName        NVARCHAR(100) NOT NULL,
        Address         NVARCHAR(500) NOT NULL,
        City            NVARCHAR(100) NOT NULL,
        State           NVARCHAR(100) NOT NULL,
        Zip             NVARCHAR(20)  NOT NULL,
        PhoneNumber     NVARCHAR(30)  NOT NULL,
        Email           NVARCHAR(256) NOT NULL
    );

    CREATE NONCLUSTERED INDEX IX_Contacts_AddressBookName
        ON dbo.Contacts (AddressBookName);

    PRINT 'Table dbo.Contacts created with index.';
END
ELSE
    PRINT 'Table dbo.Contacts already exists.';
GO
