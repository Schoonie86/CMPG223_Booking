namespace CMPG223_Booking
{
    partial class frmClientSignUp
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
            this.grtBxNewSignUp = new System.Windows.Forms.GroupBox();
            this.txtBxNewEmail = new System.Windows.Forms.TextBox();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.txtBxNewLastName = new System.Windows.Forms.TextBox();
            this.lblNewLastName = new System.Windows.Forms.Label();
            this.txtBxConfNewPass = new System.Windows.Forms.TextBox();
            this.lblNewClientConPass = new System.Windows.Forms.Label();
            this.btnSignCancel = new System.Windows.Forms.Button();
            this.btnCreateClint = new System.Windows.Forms.Button();
            this.txtBxNewPass = new System.Windows.Forms.TextBox();
            this.txtBxNewName = new System.Windows.Forms.TextBox();
            this.lblNewClintPassword = new System.Windows.Forms.Label();
            this.lblNewClient = new System.Windows.Forms.Label();
            this.grtBxNewSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grtBxNewSignUp
            // 
            this.grtBxNewSignUp.AutoSize = true;
            this.grtBxNewSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grtBxNewSignUp.Controls.Add(this.txtBxNewEmail);
            this.grtBxNewSignUp.Controls.Add(this.lblNewEmail);
            this.grtBxNewSignUp.Controls.Add(this.txtBxNewLastName);
            this.grtBxNewSignUp.Controls.Add(this.lblNewLastName);
            this.grtBxNewSignUp.Controls.Add(this.txtBxConfNewPass);
            this.grtBxNewSignUp.Controls.Add(this.lblNewClientConPass);
            this.grtBxNewSignUp.Controls.Add(this.btnSignCancel);
            this.grtBxNewSignUp.Controls.Add(this.btnCreateClint);
            this.grtBxNewSignUp.Controls.Add(this.txtBxNewPass);
            this.grtBxNewSignUp.Controls.Add(this.txtBxNewName);
            this.grtBxNewSignUp.Controls.Add(this.lblNewClintPassword);
            this.grtBxNewSignUp.Controls.Add(this.lblNewClient);
            this.grtBxNewSignUp.Location = new System.Drawing.Point(12, 12);
            this.grtBxNewSignUp.Name = "grtBxNewSignUp";
            this.grtBxNewSignUp.Size = new System.Drawing.Size(278, 191);
            this.grtBxNewSignUp.TabIndex = 2;
            this.grtBxNewSignUp.TabStop = false;
            this.grtBxNewSignUp.Text = "New Sign up";
            this.grtBxNewSignUp.Visible = false;
            // 
            // txtBxNewEmail
            // 
            this.txtBxNewEmail.Location = new System.Drawing.Point(114, 71);
            this.txtBxNewEmail.Name = "txtBxNewEmail";
            this.txtBxNewEmail.Size = new System.Drawing.Size(158, 20);
            this.txtBxNewEmail.TabIndex = 11;
            // 
            // lblNewEmail
            // 
            this.lblNewEmail.AutoSize = true;
            this.lblNewEmail.Location = new System.Drawing.Point(6, 75);
            this.lblNewEmail.Name = "lblNewEmail";
            this.lblNewEmail.Size = new System.Drawing.Size(32, 13);
            this.lblNewEmail.TabIndex = 10;
            this.lblNewEmail.Text = "Email";
            // 
            // txtBxNewLastName
            // 
            this.txtBxNewLastName.Location = new System.Drawing.Point(114, 45);
            this.txtBxNewLastName.Name = "txtBxNewLastName";
            this.txtBxNewLastName.Size = new System.Drawing.Size(158, 20);
            this.txtBxNewLastName.TabIndex = 9;
            // 
            // lblNewLastName
            // 
            this.lblNewLastName.AutoSize = true;
            this.lblNewLastName.Location = new System.Drawing.Point(6, 49);
            this.lblNewLastName.Name = "lblNewLastName";
            this.lblNewLastName.Size = new System.Drawing.Size(52, 13);
            this.lblNewLastName.TabIndex = 8;
            this.lblNewLastName.Text = "Surname:";
            // 
            // txtBxConfNewPass
            // 
            this.txtBxConfNewPass.Location = new System.Drawing.Point(114, 123);
            this.txtBxConfNewPass.Name = "txtBxConfNewPass";
            this.txtBxConfNewPass.Size = new System.Drawing.Size(158, 20);
            this.txtBxConfNewPass.TabIndex = 7;
            this.txtBxConfNewPass.UseSystemPasswordChar = true;
            // 
            // lblNewClientConPass
            // 
            this.lblNewClientConPass.AutoSize = true;
            this.lblNewClientConPass.Location = new System.Drawing.Point(7, 126);
            this.lblNewClientConPass.Name = "lblNewClientConPass";
            this.lblNewClientConPass.Size = new System.Drawing.Size(91, 13);
            this.lblNewClientConPass.TabIndex = 6;
            this.lblNewClientConPass.Text = "Confirm Password";
            // 
            // btnSignCancel
            // 
            this.btnSignCancel.Location = new System.Drawing.Point(197, 149);
            this.btnSignCancel.Name = "btnSignCancel";
            this.btnSignCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSignCancel.TabIndex = 5;
            this.btnSignCancel.Text = "Cancel";
            this.btnSignCancel.UseVisualStyleBackColor = true;
            this.btnSignCancel.Click += new System.EventHandler(this.btnSignCancel_Click);
            // 
            // btnCreateClint
            // 
            this.btnCreateClint.Location = new System.Drawing.Point(6, 149);
            this.btnCreateClint.Name = "btnCreateClint";
            this.btnCreateClint.Size = new System.Drawing.Size(75, 23);
            this.btnCreateClint.TabIndex = 4;
            this.btnCreateClint.Text = "Submit";
            this.btnCreateClint.UseVisualStyleBackColor = true;
            this.btnCreateClint.Click += new System.EventHandler(this.btnCreateClint_Click);
            // 
            // txtBxNewPass
            // 
            this.txtBxNewPass.Location = new System.Drawing.Point(114, 97);
            this.txtBxNewPass.Name = "txtBxNewPass";
            this.txtBxNewPass.Size = new System.Drawing.Size(158, 20);
            this.txtBxNewPass.TabIndex = 3;
            this.txtBxNewPass.UseSystemPasswordChar = true;
            // 
            // txtBxNewName
            // 
            this.txtBxNewName.Location = new System.Drawing.Point(114, 19);
            this.txtBxNewName.Name = "txtBxNewName";
            this.txtBxNewName.Size = new System.Drawing.Size(158, 20);
            this.txtBxNewName.TabIndex = 2;
            // 
            // lblNewClintPassword
            // 
            this.lblNewClintPassword.AutoSize = true;
            this.lblNewClintPassword.Location = new System.Drawing.Point(7, 100);
            this.lblNewClintPassword.Name = "lblNewClintPassword";
            this.lblNewClintPassword.Size = new System.Drawing.Size(53, 13);
            this.lblNewClintPassword.TabIndex = 1;
            this.lblNewClintPassword.Text = "Password";
            // 
            // lblNewClient
            // 
            this.lblNewClient.AutoSize = true;
            this.lblNewClient.Location = new System.Drawing.Point(6, 22);
            this.lblNewClient.Name = "lblNewClient";
            this.lblNewClient.Size = new System.Drawing.Size(38, 13);
            this.lblNewClient.TabIndex = 0;
            this.lblNewClient.Text = "Name:";
            // 
            // frmClientSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnSignCancel;
            this.ClientSize = new System.Drawing.Size(306, 216);
            this.Controls.Add(this.grtBxNewSignUp);
            this.Name = "frmClientSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Sign up";
            this.grtBxNewSignUp.ResumeLayout(false);
            this.grtBxNewSignUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grtBxNewSignUp;
        private System.Windows.Forms.TextBox txtBxNewLastName;
        private System.Windows.Forms.Label lblNewLastName;
        private System.Windows.Forms.TextBox txtBxConfNewPass;
        private System.Windows.Forms.Label lblNewClientConPass;
        private System.Windows.Forms.Button btnSignCancel;
        private System.Windows.Forms.Button btnCreateClint;
        private System.Windows.Forms.TextBox txtBxNewPass;
        private System.Windows.Forms.TextBox txtBxNewName;
        private System.Windows.Forms.Label lblNewClintPassword;
        private System.Windows.Forms.Label lblNewClient;
        private System.Windows.Forms.TextBox txtBxNewEmail;
        private System.Windows.Forms.Label lblNewEmail;
    }
}