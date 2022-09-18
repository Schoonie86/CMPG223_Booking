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
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataSet ds;
        SqlDataReader sqlDataReader;
        GlobalConnection sqlConnection;
 
        public frmMain()
        {
            InitializeComponent();
        }

        public void Main(string[] arg)
        {
            UserClass admin = new UserClass();
            admin.name = txtBxEdName.Text;
            admin.email = txtBxEdEmail.Text;
            admin.surname = txtBxEdSurname.Text;
            admin.password = txtBxEdPassword.Text;

            UserClass client = new UserClass();
            client.name = txtBxEdClientName.Text;
            client.surname=txtBxEdClientSurname.Text;
            client.email = txtBxEdClientEmail.Text;
            client.password = txtBxEdClientPassword.Text;

            EventClass events = new EventClass();
            events.EventName = txtBxEventName.Text;
            if (radioBtnTraining.Checked)
            {
                events.EventType = 0;
            }
            else if (radioBtnExam.Checked)
            {
                events.EventType = 1;
            }
            events.EventStartDate = dtPckrEventStartDate.MaxDate;
            events.EventEndDate = dtPckrEventEndDate.MaxDate;
            events.EventStartTime = DateTime.Parse(cmbBxEventStartTime.Text);
            events.EventEndTime = DateTime.Parse(cmbBxEventEndTime.Text);

           


        }


       
        public void updateUser()
        {
            try
            {

            }
            catch
            {

            }
        }
        public void deleteUser()
        {
            try
            {

            }
            catch
            {

            }
        }

        public void createClient()
        {
            UserClass client = new UserClass();
            client.name = txtBxEdClientName.Text;
            client.surname = txtBxEdClientSurname.Text;
            client.email = txtBxEdClientEmail.Text;
            client.password = txtBxEdClientPassword.Text;
            try
            {

            }
            catch
            {

            }
        }
        public void updateClient()
        {
            try
            {

            }
            catch
            {

            }
        }
        public void deleteClient()
        {
            try
            {

            }
            catch
            {

            }
        }

        private void createEvent()
        {
            EventClass events = new EventClass();
            events.EventName = txtBxEventName.Text;
            if (radioBtnTraining.Checked)
            {
                events.EventType = 0;
            }
            else if (radioBtnExam.Checked)
            {
                events.EventType = 1;
            }
            events.EventStartDate = dtPckrEventStartDate.MaxDate;
            events.EventEndDate = dtPckrEventEndDate.MaxDate;
            events.EventStartTime = DateTime.Parse(cmbBxEventStartTime.Text);
            events.EventEndTime = DateTime.Parse(cmbBxEventEndTime.Text);
            try
            {
                   
            }
            catch
            {

            }
        }
        public void updateEvent()
        {
            try
            {

            }
            catch
            {

            }
        }
        public void deleteEvent()
        {
            try
            {

            }
            catch
            {

            }
        }

        private void createBooking()
        {
            EventClass events = new EventClass();
            events.EventName = txtBxEventName.Text;
            if (radioBtnTraining.Checked)
            {
                events.EventType = 0;
            }
            else if (radioBtnExam.Checked)
            {
                events.EventType = 1;
            }
            events.EventStartDate = dtPckrEventStartDate.MaxDate;
            events.EventEndDate = dtPckrEventEndDate.MaxDate;
            events.EventStartTime = DateTime.Parse(cmbBxEventStartTime.Text);
            events.EventEndTime = DateTime.Parse(cmbBxEventEndTime.Text);
            try
            {

            }
            catch
            {

            }
        }
        public void updateBooking()
        {
            try
            {

            }
            catch
            {

            }
        }
        public void deleteBooking()
        {
            try
            {

            }
            catch
            {

            }
        }
        public void approveBooking()
        {
            try
            {

            }
            catch
            {

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
