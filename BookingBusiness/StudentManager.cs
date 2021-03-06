using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking_ApplicationSystem;
using Microsoft.Data.SqlClient;

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

        public DataSet RetrieveStudentID()
        {
            SqlConnection connect = ConnectionHelper.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT StudentID FROM Students", connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Students");
            return ds;
        }

        public void SetSelectedStudentID(int selectedItem)
        {
            SelectedStudent.StudentID = selectedItem;
        }

        public DataTable RetreiveStudentTable()
        {
            string cmdString = string.Empty;
            using (SqlConnection connect = ConnectionHelper.GetConnection())
            {
                cmdString = "select * from students";
                SqlCommand cmd = new SqlCommand(cmdString, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Students");
                sda.Fill(dt);
                connect.Close();
                return dt;
            }
        }

        public bool CheckDuplicateRecords(string emailID)
        {
            using(var db = new AcademyContext())
            {
                var findEmailQuery = db.Students.Where(e=> e.Email== emailID);

                if (findEmailQuery.Count()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
