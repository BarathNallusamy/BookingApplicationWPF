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

        public void PopulateTextField()
        {
            if(_bookingManager.SelectedBooking != null)
            {
                txtName.Text = _bookingManager.SelectedBooking.BookingDate;
                //cmbCourseID.Text = _bookingManager.SelectedBooking.CourseID.ToString();
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


        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void bookingList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bookingList.SelectedCells.Count() > 0)
            {
                int selectedRowIndex = bookingList.SelectedIndex+1;
                _bookingManager.SetSelectedBooking(selectedRowIndex);
            }
            PopulateTextField();
            //if (datagridview1.SelectedCells.Count > 0)
            //{
            //    int selectedrowindex = datagridview1.SelectedCells[0].RowIndex;
            //    DataGridViewRow selectedRow = datagridview1.Rows[selectedrowindex];
            //    string cellValue = Convert.ToString(selectedRow.Cells["enter column name"].Value);
            //}
        }
    }
}
