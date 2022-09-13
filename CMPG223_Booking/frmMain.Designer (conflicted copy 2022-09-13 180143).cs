namespace CMPG223_Booking
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprotingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabPgLogin = new System.Windows.Forms.TabPage();
            this.grtBxNewClient = new System.Windows.Forms.GroupBox();
            this.txtBxConNewUserPass = new System.Windows.Forms.TextBox();
            this.lblConPass = new System.Windows.Forms.Label();
            this.btnSignCancel = new System.Windows.Forms.Button();
            this.btnCreateClint = new System.Windows.Forms.Button();
            this.txtBxNewUserPass = new System.Windows.Forms.TextBox();
            this.txtBxNewUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBxLogin = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tabPgUser = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lstBxSlctUser = new System.Windows.Forms.ListBox();
            this.lblSlctUser = new System.Windows.Forms.Label();
            this.tabPgClient = new System.Windows.Forms.TabPage();
            this.tabPgEvent = new System.Windows.Forms.TabPage();
            this.tabPgBooking = new System.Windows.Forms.TabPage();
            this.tabPgReporting = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabPgLogin.SuspendLayout();
            this.grtBxNewClient.SuspendLayout();
            this.grpBxLogin.SuspendLayout();
            this.tabPgUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.reprotingToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // reprotingToolStripMenuItem
            // 
            this.reprotingToolStripMenuItem.Name = "reprotingToolStripMenuItem";
            this.reprotingToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.reprotingToolStripMenuItem.Text = "Reproting";
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabPgLogin);
            this.tabCtrlMain.Controls.Add(this.tabPgUser);
            this.tabCtrlMain.Controls.Add(this.tabPgClient);
            this.tabCtrlMain.Controls.Add(this.tabPgEvent);
            this.tabCtrlMain.Controls.Add(this.tabPgBooking);
            this.tabCtrlMain.Controls.Add(this.tabPgReporting);
            this.tabCtrlMain.Location = new System.Drawing.Point(13, 28);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(775, 410);
            this.tabCtrlMain.TabIndex = 1;
            // 
            // tabPgLogin
            // 
            this.tabPgLogin.AutoScroll = true;
            this.tabPgLogin.Controls.Add(this.grtBxNewClient);
            this.tabPgLogin.Controls.Add(this.grpBxLogin);
            this.tabPgLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPgLogin.Name = "tabPgLogin";
            this.tabPgLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgLogin.Size = new System.Drawing.Size(767, 384);
            this.tabPgLogin.TabIndex = 0;
            this.tabPgLogin.Text = "Login";
            this.tabPgLogin.UseVisualStyleBackColor = true;
            // 
            // grtBxNewClient
            // 
            this.grtBxNewClient.AutoSize = true;
            this.grtBxNewClient.Controls.Add(this.txtBxConNewUserPass);
            this.grtBxNewClient.Controls.Add(this.lblConPass);
            this.grtBxNewClient.Controls.Add(this.btnSignCancel);
            this.grtBxNewClient.Controls.Add(this.btnCreateClint);
            this.grtBxNewClient.Controls.Add(this.txtBxNewUserPass);
            this.grtBxNewClient.Controls.Add(this.txtBxNewUserName);
            this.grtBxNewClient.Controls.Add(this.label1);
            this.grtBxNewClient.Controls.Add(this.label2);
            this.grtBxNewClient.Location = new System.Drawing.Point(267, 6);
            this.grtBxNewClient.Name = "grtBxNewClient";
            this.grtBxNewClient.Size = new System.Drawing.Size(278, 172);
            this.grtBxNewClient.TabIndex = 1;
            this.grtBxNewClient.TabStop = false;
            this.grtBxNewClient.Text = "Client Sign up";
            this.grtBxNewClient.Visible = false;
            // 
            // txtBxConNewUserPass
            // 
            this.txtBxConNewUserPass.Location = new System.Drawing.Point(114, 91);
            this.txtBxConNewUserPass.Name = "txtBxConNewUserPass";
            this.txtBxConNewUserPass.Size = new System.Drawing.Size(158, 20);
            this.txtBxConNewUserPass.TabIndex = 7;
            this.txtBxConNewUserPass.UseSystemPasswordChar = true;
            // 
            // lblConPass
            // 
            this.lblConPass.AutoSize = true;
            this.lblConPass.Location = new System.Drawing.Point(7, 94);
            this.lblConPass.Name = "lblConPass";
            this.lblConPass.Size = new System.Drawing.Size(91, 13);
            this.lblConPass.TabIndex = 6;
            this.lblConPass.Text = "Confirm Password";
            // 
            // btnSignCancel
            // 
            this.btnSignCancel.Location = new System.Drawing.Point(197, 130);
            this.btnSignCancel.Name = "btnSignCancel";
            this.btnSignCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSignCancel.TabIndex = 5;
            this.btnSignCancel.Text = "Cancel";
            this.btnSignCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreateClint
            // 
            this.btnCreateClint.Location = new System.Drawing.Point(6, 130);
            this.btnCreateClint.Name = "btnCreateClint";
            this.btnCreateClint.Size = new System.Drawing.Size(75, 23);
            this.btnCreateClint.TabIndex = 4;
            this.btnCreateClint.Text = "Submit";
            this.btnCreateClint.UseVisualStyleBackColor = true;
            // 
            // txtBxNewUserPass
            // 
            this.txtBxNewUserPass.Location = new System.Drawing.Point(114, 65);
            this.txtBxNewUserPass.Name = "txtBxNewUserPass";
            this.txtBxNewUserPass.Size = new System.Drawing.Size(158, 20);
            this.txtBxNewUserPass.TabIndex = 3;
            this.txtBxNewUserPass.UseSystemPasswordChar = true;
            // 
            // txtBxNewUserName
            // 
            this.txtBxNewUserName.Location = new System.Drawing.Point(114, 36);
            this.txtBxNewUserName.Name = "txtBxNewUserName";
            this.txtBxNewUserName.Size = new System.Drawing.Size(158, 20);
            this.txtBxNewUserName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name:";
            // 
            // grpBxLogin
            // 
            this.grpBxLogin.AutoSize = true;
            this.grpBxLogin.Controls.Add(this.btnSignUp);
            this.grpBxLogin.Controls.Add(this.btnCancel);
            this.grpBxLogin.Controls.Add(this.btnLogin);
            this.grpBxLogin.Controls.Add(this.txtBxPassword);
            this.grpBxLogin.Controls.Add(this.txtBxUserName);
            this.grpBxLogin.Controls.Add(this.lblPassword);
            this.grpBxLogin.Controls.Add(this.lblUserName);
            this.grpBxLogin.Location = new System.Drawing.Point(6, 3);
            this.grpBxLogin.Name = "grpBxLogin";
            this.grpBxLogin.Size = new System.Drawing.Size(255, 143);
            this.grpBxLogin.TabIndex = 0;
            this.grpBxLogin.TabStop = false;
            this.grpBxLogin.Text = "User Login";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(91, 101);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(10, 101);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(75, 65);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(158, 20);
            this.txtBxPassword.TabIndex = 3;
            this.txtBxPassword.UseSystemPasswordChar = true;
            // 
            // txtBxUserName
            // 
            this.txtBxUserName.Location = new System.Drawing.Point(75, 36);
            this.txtBxUserName.Name = "txtBxUserName";
            this.txtBxUserName.Size = new System.Drawing.Size(158, 20);
            this.txtBxUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 68);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 39);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name:";
            // 
            // tabPgUser
            // 
            this.tabPgUser.Controls.Add(this.textBox1);
            this.tabPgUser.Controls.Add(this.lblUserID);
            this.tabPgUser.Controls.Add(this.lstBxSlctUser);
            this.tabPgUser.Controls.Add(this.lblSlctUser);
            this.tabPgUser.Location = new System.Drawing.Point(4, 22);
            this.tabPgUser.Name = "tabPgUser";
            this.tabPgUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgUser.Size = new System.Drawing.Size(767, 384);
            this.tabPgUser.TabIndex = 1;
            this.tabPgUser.Text = "User";
            this.tabPgUser.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(10, 39);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(43, 13);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "User ID";
            // 
            // lstBxSlctUser
            // 
            this.lstBxSlctUser.FormattingEnabled = true;
            this.lstBxSlctUser.Location = new System.Drawing.Point(76, 7);
            this.lstBxSlctUser.Name = "lstBxSlctUser";
            this.lstBxSlctUser.Size = new System.Drawing.Size(180, 17);
            this.lstBxSlctUser.TabIndex = 1;
            // 
            // lblSlctUser
            // 
            this.lblSlctUser.AutoSize = true;
            this.lblSlctUser.Location = new System.Drawing.Point(7, 7);
            this.lblSlctUser.Name = "lblSlctUser";
            this.lblSlctUser.Size = new System.Drawing.Size(62, 13);
            this.lblSlctUser.TabIndex = 0;
            this.lblSlctUser.Text = "Select User";
            // 
            // tabPgClient
            // 
            this.tabPgClient.Location = new System.Drawing.Point(4, 22);
            this.tabPgClient.Name = "tabPgClient";
            this.tabPgClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgClient.Size = new System.Drawing.Size(767, 384);
            this.tabPgClient.TabIndex = 2;
            this.tabPgClient.Text = "Client";
            this.tabPgClient.UseVisualStyleBackColor = true;
            // 
            // tabPgEvent
            // 
            this.tabPgEvent.Location = new System.Drawing.Point(4, 22);
            this.tabPgEvent.Name = "tabPgEvent";
            this.tabPgEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgEvent.Size = new System.Drawing.Size(767, 384);
            this.tabPgEvent.TabIndex = 3;
            this.tabPgEvent.Text = "Event";
            this.tabPgEvent.UseVisualStyleBackColor = true;
            // 
            // tabPgBooking
            // 
            this.tabPgBooking.Location = new System.Drawing.Point(4, 22);
            this.tabPgBooking.Name = "tabPgBooking";
            this.tabPgBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgBooking.Size = new System.Drawing.Size(767, 384);
            this.tabPgBooking.TabIndex = 4;
            this.tabPgBooking.Text = "Booking";
            this.tabPgBooking.UseVisualStyleBackColor = true;
            // 
            // tabPgReporting
            // 
            this.tabPgReporting.Location = new System.Drawing.Point(4, 22);
            this.tabPgReporting.Name = "tabPgReporting";
            this.tabPgReporting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgReporting.Size = new System.Drawing.Size(767, 384);
            this.tabPgReporting.TabIndex = 5;
            this.tabPgReporting.Text = "Reporting";
            this.tabPgReporting.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCtrlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabCtrlMain.ResumeLayout(false);
            this.tabPgLogin.ResumeLayout(false);
            this.tabPgLogin.PerformLayout();
            this.grtBxNewClient.ResumeLayout(false);
            this.grtBxNewClient.PerformLayout();
            this.grpBxLogin.ResumeLayout(false);
            this.grpBxLogin.PerformLayout();
            this.tabPgUser.ResumeLayout(false);
            this.tabPgUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprotingToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabPgLogin;
        private System.Windows.Forms.GroupBox grtBxNewClient;
        private System.Windows.Forms.TextBox txtBxConNewUserPass;
        private System.Windows.Forms.Label lblConPass;
        private System.Windows.Forms.Button btnSignCancel;
        private System.Windows.Forms.Button btnCreateClint;
        private System.Windows.Forms.TextBox txtBxNewUserPass;
        private System.Windows.Forms.TextBox txtBxNewUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBxLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TabPage tabPgUser;
        private System.Windows.Forms.TabPage tabPgClient;
        private System.Windows.Forms.TabPage tabPgEvent;
        private System.Windows.Forms.TabPage tabPgBooking;
        private System.Windows.Forms.TabPage tabPgReporting;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblSlctUser;
        private System.Windows.Forms.ListBox lstBxSlctUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUserID;
    }
}

