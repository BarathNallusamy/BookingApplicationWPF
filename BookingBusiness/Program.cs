using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Booking_ApplicationSystem;
using Microsoft.Data.SqlClient;

namespace BookingBusiness
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AcademyContext())
            {
                //db.Add(new Course() { CourseName = "Python", CoursePrice = 19.99 });
                //db.Add(new Course() { CourseName = "Java", CoursePrice = 9.99 });
                //db.Add(new Course() { CourseName = "C#", CoursePrice = 14.99 });
                //db.Add(new Course() { CourseName = "Kotlin", CoursePrice = 8.99 });
                //db.Add(new Course() { CourseName = "JavaScript", CoursePrice = 16.99 });
                //db.Add(new Course() { CourseName = "C++", CoursePrice = 8.99 });
                //db.Add(new Course() { CourseName = "SQL", CoursePrice = 10.99 });
                //db.Add(new Course() { CourseName = "HTML/CSS", CoursePrice = 22.99 });
                //db.Add(new Course() { CourseName = "Swift", CoursePrice = 29.99 });
                //db.Add(new Course() { CourseName = "Testing Frameworks", CoursePrice = 34.99 });
                //db.SaveChanges();



                //var courseUpdate = db.Courses.Where(c => c.CourseID == 3).FirstOrDefault();
                //courseUpdate.CourseName = "C Sharp";
                //db.SaveChanges();

                //var courseUpdate2 = db.Courses.Where(c => c.CourseID == 10).FirstOrDefault();
                //courseUpdate2.CourseName = "NUnit";
                //db.SaveChanges();

                Console.WriteLine("Course table populated successfully");

                var courseQuery = db.Courses.OrderBy(c => c.CourseName);
                Console.WriteLine("Courses details ordered by course name:");
                foreach (var c in courseQuery)
                {
                    Console.WriteLine($"{c.CourseName} - is £{c.CoursePrice}");
                }

            }

        }
    }
}
