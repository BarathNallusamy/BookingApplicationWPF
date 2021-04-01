using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking_ApplicationSystem;

namespace BookingBusiness
{
    public class StudentManager
    {
        public Student SelectedStudent{ get; set; }

        public void Create(string firstName, string lastName, string emailAddress)
        {
            var newStudent = new Student() { FirstName=firstName, LastName = lastName, Email = emailAddress };
            using (var db = new AcademyContext())
            {
                db.Students.Add(newStudent);
                db.SaveChanges();
                SelectedStudent = db.Students.Find(newStudent.StudentID);
            }
        }

        public List<Student> RetrieveAll()
        {
            using (var db = new AcademyContext())
            {
                return db.Students.ToList();
            }
        }

        public void SetSelectedStudentID(int selectedItem)
        {
            SelectedStudent.StudentID = selectedItem;
        }
    }
}
