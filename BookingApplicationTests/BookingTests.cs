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
                var bookingQuery =
                    from boo in db.Bookings
                    where boo.BookingID == 1
                    select boo;
                db.Bookings.RemoveRange(bookingQuery);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenCreateBookingMethodIsCalledBookingCountIncreasesByOne()
        {
            using (var db = new AcademyContext())
            {
                var bookingTotalBeforeAdding = db.Bookings.Count();
                _bookingManager.Create(3,2,"01/05/2021");
                var bookingTotalAfterAdd = db.Bookings.Count();

                Assert.AreEqual(bookingTotalBeforeAdding + 1, bookingTotalAfterAdd);
            }
        }

        [Test]
        public void WhenAStudentSelectsAnotherBookingForTheSameDateSystemReturnsTrue()
        {
            using (var db = new AcademyContext())
            {
                bool results = _bookingManager.DuplicateBookingRecord(3, "01/05/2021");
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
                var bookingQuery =
                    from boo in db.Bookings
                    where boo.BookingID == 1
                    select boo;
                db.Bookings.RemoveRange(bookingQuery);
                db.SaveChanges();
            }
        }
    }
}