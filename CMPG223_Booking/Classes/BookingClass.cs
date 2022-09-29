using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CMPG223_Booking.Classes
{
    public class BookingClass
    {
        public bool bookStat;
        public string bookComments;
        public int eventID;
        public int userID;
        public int clientID;
        public int bookID;
        public string bookName;
        
        SqlCommand sqlComm;
        SqlDataAdapter sqlDatAdap;
        DataSet ds;
        SqlDataReader sqlDatRead;
        GlobalConnection sqlConn;
        DataTable dt;
        public BookingClass()
        {
            bookName = "";
            bookID = 0;
            eventID = 0;
            userID = 0;
            clientID = 0;
            bookStat = false;
            bookComments = "";
        }
        
        public void CreatBooking()
        {
           
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"INSERT INTO tbBooking (BookingName, UserID, ClientID, EventID, Aproved, Coments) VALUES ('{bookName}', {userID},{clientID},{eventID},'{bookStat}','{bookComments}')", sqlConn.sqlGlbConn);
                sqlDatAdap.InsertCommand = sqlComm;
                sqlDatAdap.InsertCommand.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap.Fill(dt);
                sqlConn.sqlGlbConn.Close();
                MessageBox.Show("Booking greated Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateBooking()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"UPDATE tbBooking SET UserID = {userID}, ClientID = '{clientID}',EventID = '{eventID}', Approve = {bookStat}, Comments = {bookComments}) WHERE BookingID={bookID}", sqlConn.sqlGlbConn);
                sqlDatAdap.UpdateCommand = sqlComm;
                sqlDatAdap.UpdateCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
                MessageBox.Show("You Successfully updated the Booking.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteBooking()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"DELETE FROM tbBooking WHERE BookingID={bookID}", sqlConn.sqlGlbConn);
                sqlDatAdap.DeleteCommand = sqlComm;
                sqlDatAdap.DeleteCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
                MessageBox.Show("You have successfully Deleted the User");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ApplyForBooking()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"INSERT INTO tbBooking (BookingName, UserID, ClientID, EventID, Aproved, Coments) VALUES ('{bookName}', {userID},{clientID},{eventID},'{bookStat}','{bookComments}') NOT EXISTS (SELECT * FROM tbBooking WHERE ClientID = {clientID})", sqlConn.sqlGlbConn);
                sqlDatAdap.InsertCommand = sqlComm;
                sqlDatAdap.InsertCommand.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap.Fill(dt);
                sqlConn.sqlGlbConn.Close();
                MessageBox.Show("Application was Successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}   

    
