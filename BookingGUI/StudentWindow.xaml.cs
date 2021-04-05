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
            string cmdString = string.Empty;
            using (SqlConnection connect = ConnectionHelper.GetConnection())
            {
                cmdString = "select * from students";
                SqlCommand cmd = new SqlCommand(cmdString, connect);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Students");
                sda.Fill(dt);
                studentList.ItemsSource = dt.DefaultView;
                connect.Close();
            }
        }
    }
}
