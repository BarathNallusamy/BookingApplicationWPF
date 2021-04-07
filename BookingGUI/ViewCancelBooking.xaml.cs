using BookingBusiness;
using Microsoft.Data.SqlClient;
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

namespace BookingGUI
{
    /// <summary>
    /// Interaction logic for ViewCancelBooking.xaml
    /// </summary>
    public partial class ViewCancelBooking : Window
    {
        CourseManager _courseManager = new CourseManager();

        public ViewCancelBooking()
        {
            InitializeComponent();
            LoadCoursesBox(cmbCourseID);
            PopulateBookingListBox();
        }


        public void PopulateBookingListBox()
        {
            string cmdString = string.Empty;
            using (SqlConnection connect = ConnectionHelper.GetConnection())
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

        public void LoadCoursesBox(ComboBox comboBoxID)
        {
            comboBoxID.ItemsSource = _courseManager.RetrieveCourseID().Tables[0].DefaultView;
            comboBoxID.DisplayMemberPath = _courseManager.RetrieveCourseID().Tables[0].Columns["CourseID"].ToString();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btnClose_Click(object sender, RoutedEventArgs e) => this.Close();


        private void bookingList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
