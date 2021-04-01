using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingBusiness
{
    public class ConnectionHelper
    {
        public static SqlConnection GetConnection()
        {
            string connectionStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connect = new SqlConnection(connectionStr);
            return connect;
        }
    }
}
