-- =============================================
-- Optional: Insert sample contact for testing
-- Run after 02_CreateContactsTable.sql
-- =============================================

USE AddressBookDb;
GO

-- Uncomment to insert a sample row:
/*
INSERT INTO dbo.Contacts
    (AddressBookName, FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email)
VALUES
    (N'Default', N'John', N'Doe', N'123 Main St', N'Mumbai', N'Maharashtra', N'400001', N'9876543210', N'john@example.com');
*/

PRINT 'Sample data script completed. Edit and uncomment INSERT to add test data.';
GO
