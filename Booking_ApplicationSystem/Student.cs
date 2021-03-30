using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_ApplicationSystem
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BookingDate { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new ObservableCollection<Booking>();
    }
}
