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
        public SqlConnection sqlGlbConnection;

        public void glbConnection()
        {
            sqlGlbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\P32262345\NWUNextcloud\Studies\CMPG\2nd_Year_2st_Year\CMPG_223_(Systems_Analysis_and_Design_II)\Booking\CMPG223_Booking\CMPG223_Booking\CMPG223_Booking\db_Bookings.mdf;Integrated Security=True");
        }
    }
}
