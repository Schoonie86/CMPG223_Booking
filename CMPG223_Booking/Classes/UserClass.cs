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
        public int userID;
        public string name;
        public string lastName;
        public string password;
        public string email;
        public int userType;
        public int clientID;
        
        
        SqlCommand sqlComm;
        SqlDataAdapter sqlDatAdap;
        DataSet ds;
        SqlDataReader sqlDatRead;
        GlobalConnection sqlConn;
        DataTable dt;
        
        

       public UserClass()
        {
            try
            {
                userID=0;
                clientID=0;
                name="";
                lastName="";
                password="";
                email="";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool UserValidation()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"SELECT UserID, Password FROM tbUser WHERE UserID={userID} and Password = '{password}')", sqlConn.sqlGlbConn);
                sqlDatAdap.SelectCommand = sqlComm;
                sqlDatAdap.SelectCommand.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap.Fill(dt);
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("You Logged in Successfully.");
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                return false;
            }
        }
        public bool ClientValidation()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"SELECT ClientID, Password FROM tbClient WHERE ClientID='{clientID}' and Password = HASHBYTES('SHA2_512','{password}')",sqlConn.sqlGlbConn);
                sqlDatAdap.SelectCommand = sqlComm;
                sqlDatAdap.SelectCommand.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("You Loged in Successfully.");
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                return false;
            }
        }
        public void CreateUser()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"INSERT INTO tbUser (Name, LastName, Password, Email) VALUES ('{name}','{lastName}',HASHBYTES('SHA2_512', '{password}'),'{email}') ", sqlConn.sqlGlbConn);
                sqlDatAdap.InsertCommand = sqlComm;
                sqlDatAdap.InsertCommand.ExecuteNonQuery();
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
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"UPDATE tbUser SET Name='{name}',LastName='{lastName}',Password = HASHBYTES('SHA2_512','{password}'),Email='{email}' WHERE UserID={userID}", sqlConn.sqlGlbConn);
                sqlDatAdap.UpdateCommand = sqlComm;
                sqlDatAdap.UpdateCommand.ExecuteNonQuery();
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
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"DELETE FROM tbUser WHERE UserID={userID}", sqlConn.sqlGlbConn);
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
        public void CreateClient()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"INSERT INTO tbClient(Name, LastName, Password, Email) VALUES ('{name}','{lastName}',HASHBYTES('SHA2_512','{password}'),'{email}')", sqlConn.sqlGlbConn);
                sqlDatAdap.InsertCommand = sqlComm;
                sqlDatAdap.InsertCommand.ExecuteNonQuery();
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
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"UPDATE tbUser SET Name={name},LastName={lastName},Password=HASHBYTES('SHA2_512',{password}),Email={email} WHERE UserID={clientID}", sqlConn.sqlGlbConn);
                sqlDatAdap.UpdateCommand = sqlComm;
                sqlDatAdap.UpdateCommand.ExecuteNonQuery();
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
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"DELETE FROM tbClient WHERE ClientID={clientID}", sqlConn.sqlGlbConn);
                sqlDatAdap.DeleteCommand = sqlComm;
                sqlDatAdap.DeleteCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
