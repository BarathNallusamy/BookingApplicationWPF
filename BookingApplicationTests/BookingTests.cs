using NUnit.Framework;
using BookingBusiness;
using Booking_ApplicationSystem;
using System.Linq;

namespace BookingApplicationTests
{

    public class BookingTests
    {
        BookingManager _bookingManager;
        [SetUp]
        public void Setup()
        {
            _bookingManager = new BookingManager();
            using (var db = new AcademyContext())
            {
                var selectedBooking =
                from b in db.Bookings
                where b.BookingID == 1
                select b;

                //db.Bookings.RemoveRange(selectedBooking);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenCreateBookingMethodIsCalledBookingCountIncreasesByOne()
        {
            using (var db = new AcademyContext())
            {
                var bookingTotalBeforeAdding = db.Bookings.Count();
                _bookingManager.Create(2,5,"01/05/2021");
                var bookingTotalAfterAdd = db.Bookings.Count();

                Assert.AreEqual(bookingTotalBeforeAdding + 1, bookingTotalAfterAdd);
            }
        }

        [Test]
        public void WhenAStudentSelectsAnotherBookingForTheSameDateSystemReturnsTrue()
        {
            using (var db = new AcademyContext())
            {
                _bookingManager.Create(2, 5, "01/05/2021");

                bool results = _bookingManager.DuplicateBookingRecord(2, "01/05/2021");
                bool expected = true;

                Assert.AreEqual(expected, results);
            }
        }


        [TearDown]
        public void TearDown()
        {
            _bookingManager = new BookingManager();
            using (var db = new AcademyContext())
            {
                var selectedBooking =
                from b in db.Bookings
                where b.BookingID == 1
                select b;

                //db.Students.RemoveRange(selectedStudent);
                db.SaveChanges();
            }
        }
    }
}