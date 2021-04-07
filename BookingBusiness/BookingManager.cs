using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking_ApplicationSystem;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BookingBusiness
{
    public class BookingManager
    {
        public Booking SelectedBooking { get; set; }

        public void Create(int studentID, int courseID, string selectedDate)
        {
            var newBooking = new Booking() { StudentID =studentID, CourseID =courseID, BookingDate=selectedDate, BookingStatus = "Active"};

            using (var db = new AcademyContext())
            {
                db.Bookings.Add(newBooking);
                db.SaveChanges();
                SelectedBooking = db.Bookings.Find(newBooking.BookingID);
            }
        }

        public void Update(int bookingID, int courseId, string bookingDate)
        {
            using (var db = new AcademyContext())
            {
                SelectedBooking = db.Bookings.Where(b => b.BookingID == bookingID).FirstOrDefault();
                db.SaveChanges();
            }
        }

        public DataTable RetreiveBookingData()
        {
            string cmdString = string.Empty;
            using (SqlConnection connect = ConnectionHelper.GetConnection())
            {
                cmdString = "select BookingID, FirstName+' '+LastName AS 'FullName', Email, CourseName , CoursePrice, BookingDate, BookingStatus  from Bookings b join Students s on b.StudentID = s.StudentID join Courses c on b.CourseID = c.CourseID";
                SqlCommand cmd = new SqlCommand(cmdString, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Bookings");
                sda.Fill(dt);
                connect.Close();
                return dt;
            }
        }


        public bool DuplicateBookingRecord(int studentID, string selectedDate)
        {
            using (var db = new AcademyContext())
            {
                var findBookingQuery = db.Bookings.Where(b=> b.StudentID == studentID && b.BookingDate == selectedDate);

                if (findBookingQuery.Count()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void SetSelectedBooking(int selectedItem)
        {
            using (var db = new AcademyContext())
            {
                SelectedBooking = db.Bookings.Where(b => b.BookingID == selectedItem).FirstOrDefault();
                db.SaveChanges();
            }
        }

    }
}
