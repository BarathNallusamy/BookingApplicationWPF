using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_ApplicationSystem
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public string BookingStatus { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
