Run these scripts in SQL Server Management Studio (SSMS) in order:

1. 01_Schema_And_Data.sql
   - Creates HealthClinicDB, all tables, indexes, and seed data (Specialties).
   - You can run it from any database context (e.g. master); it switches to HealthClinicDB.

2. 02_StoredProcedures_And_Triggers.sql
   - Creates all stored procedures and audit triggers.
   - Ensure "HealthClinicDB" is selected, or run as-is (script has USE HealthClinicDB).

After both complete, run the .NET console app; it uses ADO.NET and these procedures.
