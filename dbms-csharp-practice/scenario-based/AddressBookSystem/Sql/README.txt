AddressBookSystem - SQL Server scripts for SSMS
===============================================

Run in SQL Server Management Studio (SSMS) in this order:

1. 01_CreateDatabase.sql   - Creates database "AddressBookDb"
2. 02_CreateContactsTable.sql - Creates table "Contacts" and index
3. 03_Optional_SampleData.sql - Optional sample row (edit and uncomment if needed)

Connection: Use Windows Authentication or SQL Server Authentication.
Default app connection string: Server=.;Database=AddressBookDb;Integrated Security=True;TrustServerCertificate=True;

For named instance: Server=.\SQLEXPRESS;Database=AddressBookDb;...
