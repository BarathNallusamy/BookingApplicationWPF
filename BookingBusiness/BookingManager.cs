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


    }
}
