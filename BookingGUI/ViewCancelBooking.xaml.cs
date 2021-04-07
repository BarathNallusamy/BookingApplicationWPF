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
        BookingManager _bookingManager = new BookingManager();

        public ViewCancelBooking()
        {
            InitializeComponent();
            LoadCoursesBox(cmbCourseID);
            PopulateBookingListBox();
        }


        public void PopulateBookingListBox()
        {
            bookingList.ItemsSource = _bookingManager.RetreiveBookingData().DefaultView;
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


        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
