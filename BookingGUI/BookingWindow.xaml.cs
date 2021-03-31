using System;
using System.Collections.Generic;
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

namespace BookingGUI
{
    /// <summary>
    /// Interaction logic for BookingWindow.xaml
    /// </summary>
    public partial class BookingWindow : Window
    {
        private CourseManager _courseManager = new CourseManager();

        public BookingWindow()
        {
            InitializeComponent();
            PopulateCourseListBox();
        }

        private void ButtonBook_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StuId_selected(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CourseId_selected(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PopulateCourseListBox()
        {
            CourseListBox.ItemsSource = _courseManager.RetrieveAll();
        }
    }
}
