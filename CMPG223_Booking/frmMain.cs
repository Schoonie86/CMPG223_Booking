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
    public partial class frmMain : Form
    {
        SqlCommand sqlComm;
        SqlDataAdapter sqlDatAdap;
        DataSet ds;
        SqlDataReader sqlDatRead;
        GlobalConnection sqlConn;
        DataTable dt;
        public string varname = "";

        public frmMain()
        {
            InitializeComponent();
        }
        public void Main(string[] arg)
        {

        }
        private void Login()
        {
           
        }

        private void PopulateCmbo()
        {
            sqlConn = new GlobalConnection();
            sqlConn.glbConn();

            //try cach to Populate the User comboBoxes
            try
            {
                cmbBxEdSlctUser.Items.Clear();
                cmbBxEdSlctUser.Text = "Leave empty to add new User";
                sqlConn.sqlGlbConn.Open();
                sqlComm = sqlConn.sqlGlbConn.CreateCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "SELECT Name from tbUser";
                sqlComm.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap = new SqlDataAdapter(sqlComm);
                sqlDatAdap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbBxEdSlctUser.Items.Add(dr["Name"].ToString());
                }
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            //try cach to Populate the Client comboBoxes
            try
            {
                cmbBxEdSlctClient.Items.Clear();
                cmbBxEdSlctClient.Text = "Leave empty to add new Client";
                sqlConn.sqlGlbConn.Open();
                sqlComm = new SqlCommand();
                sqlComm = sqlConn.sqlGlbConn.CreateCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "SELECT Name FROM tbClient";
                sqlComm.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap = new SqlDataAdapter(sqlComm);
                sqlDatAdap.Fill(dt);

                foreach (DataRow dr2 in dt.Rows)
                {
                    cmbBxEdSlctClient.Items.Add(dr2["Name"].ToString());
                }
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateCmbo();
        
        }
        private void btnEdNewUserSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBxEdSlctUser.SelectedIndex == -1)
                {
                    UserClass adminObj = new UserClass(txtBxEdName.Text.ToString(),txtBxEdSurname.Text.ToString(), txtBxEdPassword.Text.ToString(), txtBxEdEmail.Text.ToString());
                    adminObj.CreateUser();
                    txtBxEdName.Clear();
                    txtBxEdSurname.Clear();
                    txtBxEdPassword.Clear();
                    txtBxEdEmail.Clear();
                    PopulateCmbo();
                }
                else
                {
                    MessageBox.Show("Sellected user Alrady exist");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEdNewClientSubmit_Click(object sender, EventArgs e)
        {
            UserClass clientObj = new UserClass(txtBxEdClientName.Text, txtBxEdClientSurname.Text, txtBxEdClientPassword.Text, txtBxEdClientEmail.Text);
            clientObj.CreateClient(txtBxEdClientName.Text, txtBxEdClientSurname.Text, txtBxEdClientPassword.Text, txtBxEdClientEmail.Text);
        }

        private void cmbBxEdSlctUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConn.sqlGlbConn.Open();
                sqlComm = new SqlCommand($"SELECT UserID, Name, LastName, Email FROM tbUser WHERE Name = '{cmbBxEdSlctUser.Text}'", sqlConn.sqlGlbConn);
                sqlDatRead = sqlComm.ExecuteReader();
                while (sqlDatRead.Read())
                {
                    txtBxUserID.Text = sqlDatRead.GetValue(0).ToString();
                    txtBxEdName.Text = sqlDatRead.GetValue(1).ToString();
                    txtBxEdSurname.Text = sqlDatRead.GetValue(2).ToString();
                    txtBxEdEmail.Text = sqlDatRead.GetValue(3).ToString();
                    txtBxEdPassword.Clear();
                }
                sqlConn.sqlGlbConn.Close();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBxEdSlctClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConn.sqlGlbConn.Open();
                sqlComm = new SqlCommand($"SELECT ClientID, Name, LastName, Email FROM tbClient WHERE Name = '{cmbBxEdSlctClient.Text}'", sqlConn.sqlGlbConn);
                sqlDatRead = sqlComm.ExecuteReader();
                while (sqlDatRead.Read())
                {
                    txtBxEdClientID.Text = sqlDatRead.GetValue(0).ToString();
                    txtBxEdClientName.Text = sqlDatRead.GetValue(1).ToString();
                    txtBxEdClientSurname.Text = sqlDatRead.GetValue(2).ToString();
                    txtBxEdClientEmail.Text = sqlDatRead.GetValue(3).ToString();
                }
                sqlConn.sqlGlbConn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        /*
private void Login(int userName, string password)
{
   userName = Convert.ToInt16(txtBxUserName.Text);
   password = txtBxPassword.Text;

   try
   {
       sqlConnection = new GlobalConnection();
       sqlConnection.glbConnection();
       sqlConnection.sqlGlbConnection.Open();
       sqlDataAdapter = new SqlDataAdapter();
       sqlCommand = new SqlCommand(@"Select User_ID,Password From tb_User", sqlConnection.sqlGlbConnection);
       ds = new DataSet();
       sqlDataAdapter.SelectCommand = sqlCommand;
       sqlDataAdapter.Fill(ds, "tbsrs");

       sqlConnection.sqlGlbConnection.Close();
   }
   catch (SqlException error)
   {
       MessageBox.Show(error.Message);
   }


}
private void DataConnect()
{
   if (tabCtrlMain.SelectedIndex == 0)  // Determine user selection and Login
   {
       //Verify User Login Details 
       try
       {
           sqlConnection = new GlobalConnection();
           sqlConnection.glbConnection();
           sqlConnection.sqlGlbConnection.Open();
           sqlDataAdapter = new SqlDataAdapter();
           sqlCommand = new SqlCommand(@"Select User_ID From tb_User", sqlConnection.sqlGlbConnection);
           ds = new DataSet();
           sqlDataAdapter.SelectCommand = sqlCommand;
           sqlDataAdapter.Fill(ds, "tbsrs");
           dgvMovies.DataSource = ds;
           dgvMovies.DataMember = "tbsrs";
           sqlConnection.sqlGlbConnection.Close();
       }
       catch (SqlException error)
       {
           MessageBox.Show(error.Message);
       }

       //Populate the ComboBox for deleting Movies.
       try
       {
           conn.gblCon();
           conn.con.Open();
           adapter = new SqlDataAdapter();
           com = new SqlCommand(@"Select DISTINCT MovieName From tblMovies", conn.con);
           ds = new DataSet();
           adapter.SelectCommand = com;
           adapter.Fill(ds, "tbsrs");
           cbxDelMovie.DisplayMember = "MovieName";
           cbxDelMovie.ValueMember = "MovieName";
           cbxDelMovie.DataSource = ds.Tables["tbsrs"];
           conn.con.Close();
       }
       catch (SqlException error)
       {
           MessageBox.Show(error.Message);
       }
   }
   else if (tctrMain.SelectedIndex == 1)
   {
       //Populating the ListBox from database using the SqlDataReader.
       try
       {
           conn.gblCon();
           conn.con.Open();
           com = new SqlCommand(@"SELECT * FROM tblMovies", conn.con);
           dataReader = com.ExecuteReader();
           while (dataReader.Read())
           {
               lbxMovies.Items.Add(dataReader.GetValue(0) + "\t" + dataReader.GetValue(1) + "\t" + dataReader.GetValue(2) + "\t" + dataReader.GetValue(3) + "\n");
               lbxMovies.Items.Add("\n");
           }
           conn.con.Close();
           dataReader.Close();
           com.Dispose();
       }
       catch (SqlException error)
       {
           MessageBox.Show(error.Message);
       }
   }
}*/


    }
}
