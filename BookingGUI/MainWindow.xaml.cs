using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookingBusiness;

namespace BookingGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentManager _stuManager = new StudentManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TextEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Please enter a valid Email address", "Invalid Email", MessageBoxButton.OK, MessageBoxImage.Error);
                TextEmail.Select(0, TextEmail.Text.Length);
                TextEmail.Focus();
            }
            else if (_stuManager.CheckDuplicateRecords(TextEmail.Text))
            {
                MessageBox.Show("Already registered email address, Please use a new address", "Duplicate Email", MessageBoxButton.OK, MessageBoxImage.Error);
                TextEmail.Select(0, TextEmail.Text.Length);
                TextEmail.Focus();
            }
            else
            {
                _stuManager.Create(TextFirstName.Text, TextLastName.Text, TextEmail.Text);
                MessageBox.Show($"Congratulations {TextFirstName.Text}!\n" +
                    $"Your Student ID is: {_stuManager.SelectedStudent.StudentID}");
            }
        }

        private void CreateBooking_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow bookingWindow = new BookingWindow();
            bookingWindow.Show();
        }

        private void ViewCancelBooking_Click(object sender, RoutedEventArgs e)
        {
            ViewCancelBooking viewCancelBookingWindow = new ViewCancelBooking();
            viewCancelBookingWindow.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void ViewStudents_Click(object sender, RoutedEventArgs e)
        {
            StudentWindow studentWindow = new StudentWindow();
            studentWindow.Show();
        }
    }
}
