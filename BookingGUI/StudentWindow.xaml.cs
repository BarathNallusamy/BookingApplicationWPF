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
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        StudentManager _studentManager = new StudentManager();

        public StudentWindow()
        {
            InitializeComponent();
            PopulateStudentListBox();
        }

        private void studentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void PopulateStudentListBox()
        {
            studentList.ItemsSource = _studentManager.RetreiveStudentTable().DefaultView;
        }
    }
}
