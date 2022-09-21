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
        string name;
        string lastName;
        string password;
        string email;
        int userType;
        int userID;
        int clientID;
        
        
        SqlCommand sqlComm;
        SqlDataAdapter sqlDataAdapter;
        DataSet ds;
        SqlDataReader sqlDataReader;
        GlobalConnection sqlConn;
        
       public UserClass(string uName, string uLastName, string uPassword, string uEmail)
        {
            try
            {
                name = uName;
                //uName = name;
                lastName = uLastName;
                //uLastName = lastName;
                password = uPassword;
                //uPassword = password;
                email = uEmail;
                //uEmail = email;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateUser()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"INSERT INTO tbUser (Name, LastName, Password, Email) VALUES ('{name}','{lastName}',HASHBYTES('SHA2_512', '{password}'),'{email}')", sqlConn.sqlGlbConn);
                sqlDataAdapter.InsertCommand = sqlComm;
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
                MessageBox.Show("You Successfully added a new user.");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateUser(string uName, string uSurname, string uPassword, string uEmail, int uUserID)
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
        public void DeleteUser(string uUserID)
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
        public void CreateClient(string cName, string cSurname, string cPassword, string cEmail)
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
        public void UpdateClient(string cName, string cSurname, string cPassword, string cEmail, int cClientID)
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
        public void DeleteClient(int cClientID)
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
