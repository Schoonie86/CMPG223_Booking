using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CMPG223_Booking.Classes;

namespace CMPG223_Booking
{
    public partial class frmLogin : Form
    {   
        public int uType = 0;
        public int ID;
        public string password;
        SqlCommand sqlComm;
        SqlDataAdapter sqlDatAdap;
        SqlDataReader sqlDatRead;
        GlobalConnection sqlConn;
        DataTable dt;
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool userCheck( int UID, string UPass)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"SELECT UserID, Password FROM tbUser WHERE UserID={UID} and Password = HASHBYTES('SHA2_512','{UPass}')", sqlConn.sqlGlbConn);
                sqlDatAdap.SelectCommand = sqlComm;
                sqlDatAdap.SelectCommand.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap.Fill(dt);
                sqlConn.sqlGlbConn.Close();
            }
            catch(SqlException ex)
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
        private bool clientCheck(int CID, string CPass)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"SELECT ClientID, Password FROM tbClient WHERE ClientID={CID} and Password = HASHBYTES('SHA2_512','{CPass}')", sqlConn.sqlGlbConn);
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



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(txtBxUserName.Text.ToString());
            password = txtBxPassword.Text.ToString();
            if (ID.ToString().StartsWith("1"))
            {
                if (userCheck(ID, password) == true)
                {
                    uType = 1;
                    DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
            else if (ID.ToString().StartsWith("2"))
            {
                if (clientCheck(ID, password) == true)
                {
                    uType = 2;
                    DialogResult=DialogResult.OK;
                    this.Hide();
                }
            }
        }
    }
}
