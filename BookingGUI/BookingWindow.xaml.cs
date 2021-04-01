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

        private CourseManager _courseManager = new CourseManager();
        private StudentManager _studentManager = new StudentManager();
        private BookingManager _bookingManager = new BookingManager();

        public BookingWindow()
        {
            InitializeComponent();
            PopulateCourseListBox();
            LoadCoursesBox(CourseID);
            LoadStudentBox(StudentID);
        }

        private void ButtonBook_Click(object sender, RoutedEventArgs e)
        {
            if (CourseID.SelectedItem != null && StudentID.SelectedItem !=null)
            {
                _courseManager.SetSelectedCourseId(int.Parse(CourseID.Text));
                _studentManager.SetSelectedStudentID(int.Parse(StudentID.Text));
            }
            int studentID = _studentManager.SelectedStudent.StudentID;
            int courseID = _courseManager.SelectedCourse.CourseID;
            _bookingManager.Create(studentID, courseID);
            MessageBox.Show($"Congratulations, You have enrolled successfully\n\n" +
            $"Your Booking ID is: {_bookingManager.SelectedBooking.BookingID}");
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StuId_selected(object sender, SelectionChangedEventArgs e)
        {
            //if (StudentID.SelectedItem != null)
            //{
            //    string r = StudentID.Text;
            //    _studentManager.SetSelectedStudentID(int.Parse(r));
            //}
            //else
            //{
            //    MessageBox.Show("Please select all the fields to make a booking");
            //}
        }

        private void CourseId_selected(object sender, SelectionChangedEventArgs e)
        {
            //if (CourseID.SelectedItem != null)
            //{
            //    _courseManager.SetSelectedCourseId(int.Parse(CourseID.Text));
            //}
            //else
            //{
            //    MessageBox.Show("Please select all the fields to make a booking");
            //}
        }

        private void PopulateCourseListBox()
        {
            CourseListBox.ItemsSource = _courseManager.RetrieveAll();
        }

        
        private void BookingWindow_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadCoursesBox(ComboBox comboBoxName)
        {
            SqlConnection connect = ConnectionHelper.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter("Select CourseID FROM Courses", connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Courses");
            comboBoxName.ItemsSource = ds.Tables[0].DefaultView;
            comboBoxName.DisplayMemberPath = ds.Tables[0].Columns["CourseID"].ToString();
            //comboBoxName.SelectedValuePath = ds.Tables[0].Columns["CourseID"].ToString();
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
        }

    }
}
