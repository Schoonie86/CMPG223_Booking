using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMPG223_Booking.Classes;

namespace CMPG223_Booking
{
    public partial class frmLogin : Form
    {   
        public int uType = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   
            int logName = Convert.ToInt32(txtBxUserName.Text);
            string logPass = txtBxPassword.ToString();
            
            UserClass login = new UserClass();
            login.ID = logName;
            login.password = logPass;

            if (txtBxUserName.ToString().StartsWith("1"))
            {
                login.UserValidation(logName, logPass);
                uType = 1;
                this.Hide();
            }
            else if (txtBxUserName.ToString().StartsWith("2"))
            {
                login.ClientValidation(logName, logPass);
                uType = 2;
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmClientSignUp frmSignUp = new frmClientSignUp();
            frmSignUp.ShowDialog();
            this.Hide();
        }

        
    }
}
