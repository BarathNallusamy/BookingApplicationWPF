using NUnit.Framework;
using BookingBusiness;
using Booking_ApplicationSystem;
using System.Linq;

namespace BookingApplicationTests
{
    
    public class StudentTests
    {
        StudentManager _studentManager;
        [SetUp]
        public void Setup()
        {
            _studentManager = new StudentManager();
            
            using(var db = new AcademyContext())
            {
                var studentQuery =
                    from stu in db.Students
                    where stu.StudentID == 1
                    select stu;
                db.Students.RemoveRange(studentQuery);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenCreateMethodIsCalledStudentCountIncreasesByOne()
        {
            using(var db = new AcademyContext())
            {
                var numberOfStudentsBeforeAdding = db.Students.Count();
                _studentManager.Create("Baray", "Nallu", "Nallu.baray@gmail.com");
                var numberOfStudentsAfterAdd = db.Students.Count();

                Assert.AreEqual(numberOfStudentsBeforeAdding + 1, numberOfStudentsAfterAdd);

            }
        }

        [Test]
        public void WhenRegisteredWithTheSameEmailAddressSystemThrowsAnError()
        {
            using (var db = new AcademyContext())
            {
                _studentManager.Create("XYZ", "ABCD", "ABC@gmail.com");
                db.SaveChanges();

                bool expected = true;
                _studentManager.Create("XYZ", "ABCD", "ABC@gmail.com");
                bool results = _studentManager.CheckDuplicateRecords("ABC@gmail.com");

                Assert.AreEqual(expected,results);

            }
        }


        [TearDown]
        public void TearDown()
        {
            _studentManager = new StudentManager();

            using (var db = new AcademyContext())
            {
                var studentQuery =
                    from stu in db.Students
                    where stu.StudentID == 1
                    select stu;
                db.Students.RemoveRange(studentQuery);
                db.SaveChanges();
            }
        }
    }
}