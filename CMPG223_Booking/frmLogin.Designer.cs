namespace CMPG223_Booking
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBxLogin = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.grpBxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxLogin
            // 
            this.grpBxLogin.AutoSize = true;
            this.grpBxLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxLogin.Controls.Add(this.btnSignUp);
            this.grpBxLogin.Controls.Add(this.btnCancel);
            this.grpBxLogin.Controls.Add(this.btnLogin);
            this.grpBxLogin.Controls.Add(this.txtBxPassword);
            this.grpBxLogin.Controls.Add(this.txtBxUserName);
            this.grpBxLogin.Controls.Add(this.lblPassword);
            this.grpBxLogin.Controls.Add(this.lblUserName);
            this.grpBxLogin.Location = new System.Drawing.Point(20, 18);
            this.grpBxLogin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpBxLogin.Name = "grpBxLogin";
            this.grpBxLogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBxLogin.Size = new System.Drawing.Size(332, 142);
            this.grpBxLogin.TabIndex = 1;
            this.grpBxLogin.TabStop = false;
            this.grpBxLogin.Text = "User Login";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(116, 91);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 28);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(224, 91);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(8, 91);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(97, 59);
            this.txtBxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(225, 22);
            this.txtBxPassword.TabIndex = 3;
            this.txtBxPassword.UseSystemPasswordChar = true;
            // 
            // txtBxUserName
            // 
            this.txtBxUserName.Location = new System.Drawing.Point(97, 23);
            this.txtBxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxUserName.Name = "txtBxUserName";
            this.txtBxUserName.Size = new System.Drawing.Size(225, 22);
            this.txtBxUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 63);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(5, 27);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(372, 178);
            this.Controls.Add(this.grpBxLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.grpBxLogin.ResumeLayout(false);
            this.grpBxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
    }
}