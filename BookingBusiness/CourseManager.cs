using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking_ApplicationSystem;
using Microsoft.EntityFrameworkCore;

namespace BookingBusiness
{
    public class CourseManager
    {
        public Course SelectedCourse { get; set; }

        public void Create(string cName, double cPrice)
        {
            var newCourse = new Course() { CourseName = cName, CoursePrice = cPrice };

            using(var db = new AcademyContext())
            {
                db.Courses.Add(newCourse);
                db.SaveChanges();
            }
        }

        public void Update(int cId, string cName, double cPrice)
        {
            using(var db = new AcademyContext())
            {
                SelectedCourse = db.Courses.Where(c => c.CourseID == cId).FirstOrDefault();
                SelectedCourse.CourseName = cName;
                SelectedCourse.CoursePrice = cPrice;
                db.SaveChanges();
            }
        }


        public void Delete(int courseID)
        {
            using (var db = new AcademyContext())
            {
                var courseDeleteQuery = db.Courses.Include(course => course.Bookings);


                SelectedCourse = db.Courses.Find(courseID);
                db.Remove(SelectedCourse);
                db.SaveChanges();
            }
        }


        public List<Course> RetrieveAll()
        {
            using (var db = new AcademyContext())
            {
                return db.Courses.ToList();
            }
        }

        public void SetSelectedCourseId(int selectedItem)
        {
            SelectedCourse.CourseID = selectedItem;
        }
    }
}
