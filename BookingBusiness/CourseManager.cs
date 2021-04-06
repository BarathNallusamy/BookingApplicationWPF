using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking_ApplicationSystem;
using Microsoft.Data.SqlClient;
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


        public void SetSelectedCourseId(int selectedItem)
        {
            SelectedCourse.CourseID = selectedItem;
        }

        public List<Course> RetreiveCourseDate()
        {
            using (var db = new AcademyContext())
            {
                var courseQuery =
                    from c in db.Courses
                    orderby c.CourseID
                    select c;

                var query = db.Courses.FromSqlRaw(courseQuery.ToQueryString()).ToList();
                return query;
            } 
        }

        public DataSet RetrieveCourseID()
        {
            SqlConnection connect = ConnectionHelper.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select CourseID FROM Courses", connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Courses");
            return ds;
        }

        ////Another way to retreive data from db courses
        //public DataTable retrieveCourseData()
        //{
        //    using (SqlConnection connect = ConnectionHelper.GetConnection())
        //    {
        //        string cmdString = "select CourseID, CourseName ,CoursePrice from Courses";
        //        SqlCommand cmd = new SqlCommand(cmdString, connect);
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable("Courses");
        //        sda.Fill(dt);
        //        connect.Close();
        //        return dt;
        //    }
        //}
    }
}
