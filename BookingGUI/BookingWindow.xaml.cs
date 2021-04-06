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
            PopulateBookingListBox();
            CalenderBox.DisplayDateStart = DateTime.Today;//past dates are disabled

        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e) => this.Close();

        //Populate the courses table
        private void PopulateCourseListBox()=>courseList.ItemsSource = _courseManager.RetreiveCourseDate();

        //Populate the bookings table
        public void PopulateBookingListBox() => bookingList.ItemsSource = _bookingManager.RetreiveBookingData().DefaultView;

        //Load course ID combo box with data from courses table
        public void LoadCoursesBox(ComboBox comboBoxID)
        {
            comboBoxID.ItemsSource = _courseManager.RetrieveCourseID().Tables[0].DefaultView;
            comboBoxID.DisplayMemberPath = _courseManager.RetrieveCourseID().Tables[0].Columns["CourseID"].ToString();
        }

        //Load student ID combo box with data from student table
        public void LoadStudentBox(ComboBox comboBoxName)
        {
            comboBoxName.ItemsSource = _studentManager.RetrieveStudentID().Tables[0].DefaultView;
            comboBoxName.DisplayMemberPath = _studentManager.RetrieveStudentID().Tables[0].Columns["StudentID"].ToString();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CalenderBox.SelectedDate.HasValue)
            {
                lblSelectedDate.Content = CalenderBox.SelectedDate.Value.ToString("dd/MM/yyyy");
            }
        }

        private void ButtonBook_Click(object sender, RoutedEventArgs e)
        {
            if (CourseID.SelectedItem != null && StudentID.SelectedItem != null && lblSelectedDate.Content != null)
            {
                int studentID = int.Parse(StudentID.Text);
                int courseID = int.Parse(CourseID.Text);
                string selectedDate = lblSelectedDate.Content.ToString();
                bool checkDuplicateBooking = _bookingManager.DuplicateBookingRecord(studentID, selectedDate);

                if (checkDuplicateBooking)
                {
                    MessageBox.Show("Student already have a class booked for this date", "Duplicate booking", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    _bookingManager.Create(studentID, courseID, selectedDate);
                    MessageBox.Show($"Congratulations, You have enrolled successfully\n\n" +
                    $"Your Booking ID is: {_bookingManager.SelectedBooking.BookingID}");

                    PopulateBookingListBox();
                }
            }
            else
            {
                MessageBox.Show("Please select all the fields to make a booking");
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

        private void Calendar_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e)
        {

        }

        private void Calendar_DisplayModeChanged(object sender, CalendarModeChangedEventArgs e)
        {

        }
    }
}
