DELETE FROM Students
-- Set current ID to "1"
-- If table already contains data, use "0"
-- If table is empty and never insert data, use "1"
-- Use SP https://github.com/reduardo7/TableTruncate
DBCC CHECKIDENT (Students, RESEED, 0);

Truncate table Bookings;