using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking_ApplicationSystem;
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

        //public bool CheckDuplicateRecords(int bookingID)
        //{
        //    using (var db = new AcademyContext())
        //    {
        //        var findEmailQuery = db.Students.Find(bookingID);

        //        if (findEmailQuery)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

    }
}
