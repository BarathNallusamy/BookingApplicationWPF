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

        [TestCase("Baray", "Nallu", "Nallu.baray@gmail.com",1)]
        public void CheckStudentIDValueAfterCreatingANewStudent(string a,string b,string c, int expected)
        {
            using (var db = new AcademyContext())
            {
                
                _studentManager.Create(a,b,c);
                int results = 1;
                var stuIdQuery = db.Students.Where(s => s.StudentID == results).FirstOrDefault();
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