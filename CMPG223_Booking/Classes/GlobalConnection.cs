using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CMPG223_Booking.Classes
{
    internal class GlobalConnection
    {
        public SqlConnection sqlGlbConn;

        public void glbConn()
        {
            sqlGlbConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Groupe8\dbBookings.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
