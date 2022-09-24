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
        public int ID;
        public string name;
        public string lastName;
        public string password;
        public string email;
        public int userType;
        public int clientID;
        
        
        SqlCommand sqlComm;
        SqlDataAdapter sqlDataAdapter;
        DataSet ds;
        SqlDataReader sqlDataReader;
        GlobalConnection sqlConn;
        DataTable dt;
        
        

       public UserClass()
        {
            try
            {
                ID = 0;
                name = "";
                lastName = "";
                password = "";
                email = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UserValidation(int logUserID, string logUserPass)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"SELECT UserID, Password FROM tbUser WHERE UserID={logUserID} and Password = HASHBYTES('SHA2_512','{logUserPass}')");
                sqlDataAdapter.SelectCommand = sqlComm;
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                dt = new DataTable();
                sqlDataAdapter.Fill(dt);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }   
            if (dt.Rows.Count == 1)
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
        public void ClientValidation(int logClientID, string logClientPass)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"SELECT ClientID, Password FROM tbClient WHERE ClientID='{logClientID}' and Password = HASHBYTES('SHA2_512','{logClientPass}')");
                sqlDataAdapter.SelectCommand = sqlComm;
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                dt = new DataTable();
                sqlDataAdapter.Fill(dt);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dt.Rows.Count == 1)
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
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
        public void UpdateUser(int userID)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"UPDATE tbUser SET Name='{name}',LastName='{lastName}',Password = HASHBYTES('SHA2_512','{password}'),Email='{email}' WHERE UserID={userID}", sqlConn.sqlGlbConn);
                sqlDataAdapter.UpdateCommand = sqlComm;
                sqlDataAdapter.UpdateCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
                MessageBox.Show("You Successfully updated the user details.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteUser()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"DELETE FROM tbUser WHERE UserID={ID}", sqlConn.sqlGlbConn);
                sqlDataAdapter.DeleteCommand = sqlComm;
                sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
                MessageBox.Show("You have successfully Deleted the User");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CreateClient()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"INSERT INTO tbClient(Name, LastName, Password, Email) VALUES ('{name}','{lastName}',HASHBYTES('SHA2_512','{password}'),'{email}')", sqlConn.sqlGlbConn);
                sqlDataAdapter.InsertCommand = sqlComm;
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateClient(int clientID)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"UPDATE tbUser SET Name={name},LastName={lastName},Password=HASHBYTES('SHA2_512',{password}),Email={email} WHERE UserID={clientID}", sqlConn.sqlGlbConn);
                sqlDataAdapter.UpdateCommand = sqlComm;
                sqlDataAdapter.UpdateCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteClient()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDataAdapter = new SqlDataAdapter();
                sqlComm = new SqlCommand($"DELETE FROM tbClient WHERE ClientID={clientID}", sqlConn.sqlGlbConn);
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
