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
    public partial class frmClientSignUp : Form
    {
        public frmClientSignUp()
        {
            InitializeComponent();
        }

        private void btnCreateClint_Click(object sender, EventArgs e)
        {
            try
            {
                UserClass ClientCreate = new UserClass();
                ClientCreate.name = txtBxNewName.Text;
                ClientCreate.lastName = txtBxNewLastName.Text;
                ClientCreate.email = txtBxNewEmail.Text;
                if (txtBxNewPass.Text == txtBxConfNewPass.Text)
                {
                    ClientCreate.password = txtBxNewPass.Text;
                    ClientCreate.CreateClient();
                    MessageBox.Show("Account created successfully.");
                }
                else
                {
                    MessageBox.Show("Password did not mach, Please try again.");
                }
                MessageBox.Show("Please Login with the new account");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSignCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }
    }
}
