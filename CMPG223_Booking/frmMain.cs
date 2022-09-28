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
        SqlDataReader sqlDatRead;
        GlobalConnection sqlConn;
        DataTable dt;
        public string varname = "";
        int slctUID;
        int slctCID;
        int slctEID;
        bool slctBookStat;


        public frmMain()
        {
            InitializeComponent();
        }
        public void Main(string[] arg)
        {

        }
        private void PopulateUserCmbo()
        {
            try //try cach to Populate the User comboBoxes
                {sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                cmbBxEdSlctUser.Items.Clear();
                cmbBxEdSlctUser.Text = "Leave empty to add new User";
                sqlConn.sqlGlbConn.Open();
                sqlComm = sqlConn.sqlGlbConn.CreateCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "SELECT Name FROM tbUser";
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
           
        }
        private void PopulateClientCmbo()
        {
            sqlConn = new GlobalConnection();
            sqlConn.glbConn();
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

                foreach (DataRow dr in dt.Rows)
                {
                    cmbBxEdSlctClient.Items.Add(dr["Name"].ToString());
                }
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateSlctBook()
        {
            sqlConn = new GlobalConnection();
            sqlConn.glbConn();
            try
            {
                cmbBxBookSlctBook.Items.Clear();
                cmbBxBookSlctEvent.Items.Clear();
                cmbBxBookSlctTrain.Items.Clear();
                cmbBxBookSlctClient.Items.Clear();
                cmbBxBookSlctBook.Text = "Leave empty to add new Booking";
                sqlConn.sqlGlbConn.Open();
                sqlComm = new SqlCommand();
                sqlComm = sqlConn.sqlGlbConn.CreateCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "SELECT BookingName FROM tbBooking";
                sqlComm.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap = new SqlDataAdapter(sqlComm);
                sqlDatAdap.Fill(dt);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (DataRow dr in dt.Rows)
            {
                cmbBxBookSlctBook.Items.Add(dr["BookingName"].ToString());
            }
            sqlConn.sqlGlbConn.Close();
        }
        private void PopulateSlctEvent()
        {
            sqlConn = new GlobalConnection();
            sqlConn.glbConn();

            //try cach to Populate the Event comboBoxes
            try
            {
                cmbBxSlctEvent.Items.Clear();
                cmbBxSlctEvent.Text = "Leave empty to add new Event";
                sqlConn.sqlGlbConn.Open();
                sqlComm = sqlConn.sqlGlbConn.CreateCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "SELECT Name from tbEvent";
                sqlComm.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap = new SqlDataAdapter(sqlComm);
                sqlDatAdap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbBxSlctEvent.Items.Add(dr["Name"].ToString());
                    
                }
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void PopulateBookSlctEvent()
        {
            sqlConn = new GlobalConnection();
            sqlConn.glbConn();

            //try cach to Populate the Event comboBoxes
            try
            {
                cmbBxBookSlctEvent.Items.Clear();
                cmbBxBookSlctEvent.Text = "Please select the Event";
                sqlConn.sqlGlbConn.Open();
                sqlComm = sqlConn.sqlGlbConn.CreateCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "SELECT Name from tbEvent";
                sqlComm.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap = new SqlDataAdapter(sqlComm);
                sqlDatAdap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbBxBookSlctEvent.Items.Add(dr["Name"].ToString());
                }
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void PopulateBookSlctTrain()
        {
            sqlConn = new GlobalConnection();
            sqlConn.glbConn();

            //try cach to Populate the Trainer comboBoxes
            try
            {
                cmbBxBookSlctTrain.Items.Clear();
                cmbBxBookSlctTrain.Text = "Please Select the Trainer";
                sqlConn.sqlGlbConn.Open();
                sqlComm = sqlConn.sqlGlbConn.CreateCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "SELECT Name FROM tbUser";
                sqlComm.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap = new SqlDataAdapter(sqlComm);
                sqlDatAdap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbBxBookSlctTrain.Items.Add(dr["Name"].ToString());
                }
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateBookSlctAttendee()
        {
            sqlConn = new GlobalConnection();
            sqlConn.glbConn();
            //try cach to Populate the Client comboBoxes
            try
            {
                cmbBxBookSlctClient.Items.Clear();
                cmbBxBookSlctClient.Text = "Please select the Attendees";
                sqlConn.sqlGlbConn.Open();
                //sqlComm = new SqlCommand();
                sqlComm = sqlConn.sqlGlbConn.CreateCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "SELECT Name FROM tbClient";
                sqlComm.ExecuteNonQuery();
                dt = new DataTable();
                sqlDatAdap = new SqlDataAdapter(sqlComm);
                sqlDatAdap.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbBxBookSlctClient.Items.Add(dr["Name"].ToString());
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
            PopulateUserCmbo();
            PopulateClientCmbo();
            PopulateSlctBook();
            PopulateSlctEvent();
            PopulateBookSlctEvent();
            PopulateBookSlctTrain();
            PopulateBookSlctAttendee();
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
        private void btnEdNewUserSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBxEdSlctUser.SelectedIndex == -1)
                {
                    UserClass userAddObj = new UserClass();
                    userAddObj.name = txtBxEdName.Text.Trim();
                    userAddObj.lastName = txtBxEdSurname.Text.Trim();
                    userAddObj.email = txtBxEdEmail.Text.Trim();
                    userAddObj.password = txtBxEdPassword.Text.Trim();
                    userAddObj.CreateUser();
                    txtBxUserID.Clear();
                    txtBxEdName.Clear();
                    txtBxEdSurname.Clear();
                    txtBxEdPassword.Clear();
                    txtBxEdEmail.Clear();
                    PopulateUserCmbo();
                }
                else
                {
                    MessageBox.Show("Sellected user alrady exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnEdUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBxEdSlctUser.SelectedIndex >= 0)
            {
                int index = cmbBxEdSlctUser.SelectedIndex;
                try
                {
                    UserClass userUpObj = new UserClass();
                    userUpObj.userID = Convert.ToInt32(txtBxUserID.Text);
                    userUpObj.name = txtBxEdName.Text.Trim();
                    userUpObj.lastName = txtBxEdSurname.Text.Trim();
                    userUpObj.email = txtBxEdEmail.Text.Trim();
                    userUpObj.password = txtBxEdPassword.Text.Trim();
                    userUpObj.UpdateUser(userUpObj.userID);
                    txtBxUserID.Clear();
                    txtBxEdName.Clear();
                    txtBxEdSurname.Clear();
                    txtBxEdPassword.Clear();
                    txtBxEdEmail.Clear();
                    PopulateUserCmbo();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmbBxEdSlctUser.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Please select existing user to update. To create a new account please use the submit butten.");
            }
        }
        private void btnEdDelete_Click(object sender, EventArgs e)
        {
            if (cmbBxEdSlctUser.SelectedIndex >= 0)
            {
                UserClass delUObj = new UserClass();
                if (txtBxUserID.Text != null)
                {
                    delUObj.userID = Convert.ToInt32(txtBxUserID.Text);
                    if (MessageBox.Show("Are you sure you wat to delete this user?", "Delete Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        delUObj.DeleteUser();
                        txtBxUserID.Clear();
                        txtBxEdName.Clear();
                        txtBxEdSurname.Clear();
                        txtBxEdPassword.Clear();
                        txtBxEdEmail.Clear();
                        PopulateUserCmbo();
                    }
                    else
                    {
                        txtBxUserID.Clear();
                        txtBxEdName.Clear();
                        txtBxEdSurname.Clear();
                        txtBxEdPassword.Clear();
                        txtBxEdEmail.Clear();
                        PopulateUserCmbo();
                    }
                }
                else
                {
                    MessageBox.Show("Please select existing user to Delete.");
                }
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
                    txtBxEdClientPassword.Clear();
                }
                sqlConn.sqlGlbConn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEdNewClientSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBxEdSlctClient.SelectedIndex == -1||txtBxEdClientName!=null)
                {
                    UserClass clientAddObj = new UserClass();
                    clientAddObj.name = txtBxEdClientName.Text.Trim();
                    clientAddObj.lastName = txtBxEdClientSurname.Text.Trim();
                    clientAddObj.email = txtBxEdClientEmail.Text.Trim();
                    clientAddObj.password = txtBxEdClientPassword.Text.Trim();
                    clientAddObj.CreateClient();
                    txtBxEdClientID.Clear();
                    txtBxEdClientName.Clear();
                    txtBxEdClientSurname.Clear();
                    txtBxEdClientPassword.Clear();
                    txtBxEdClientEmail.Clear();
                    PopulateUserCmbo();
                }
                else
                {
                    MessageBox.Show("Sellected Client alrady exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEdClientUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBxEdSlctClient.SelectedIndex >= 0)
            {
                int index = cmbBxEdSlctClient.SelectedIndex;
                try
                {
                    UserClass clientUpObj = new UserClass();
                    clientUpObj.clientID = Convert.ToInt32(txtBxEdClientID.Text);
                    clientUpObj.name = txtBxEdClientName.Text.Trim();
                    clientUpObj.lastName = txtBxEdClientSurname.Text.Trim();
                    clientUpObj.email = txtBxEdClientEmail.Text.Trim();
                    clientUpObj.password = txtBxEdClientPassword.Text.Trim();
                    clientUpObj.UpdateClient(clientUpObj.clientID);
                    txtBxEdClientID.Clear();
                    txtBxEdClientName.Clear();
                    txtBxEdClientSurname.Clear();
                    txtBxEdClientPassword.Clear();
                    txtBxEdClientEmail.Clear();
                    PopulateClientCmbo();
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                cmbBxEdSlctClient.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Please select existing user to update. To create a new account please use the submit butten.");
            }
        }
        private void btnEdClientDelete_Click(object sender, EventArgs e)
        {
            if (cmbBxEdSlctClient.SelectedIndex >= 0)
            {
                UserClass clientDelObj = new UserClass();
                if (txtBxEdClientID.Text != null)
                {
                    if (MessageBox.Show(this.ToString(), "Are you sure you wat to delete this user?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        clientDelObj.clientID = Convert.ToInt32(txtBxEdClientID.Text);
                        clientDelObj.DeleteClient();
                    }

                    txtBxEdClientID.Clear();
                    txtBxEdClientName.Clear();
                    txtBxEdClientSurname.Clear();
                    txtBxEdClientPassword.Clear();
                    txtBxEdClientEmail.Clear();
                    PopulateClientCmbo();
                }
                else
                {
                    MessageBox.Show("Please select existing client to Delete.");
                }

            }
        }
        private void btnEdCancel_Click(object sender, EventArgs e)
        {
            try
            {
                txtBxUserID.Clear();
                txtBxEdName.Clear();
                txtBxEdSurname.Clear();
                txtBxEdPassword.Clear();
                txtBxEdEmail.Clear();
                PopulateUserCmbo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEdClientCancel_Click(object sender, EventArgs e)
        {
            try
            {
                txtBxEdClientID.Clear();
                txtBxEdClientName.Clear();
                txtBxEdClientSurname.Clear();
                txtBxEdClientPassword.Clear();
                txtBxEdClientEmail.Clear();
                PopulateClientCmbo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                if (frmLogin.uType == 1)
                {
                    tabCtrlMain.Visible = true;
                    tabPgBooking.Visible = true;
                    tabPgClient.Visible = true;
                    tabPgEvent.Visible = true;
                    tabPgUser.Visible = true;
                }
                else if (frmLogin.uType == 2)
                {
                    tabCtrlMain.Visible = true;
                    tabCtrlMain.TabPages.Remove(tabPgUser);
                    tabCtrlMain.TabPages.Remove(tabPgEvent);
                    tabCtrlMain.TabPages.Remove(tabPgReporting);
                    menuStrip1.Items.Remove(userToolStripMenuItem);
                    menuStrip1.Items.Remove(eventToolStripMenuItem);
                    menuStrip1.Items.Remove(reprotingToolStripMenuItem);
                    lstBxBookAttendees.Visible = false;
                    cmbBxBookSlctEvent.Enabled = false;
                    cmbBxBookSlctTrain.Enabled = false;
                    txtBxBookingName.Enabled = false;
                    txtBxBookComments.Enabled = false;
                    btnBookCreate.Visible = false;
                    btnBookUpdate.Visible = false;
                    btnEdClientDelete.Visible = false;
                    btnEdNewClientSubmit.Visible = false;
                    radioBtnApproved.Enabled = false;
                    radioBtnNotApproved.Enabled = false;
                    lblBookAttendee.Visible = false;
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmClientSignUp frmClientSignUp = new frmClientSignUp();
            frmClientSignUp.ShowDialog();
        }

        private void cmbBxSlctBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sqlConn.sqlGlbConn.Open();
                sqlComm = new SqlCommand($"SELECT BookingID, BookingName, EventID, UserID, Aproved, Coments FROM tbBooking WHERE BookingName = '{cmbBxBookSlctBook.Text}'", sqlConn.sqlGlbConn);
                sqlDatRead = sqlComm.ExecuteReader();
                while (sqlDatRead.Read())
                {
                    txtBxBookingID.Text = sqlDatRead.GetValue(0).ToString();
                    txtBxBookingName.Text = sqlDatRead.GetValue(1).ToString();
                    cmbBxBookSlctEvent.Text = sqlDatRead.GetValue(2).ToString();
                    cmbBxBookSlctTrain.Text = sqlDatRead.GetValue(3).ToString();
                    if (sqlDatRead.GetValue(4).ToString() == "true")
                    {
                        radioBtnApproved.Checked = true;
                    }
                    else if (sqlDatRead.GetValue(4).ToString() == "false")
                    {
                        radioBtnNotApproved.Checked = true;
                    }
                    txtBxBookComments.Text = sqlDatRead.GetValue(5).ToString();
                }
                //sqlComm = new SqlCommand($"SELECT DISTINCT Name FROM tbBooking INNER JOIN tbClient ON tbBooking.ClientID = tbClient.ClientID WHERE BookingID = {cmbBxBookSlctBook.Text}", sqlConn.sqlGlbConn);
                //sqlDatRead = sqlComm.ExecuteReader();
                //while (sqlDatRead.Read())
                //{
                //    lstBxBookAttendees.Items.Clear();
                //    lstBxBookAttendees.Items.Add(sqlDatRead.GetString(0));
                //}
                sqlConn.sqlGlbConn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAttendee_Click(object sender, EventArgs e)
        {
            lstBxBookAttendees.Items.Add(cmbBxBookSlctClient.Text.ToString());
            //PopulateBookSlctAttendee();
        }

        private void btnBookCreate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                
                if (cmbBxBookSlctTrain.SelectedIndex >=0)
                {
                    sqlComm = new SqlCommand($"SELECT UserID FROM tbUser WHERE Name = '{cmbBxBookSlctTrain.Text}'", sqlConn.sqlGlbConn);
                    sqlDatRead = sqlComm.ExecuteReader();
                    while (sqlDatRead.Read())
                    {
                        slctUID = Convert.ToInt32(sqlDatRead.GetValue(0));
                    }
                }
                else if(cmbBxBookSlctClient.SelectedIndex >= 0)
                {
                    sqlComm = new SqlCommand($"SELECT ClientID FROM tbClient WHERE Name = '{cmbBxBookSlctClient.Text}'", sqlConn.sqlGlbConn);
                    sqlDatRead = sqlComm.ExecuteReader();
                    while (sqlDatRead.Read())
                    {
                        slctCID = Convert.ToInt32(sqlDatRead.GetValue(0));
                    }
                }
                else if (cmbBxBookSlctEvent.SelectedIndex >= 0)
                {
                    sqlComm = new SqlCommand($"SELECT EventID FROM tbEvent WHERE Name = '{cmbBxBookSlctEvent.Text}'", sqlConn.sqlGlbConn);
                    sqlDatRead = sqlComm.ExecuteReader();
                    while(sqlDatRead.Read())
                    {
                        slctEID = Convert.ToInt32(sqlDatRead.GetValue(0));
                    }
                }
                if (radioBtnApproved.Checked)
                {
                    slctBookStat = true;
                }
                else if (radioBtnNotApproved.Checked)
                {
                    slctBookStat = false;
                }
                if (cmbBxBookSlctBook.SelectedIndex == -1)
                {
                    BookingClass bookObj = new BookingClass();
                    bookObj.bookName = txtBxBookingName.Text;
                    bookObj.userID = slctUID;
                    bookObj.clientID = slctCID;
                    bookObj.eventID = slctEID;
                    bookObj.bookStat = slctBookStat;
                    bookObj.bookComments = txtBxBookComments.Text;
                    bookObj.CreatBooking();
                }
                else
                {
                    MessageBox.Show("Please Check all fields.");
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                if (frmLogin.uType == 1)
                {
                    tabCtrlMain.Visible = true;
                    tabPgBooking.Visible = true;
                    tabPgClient.Visible = true;
                    tabPgEvent.Visible = true;
                    tabPgUser.Visible = true;
                }
                else if (frmLogin.uType == 2)
                {
                    tabCtrlMain.Visible = true;
                    tabCtrlMain.TabPages.Remove(tabPgUser);
                    tabCtrlMain.TabPages.Remove(tabPgEvent);
                    tabCtrlMain.TabPages.Remove(tabPgReporting);
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabCtrlMain.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabCtrlMain.SelectTab(tabPgUser);
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabCtrlMain.SelectTab(tabPgClient);
        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabCtrlMain.SelectTab(tabPgEvent);
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabCtrlMain.SelectTab(tabPgBooking);
        }

        private void reprotingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabCtrlMain.SelectTab(tabPgReporting);
        }
    }
}
