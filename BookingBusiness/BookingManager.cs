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

        public void Create(int studentID, int courseID)
        {
            var newBooking = new Booking() { StudentID =studentID, CourseID =courseID, BookingStatus = "Active"};

            using (var db = new AcademyContext())
            {
                db.Bookings.Add(newBooking);
                db.SaveChanges();
            }
        }
    }
}
