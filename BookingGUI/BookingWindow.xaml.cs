using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BookingBusiness;
using Microsoft.Data.SqlClient;

namespace BookingGUI
{
    /// <summary>
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {

        //private CourseManager _courseManager = new CourseManager();
        //private StudentManager _studentManager = new StudentManager();
        private BookingManager _bookingManager = new BookingManager();


        public BookingWindow()
        {
            InitializeComponent();
            PopulateCourseListBox();
            LoadCoursesBox(CourseID);
            LoadStudentBox(StudentID);
            PopulateBookingListBox();
            CalenderBox.DisplayDateStart = DateTime.Today;//disables past dates

        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e) => this.Close();

        private void PopulateCourseListBox()
        {
            string cmdString = string.Empty;
            using (SqlConnection connect = ConnectionHelper.GetConnection())
            {
                cmdString = "select CourseID, CourseName ,CoursePrice from Courses";
                SqlCommand cmd = new SqlCommand(cmdString, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Courses");
                sda.Fill(dt);
                courseList.ItemsSource = dt.DefaultView;
                connect.Close();
            }
        }

        private void ButtonBook_Click(object sender, RoutedEventArgs e)
        {
            if (CourseID.SelectedItem != null && StudentID.SelectedItem !=null && lblSelectedDate.Content != null)
            {
                int studentID = int.Parse(StudentID.Text);
                int courseID = int.Parse(CourseID.Text);
                string selectedDate = lblSelectedDate.Content.ToString();
                _bookingManager.Create(studentID, courseID, selectedDate);
                
                MessageBox.Show($"Congratulations, You have enrolled successfully\n\n" +
                $"Your Booking ID is: {_bookingManager.SelectedBooking.BookingID}");
            }
            else
            {
                MessageBox.Show("Please select all the fields to make a booking");
            }

            PopulateBookingListBox();
        }


        public void LoadCoursesBox(ComboBox comboBoxID)
        {
            SqlConnection connect = ConnectionHelper.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select CourseID FROM Courses", connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Courses");
            comboBoxID.ItemsSource = ds.Tables[0].DefaultView;
            comboBoxID.DisplayMemberPath = ds.Tables[0].Columns["CourseID"].ToString();
            //comboBoxName.SelectedValuePath = ds.Tables[0].Columns["CourseID"].ToString();
            connect.Close();
        }

        public void LoadStudentBox(ComboBox comboBoxName)
        {
            SqlConnection connect = ConnectionHelper.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT StudentID FROM Students", connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Students");
            comboBoxName.ItemsSource = ds.Tables[0].DefaultView;
            comboBoxName.DisplayMemberPath = ds.Tables[0].Columns["StudentID"].ToString();
            //comboBoxName.SelectedValuePath = ds.Tables[0].Columns["StudentID"].ToString();
            connect.Close();
        }

        public void PopulateBookingListBox()
        {
            string cmdString = string.Empty;
            using(SqlConnection connect = ConnectionHelper.GetConnection())
            {
                cmdString = "select BookingID, FirstName+' '+LastName AS 'FullName', Email, CourseName , CoursePrice, BookingDate, BookingStatus  from Bookings b join Students s on b.StudentID = s.StudentID join Courses c on b.CourseID = c.CourseID";
                SqlCommand cmd = new SqlCommand(cmdString, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Bookings");
                sda.Fill(dt);
                bookingList.ItemsSource = dt.DefaultView;
                connect.Close();
            }
        }

            private void StuId_selected(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CourseId_selected(object sender, SelectionChangedEventArgs e)
        {

        }

        private void bookingList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CalenderBox.SelectedDate.HasValue)
            {
                lblSelectedDate.Content = CalenderBox.SelectedDate.Value.ToString("dd/MM/yyyy");
            }
        }

        private void Calendar_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e)
        {

        }

        private void Calendar_DisplayModeChanged(object sender, CalendarModeChangedEventArgs e)
        {

        }
    }
}
