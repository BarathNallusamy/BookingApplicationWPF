select BookingID, FirstName+' '+LastName AS 'FullName', Email, CourseName , CoursePrice, BookingStatus  from
Bookings b
join Students s on b.StudentID = s.StudentID
join Courses c on b.CourseID = c.CourseID;