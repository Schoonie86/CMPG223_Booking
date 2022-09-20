using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CMPG223_Booking.Classes
{
   
    public class UserClass
    { 
        public string name;
        public string surname;
        public string password;
        public string email;
        public int type; // 0=Admin/Traner 1=Client
        SqlCommand sqlComm;
        SqlDataAdapter sqlDataAdapter;
        DataSet ds;
        SqlDataReader sqlDataReader;
        GlobalConnection sqlConn;
        

        public void createUser(string uName, string uSurname, string uPassword, string uEmail)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"INSERT INTO tbUser(Name, LastSuname, Password, Email) VALUES ({uName},{uSurname},HASHBYTES('SHA2_512',{uPassword}),{uEmail})", sqlConn.sqlGlbConn);
                sqlDataAdapter.InsertCommand = sqlComm;
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updateUser(string uName, string uSurname, string uPassword, string uEmail, int uUserID)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"UPDATE tbUser SET Name={uName},LastSuname={uSurname},Password=HASHBYTES('SHA2_512',{uPassword}),Email={uEmail} WHERE UserID={uUserID}", sqlConn.sqlGlbConn);
                sqlDataAdapter.UpdateCommand = sqlComm;
                sqlDataAdapter.UpdateCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteUser(string uUserID)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"DELETE FROM tbUser WHERE UserID={uUserID}", sqlConn.sqlGlbConn);
                sqlDataAdapter.DeleteCommand = sqlComm;
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void createClient(string cName, string cSurname, string cPassword, string cEmail)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"INSERT INTO tbClient(Name, LastSuname, Password, Email) VALUES ({cName},{cSurname},HASHBYTES('SHA2_512',{cPassword}),{cEmail})", sqlConn.sqlGlbConn);
                sqlDataAdapter.InsertCommand = sqlComm;
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updateClient(string cName, string cSurname, string cPassword, string cEmail, int cClientID)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"UPDATE tbUser SET Name={cName},LastSuname={cSurname},Password=HASHBYTES('SHA2_512',{cPassword}),Email={cEmail} WHERE UserID={cClientID}", sqlConn.sqlGlbConn);
                sqlDataAdapter.UpdateCommand = sqlComm;
                sqlDataAdapter.UpdateCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteClient(int cClientID)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"DELETE FROM tbClient WHERE ClientID={cClientID}", sqlConn.sqlGlbConn);
                sqlDataAdapter.DeleteCommand = sqlComm;
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
