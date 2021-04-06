using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_ApplicationSystem
{
    public partial class Course
    {
        
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public double CoursePrice { get; set; }

        public ICollection<Booking> Bookings { get; set; }= new ObservableCollection<Booking>();

    }
}
