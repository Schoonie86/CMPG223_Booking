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
            this.grpBxLogin = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.grtBxNewSignUp = new System.Windows.Forms.GroupBox();
            this.txtBxConfNewPass = new System.Windows.Forms.TextBox();
            this.lblNewClientConPass = new System.Windows.Forms.Label();
            this.btnSignCancel = new System.Windows.Forms.Button();
            this.btnCreateClint = new System.Windows.Forms.Button();
            this.txtBxNewPass = new System.Windows.Forms.TextBox();
            this.txtBxNewUserName = new System.Windows.Forms.TextBox();
            this.lblNewClintPassword = new System.Windows.Forms.Label();
            this.lblNewClient = new System.Windows.Forms.Label();
            this.tabPgUser = new System.Windows.Forms.TabPage();
            this.grpBxEdUser = new System.Windows.Forms.GroupBox();
            this.cmbBxEdSlctUser = new System.Windows.Forms.ComboBox();
            this.btnEdDelete = new System.Windows.Forms.Button();
            this.btnEdNewUserSubmit = new System.Windows.Forms.Button();
            this.btnEdCancel = new System.Windows.Forms.Button();
            this.btnEdUpdate = new System.Windows.Forms.Button();
            this.lblSlctUser = new System.Windows.Forms.Label();
            this.txtBxEdPassword = new System.Windows.Forms.TextBox();
            this.lblEdPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtBxEdEmail = new System.Windows.Forms.TextBox();
            this.txtBxUserID = new System.Windows.Forms.TextBox();
            this.lblEdEmail = new System.Windows.Forms.Label();
            this.lblEdName = new System.Windows.Forms.Label();
            this.txtBxEdSurname = new System.Windows.Forms.TextBox();
            this.txtBxEdName = new System.Windows.Forms.TextBox();
            this.lblEdSername = new System.Windows.Forms.Label();
            this.tabPgClient = new System.Windows.Forms.TabPage();
            this.grpBxEdClient = new System.Windows.Forms.GroupBox();
            this.cmbBxEdSlctClient = new System.Windows.Forms.ComboBox();
            this.btnEdClientDelete = new System.Windows.Forms.Button();
            this.btnEdNewClientSubmit = new System.Windows.Forms.Button();
            this.btnEdClientCancel = new System.Windows.Forms.Button();
            this.btnEdClientUpdate = new System.Windows.Forms.Button();
            this.lblEdSlctClient = new System.Windows.Forms.Label();
            this.txtBxEdClientPassword = new System.Windows.Forms.TextBox();
            this.lblEdClientPassword = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxEdClientEmail = new System.Windows.Forms.TextBox();
            this.txtBxEdClientID = new System.Windows.Forms.TextBox();
            this.lblEdClientEmail = new System.Windows.Forms.Label();
            this.lblEdClientName = new System.Windows.Forms.Label();
            this.txtBxEdClientSurname = new System.Windows.Forms.TextBox();
            this.txtBxEdClientName = new System.Windows.Forms.TextBox();
            this.lblEdClientSername = new System.Windows.Forms.Label();
            this.tabPgEvent = new System.Windows.Forms.TabPage();
            this.grpBxEvent = new System.Windows.Forms.GroupBox();
            this.dtPckrEventEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventEndDate = new System.Windows.Forms.Label();
            this.cmbBxEventEndTime = new System.Windows.Forms.ComboBox();
            this.cmbBxEventStartTime = new System.Windows.Forms.ComboBox();
            this.radioBtnExam = new System.Windows.Forms.RadioButton();
            this.radioBtnTraining = new System.Windows.Forms.RadioButton();
            this.cmbBxSelectEvent = new System.Windows.Forms.ComboBox();
            this.lblEventEndTime = new System.Windows.Forms.Label();
            this.txtBxEventName = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.dtPckrEventStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnEventDelete = new System.Windows.Forms.Button();
            this.btnNewEventSubmit = new System.Windows.Forms.Button();
            this.btnEventCancle = new System.Windows.Forms.Button();
            this.btnEventUpdate = new System.Windows.Forms.Button();
            this.lblEventStartDate = new System.Windows.Forms.Label();
            this.lblEventStartTime = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblSelectEvent = new System.Windows.Forms.Label();
            this.txtBxEventID = new System.Windows.Forms.TextBox();
            this.lblEventID = new System.Windows.Forms.Label();
            this.tabPgBooking = new System.Windows.Forms.TabPage();
            this.grpBxBooking = new System.Windows.Forms.GroupBox();
            this.radioBtnNotApproved = new System.Windows.Forms.RadioButton();
            this.radioBtnApproved = new System.Windows.Forms.RadioButton();
            this.lblBookApprove = new System.Windows.Forms.Label();
            this.btnOpenAttendeeList = new System.Windows.Forms.Button();
            this.lstBxBookClients = new System.Windows.Forms.ListBox();
            this.btnAddAttendees = new System.Windows.Forms.Button();
            this.lblBookAttendees = new System.Windows.Forms.Label();
            this.lstBxBookAttendees = new System.Windows.Forms.ListBox();
            this.cmbBxBookTrainerSelect = new System.Windows.Forms.ComboBox();
            this.lblBookTrainer = new System.Windows.Forms.Label();
            this.cmbBxBookEventSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblBookComments = new System.Windows.Forms.Label();
            this.cmbBxSlctBooking = new System.Windows.Forms.ComboBox();
            this.lblSlctBooking = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBookingName = new System.Windows.Forms.Label();
            this.txtBxBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.tabPgReporting = new System.Windows.Forms.TabPage();
            this.grpBxReporting = new System.Windows.Forms.GroupBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabPgLogin.SuspendLayout();
            this.grpBxLogin.SuspendLayout();
            this.grtBxNewSignUp.SuspendLayout();
            this.tabPgUser.SuspendLayout();
            this.grpBxEdUser.SuspendLayout();
            this.tabPgClient.SuspendLayout();
            this.grpBxEdClient.SuspendLayout();
            this.tabPgEvent.SuspendLayout();
            this.grpBxEvent.SuspendLayout();
            this.tabPgBooking.SuspendLayout();
            this.grpBxBooking.SuspendLayout();
            this.tabPgReporting.SuspendLayout();
            this.grpBxReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1246, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 34);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.userToolStripMenuItem.Text = "User";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // reprotingToolStripMenuItem
            // 
            this.reprotingToolStripMenuItem.Name = "reprotingToolStripMenuItem";
            this.reprotingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.HotTrack = true;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 48);
            this.tabCtrlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(1246, 710);
            this.tabCtrlMain.TabIndex = 1;
            // 
            // tabPgLogin
            // 
            this.tabPgLogin.AutoScroll = true;
            this.tabPgLogin.Controls.Add(this.grpBxLogin);
            this.tabPgLogin.Controls.Add(this.grtBxNewSignUp);
            this.tabPgLogin.Location = new System.Drawing.Point(4, 25);
            this.tabPgLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgLogin.Name = "tabPgLogin";
            this.tabPgLogin.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgLogin.Size = new System.Drawing.Size(989, 549);
            this.tabPgLogin.TabIndex = 0;
            this.tabPgLogin.Text = "Login";
            this.tabPgLogin.UseVisualStyleBackColor = true;
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
            this.grpBxLogin.Location = new System.Drawing.Point(8, 7);
            this.grpBxLogin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpBxLogin.Name = "grpBxLogin";
            this.grpBxLogin.Padding = new System.Windows.Forms.Padding(4);
            this.grpBxLogin.Size = new System.Drawing.Size(332, 175);
            this.grpBxLogin.TabIndex = 0;
            this.grpBxLogin.TabStop = false;
            this.grpBxLogin.Text = "User Login";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(116, 124);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 28);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 124);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(8, 124);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(97, 59);
            this.txtBxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(209, 22);
            this.txtBxPassword.TabIndex = 3;
            this.txtBxPassword.UseSystemPasswordChar = true;
            // 
            // txtBxUserName
            // 
            this.txtBxUserName.Location = new System.Drawing.Point(97, 23);
            this.txtBxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxUserName.Name = "txtBxUserName";
            this.txtBxUserName.Size = new System.Drawing.Size(209, 22);
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
            // grtBxNewSignUp
            // 
            this.grtBxNewSignUp.AutoSize = true;
            this.grtBxNewSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grtBxNewSignUp.Controls.Add(this.txtBxConfNewPass);
            this.grtBxNewSignUp.Controls.Add(this.lblNewClientConPass);
            this.grtBxNewSignUp.Controls.Add(this.btnSignCancel);
            this.grtBxNewSignUp.Controls.Add(this.btnCreateClint);
            this.grtBxNewSignUp.Controls.Add(this.txtBxNewPass);
            this.grtBxNewSignUp.Controls.Add(this.txtBxNewUserName);
            this.grtBxNewSignUp.Controls.Add(this.lblNewClintPassword);
            this.grtBxNewSignUp.Controls.Add(this.lblNewClient);
            this.grtBxNewSignUp.Location = new System.Drawing.Point(355, 8);
            this.grtBxNewSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.grtBxNewSignUp.Name = "grtBxNewSignUp";
            this.grtBxNewSignUp.Padding = new System.Windows.Forms.Padding(4);
            this.grtBxNewSignUp.Size = new System.Drawing.Size(371, 174);
            this.grtBxNewSignUp.TabIndex = 1;
            this.grtBxNewSignUp.TabStop = false;
            this.grtBxNewSignUp.Text = "New Sign up";
            // 
            // txtBxConfNewPass
            // 
            this.txtBxConfNewPass.Location = new System.Drawing.Point(152, 91);
            this.txtBxConfNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxConfNewPass.Name = "txtBxConfNewPass";
            this.txtBxConfNewPass.Size = new System.Drawing.Size(209, 22);
            this.txtBxConfNewPass.TabIndex = 7;
            this.txtBxConfNewPass.UseSystemPasswordChar = true;
            // 
            // lblNewClientConPass
            // 
            this.lblNewClientConPass.AutoSize = true;
            this.lblNewClientConPass.Location = new System.Drawing.Point(9, 95);
            this.lblNewClientConPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewClientConPass.Name = "lblNewClientConPass";
            this.lblNewClientConPass.Size = new System.Drawing.Size(115, 16);
            this.lblNewClientConPass.TabIndex = 6;
            this.lblNewClientConPass.Text = "Confirm Password";
            // 
            // btnSignCancel
            // 
            this.btnSignCancel.Location = new System.Drawing.Point(263, 123);
            this.btnSignCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignCancel.Name = "btnSignCancel";
            this.btnSignCancel.Size = new System.Drawing.Size(100, 28);
            this.btnSignCancel.TabIndex = 5;
            this.btnSignCancel.Text = "Cancel";
            this.btnSignCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreateClint
            // 
            this.btnCreateClint.Location = new System.Drawing.Point(8, 123);
            this.btnCreateClint.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateClint.Name = "btnCreateClint";
            this.btnCreateClint.Size = new System.Drawing.Size(100, 28);
            this.btnCreateClint.TabIndex = 4;
            this.btnCreateClint.Text = "Submit";
            this.btnCreateClint.UseVisualStyleBackColor = true;
            // 
            // txtBxNewPass
            // 
            this.txtBxNewPass.Location = new System.Drawing.Point(152, 59);
            this.txtBxNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxNewPass.Name = "txtBxNewPass";
            this.txtBxNewPass.Size = new System.Drawing.Size(209, 22);
            this.txtBxNewPass.TabIndex = 3;
            this.txtBxNewPass.UseSystemPasswordChar = true;
            // 
            // txtBxNewUserName
            // 
            this.txtBxNewUserName.Location = new System.Drawing.Point(152, 23);
            this.txtBxNewUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxNewUserName.Name = "txtBxNewUserName";
            this.txtBxNewUserName.Size = new System.Drawing.Size(209, 22);
            this.txtBxNewUserName.TabIndex = 2;
            // 
            // lblNewClintPassword
            // 
            this.lblNewClintPassword.AutoSize = true;
            this.lblNewClintPassword.Location = new System.Drawing.Point(9, 63);
            this.lblNewClintPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewClintPassword.Name = "lblNewClintPassword";
            this.lblNewClintPassword.Size = new System.Drawing.Size(67, 16);
            this.lblNewClintPassword.TabIndex = 1;
            this.lblNewClintPassword.Text = "Password";
            // 
            // lblNewClient
            // 
            this.lblNewClient.AutoSize = true;
            this.lblNewClient.Location = new System.Drawing.Point(8, 27);
            this.lblNewClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewClient.Name = "lblNewClient";
            this.lblNewClient.Size = new System.Drawing.Size(79, 16);
            this.lblNewClient.TabIndex = 0;
            this.lblNewClient.Text = "User Name:";
            // 
            // tabPgUser
            // 
            this.tabPgUser.Controls.Add(this.grpBxEdUser);
            this.tabPgUser.Location = new System.Drawing.Point(4, 25);
            this.tabPgUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgUser.Name = "tabPgUser";
            this.tabPgUser.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgUser.Size = new System.Drawing.Size(989, 549);
            this.tabPgUser.TabIndex = 1;
            this.tabPgUser.Text = "User";
            this.tabPgUser.UseVisualStyleBackColor = true;
            // 
            // grpBxEdUser
            // 
            this.grpBxEdUser.AutoSize = true;
            this.grpBxEdUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxEdUser.Controls.Add(this.cmbBxEdSlctUser);
            this.grpBxEdUser.Controls.Add(this.btnEdDelete);
            this.grpBxEdUser.Controls.Add(this.btnEdNewUserSubmit);
            this.grpBxEdUser.Controls.Add(this.btnEdCancel);
            this.grpBxEdUser.Controls.Add(this.btnEdUpdate);
            this.grpBxEdUser.Controls.Add(this.lblSlctUser);
            this.grpBxEdUser.Controls.Add(this.txtBxEdPassword);
            this.grpBxEdUser.Controls.Add(this.lblEdPassword);
            this.grpBxEdUser.Controls.Add(this.lblUserID);
            this.grpBxEdUser.Controls.Add(this.txtBxEdEmail);
            this.grpBxEdUser.Controls.Add(this.txtBxUserID);
            this.grpBxEdUser.Controls.Add(this.lblEdEmail);
            this.grpBxEdUser.Controls.Add(this.lblEdName);
            this.grpBxEdUser.Controls.Add(this.txtBxEdSurname);
            this.grpBxEdUser.Controls.Add(this.txtBxEdName);
            this.grpBxEdUser.Controls.Add(this.lblEdSername);
            this.grpBxEdUser.Location = new System.Drawing.Point(7, 6);
            this.grpBxEdUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxEdUser.Name = "grpBxEdUser";
            this.grpBxEdUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxEdUser.Size = new System.Drawing.Size(391, 296);
            this.grpBxEdUser.TabIndex = 12;
            this.grpBxEdUser.TabStop = false;
            this.grpBxEdUser.Text = "User";
            // 
            // cmbBxEdSlctUser
            // 
            this.cmbBxEdSlctUser.FormattingEnabled = true;
            this.cmbBxEdSlctUser.Location = new System.Drawing.Point(99, 32);
            this.cmbBxEdSlctUser.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxEdSlctUser.Name = "cmbBxEdSlctUser";
            this.cmbBxEdSlctUser.Size = new System.Drawing.Size(285, 24);
            this.cmbBxEdSlctUser.TabIndex = 16;
            // 
            // btnEdDelete
            // 
            this.btnEdDelete.Location = new System.Drawing.Point(263, 225);
            this.btnEdDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdDelete.Name = "btnEdDelete";
            this.btnEdDelete.Size = new System.Drawing.Size(121, 23);
            this.btnEdDelete.TabIndex = 14;
            this.btnEdDelete.Text = "Delete";
            this.btnEdDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdNewUserSubmit
            // 
            this.btnEdNewUserSubmit.Location = new System.Drawing.Point(11, 225);
            this.btnEdNewUserSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdNewUserSubmit.Name = "btnEdNewUserSubmit";
            this.btnEdNewUserSubmit.Size = new System.Drawing.Size(121, 23);
            this.btnEdNewUserSubmit.TabIndex = 13;
            this.btnEdNewUserSubmit.Text = "Submit";
            this.btnEdNewUserSubmit.UseVisualStyleBackColor = true;
            // 
            // btnEdCancel
            // 
            this.btnEdCancel.Location = new System.Drawing.Point(263, 254);
            this.btnEdCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdCancel.Name = "btnEdCancel";
            this.btnEdCancel.Size = new System.Drawing.Size(121, 23);
            this.btnEdCancel.TabIndex = 13;
            this.btnEdCancel.Text = "Cancel";
            this.btnEdCancel.UseVisualStyleBackColor = true;
            // 
            // btnEdUpdate
            // 
            this.btnEdUpdate.Location = new System.Drawing.Point(137, 225);
            this.btnEdUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdUpdate.Name = "btnEdUpdate";
            this.btnEdUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnEdUpdate.TabIndex = 12;
            this.btnEdUpdate.Text = "Update";
            this.btnEdUpdate.UseVisualStyleBackColor = true;
            // 
            // lblSlctUser
            // 
            this.lblSlctUser.AutoSize = true;
            this.lblSlctUser.Location = new System.Drawing.Point(7, 36);
            this.lblSlctUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSlctUser.Name = "lblSlctUser";
            this.lblSlctUser.Size = new System.Drawing.Size(77, 16);
            this.lblSlctUser.TabIndex = 0;
            this.lblSlctUser.Text = "Select User";
            // 
            // txtBxEdPassword
            // 
            this.txtBxEdPassword.Location = new System.Drawing.Point(99, 176);
            this.txtBxEdPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdPassword.Name = "txtBxEdPassword";
            this.txtBxEdPassword.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdPassword.TabIndex = 11;
            // 
            // lblEdPassword
            // 
            this.lblEdPassword.AutoSize = true;
            this.lblEdPassword.Location = new System.Drawing.Point(7, 178);
            this.lblEdPassword.Name = "lblEdPassword";
            this.lblEdPassword.Size = new System.Drawing.Size(67, 16);
            this.lblEdPassword.TabIndex = 10;
            this.lblEdPassword.Text = "Password";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(7, 66);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(52, 16);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "User ID";
            // 
            // txtBxEdEmail
            // 
            this.txtBxEdEmail.Location = new System.Drawing.Point(99, 148);
            this.txtBxEdEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdEmail.Name = "txtBxEdEmail";
            this.txtBxEdEmail.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdEmail.TabIndex = 9;
            // 
            // txtBxUserID
            // 
            this.txtBxUserID.Location = new System.Drawing.Point(99, 64);
            this.txtBxUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxUserID.Name = "txtBxUserID";
            this.txtBxUserID.Size = new System.Drawing.Size(285, 22);
            this.txtBxUserID.TabIndex = 3;
            // 
            // lblEdEmail
            // 
            this.lblEdEmail.AutoSize = true;
            this.lblEdEmail.Location = new System.Drawing.Point(7, 151);
            this.lblEdEmail.Name = "lblEdEmail";
            this.lblEdEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEdEmail.TabIndex = 8;
            this.lblEdEmail.Text = "Email";
            // 
            // lblEdName
            // 
            this.lblEdName.AutoSize = true;
            this.lblEdName.Location = new System.Drawing.Point(7, 95);
            this.lblEdName.Name = "lblEdName";
            this.lblEdName.Size = new System.Drawing.Size(44, 16);
            this.lblEdName.TabIndex = 4;
            this.lblEdName.Text = "Name";
            // 
            // txtBxEdSurname
            // 
            this.txtBxEdSurname.Location = new System.Drawing.Point(99, 121);
            this.txtBxEdSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdSurname.Name = "txtBxEdSurname";
            this.txtBxEdSurname.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdSurname.TabIndex = 7;
            // 
            // txtBxEdName
            // 
            this.txtBxEdName.Location = new System.Drawing.Point(99, 92);
            this.txtBxEdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdName.Name = "txtBxEdName";
            this.txtBxEdName.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdName.TabIndex = 5;
            // 
            // lblEdSername
            // 
            this.lblEdSername.AutoSize = true;
            this.lblEdSername.Location = new System.Drawing.Point(7, 123);
            this.lblEdSername.Name = "lblEdSername";
            this.lblEdSername.Size = new System.Drawing.Size(61, 16);
            this.lblEdSername.TabIndex = 6;
            this.lblEdSername.Text = "Surname";
            // 
            // tabPgClient
            // 
            this.tabPgClient.Controls.Add(this.grpBxEdClient);
            this.tabPgClient.Location = new System.Drawing.Point(4, 25);
            this.tabPgClient.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgClient.Name = "tabPgClient";
            this.tabPgClient.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgClient.Size = new System.Drawing.Size(989, 549);
            this.tabPgClient.TabIndex = 2;
            this.tabPgClient.Text = "Client";
            this.tabPgClient.UseVisualStyleBackColor = true;
            // 
            // grpBxEdClient
            // 
            this.grpBxEdClient.AutoSize = true;
            this.grpBxEdClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxEdClient.Controls.Add(this.cmbBxEdSlctClient);
            this.grpBxEdClient.Controls.Add(this.btnEdClientDelete);
            this.grpBxEdClient.Controls.Add(this.btnEdNewClientSubmit);
            this.grpBxEdClient.Controls.Add(this.btnEdClientCancel);
            this.grpBxEdClient.Controls.Add(this.btnEdClientUpdate);
            this.grpBxEdClient.Controls.Add(this.lblEdSlctClient);
            this.grpBxEdClient.Controls.Add(this.txtBxEdClientPassword);
            this.grpBxEdClient.Controls.Add(this.lblEdClientPassword);
            this.grpBxEdClient.Controls.Add(this.label3);
            this.grpBxEdClient.Controls.Add(this.txtBxEdClientEmail);
            this.grpBxEdClient.Controls.Add(this.txtBxEdClientID);
            this.grpBxEdClient.Controls.Add(this.lblEdClientEmail);
            this.grpBxEdClient.Controls.Add(this.lblEdClientName);
            this.grpBxEdClient.Controls.Add(this.txtBxEdClientSurname);
            this.grpBxEdClient.Controls.Add(this.txtBxEdClientName);
            this.grpBxEdClient.Controls.Add(this.lblEdClientSername);
            this.grpBxEdClient.Location = new System.Drawing.Point(7, 6);
            this.grpBxEdClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxEdClient.Name = "grpBxEdClient";
            this.grpBxEdClient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxEdClient.Size = new System.Drawing.Size(391, 296);
            this.grpBxEdClient.TabIndex = 13;
            this.grpBxEdClient.TabStop = false;
            this.grpBxEdClient.Text = "Client";
            // 
            // cmbBxEdSlctClient
            // 
            this.cmbBxEdSlctClient.FormattingEnabled = true;
            this.cmbBxEdSlctClient.Location = new System.Drawing.Point(99, 32);
            this.cmbBxEdSlctClient.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxEdSlctClient.Name = "cmbBxEdSlctClient";
            this.cmbBxEdSlctClient.Size = new System.Drawing.Size(285, 24);
            this.cmbBxEdSlctClient.TabIndex = 15;
            // 
            // btnEdClientDelete
            // 
            this.btnEdClientDelete.Location = new System.Drawing.Point(263, 225);
            this.btnEdClientDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdClientDelete.Name = "btnEdClientDelete";
            this.btnEdClientDelete.Size = new System.Drawing.Size(121, 23);
            this.btnEdClientDelete.TabIndex = 14;
            this.btnEdClientDelete.Text = "Delete";
            this.btnEdClientDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdNewClientSubmit
            // 
            this.btnEdNewClientSubmit.Location = new System.Drawing.Point(11, 225);
            this.btnEdNewClientSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdNewClientSubmit.Name = "btnEdNewClientSubmit";
            this.btnEdNewClientSubmit.Size = new System.Drawing.Size(121, 23);
            this.btnEdNewClientSubmit.TabIndex = 13;
            this.btnEdNewClientSubmit.Text = "Submit";
            this.btnEdNewClientSubmit.UseVisualStyleBackColor = true;
            // 
            // btnEdClientCancel
            // 
            this.btnEdClientCancel.Location = new System.Drawing.Point(263, 254);
            this.btnEdClientCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdClientCancel.Name = "btnEdClientCancel";
            this.btnEdClientCancel.Size = new System.Drawing.Size(121, 23);
            this.btnEdClientCancel.TabIndex = 13;
            this.btnEdClientCancel.Text = "Cancel";
            this.btnEdClientCancel.UseVisualStyleBackColor = true;
            // 
            // btnEdClientUpdate
            // 
            this.btnEdClientUpdate.Location = new System.Drawing.Point(137, 225);
            this.btnEdClientUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdClientUpdate.Name = "btnEdClientUpdate";
            this.btnEdClientUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnEdClientUpdate.TabIndex = 12;
            this.btnEdClientUpdate.Text = "Update";
            this.btnEdClientUpdate.UseVisualStyleBackColor = true;
            // 
            // lblEdSlctClient
            // 
            this.lblEdSlctClient.AutoSize = true;
            this.lblEdSlctClient.Location = new System.Drawing.Point(7, 36);
            this.lblEdSlctClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdSlctClient.Name = "lblEdSlctClient";
            this.lblEdSlctClient.Size = new System.Drawing.Size(81, 16);
            this.lblEdSlctClient.TabIndex = 0;
            this.lblEdSlctClient.Text = "Select Client";
            // 
            // txtBxEdClientPassword
            // 
            this.txtBxEdClientPassword.Location = new System.Drawing.Point(99, 176);
            this.txtBxEdClientPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdClientPassword.Name = "txtBxEdClientPassword";
            this.txtBxEdClientPassword.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdClientPassword.TabIndex = 11;
            // 
            // lblEdClientPassword
            // 
            this.lblEdClientPassword.AutoSize = true;
            this.lblEdClientPassword.Location = new System.Drawing.Point(7, 178);
            this.lblEdClientPassword.Name = "lblEdClientPassword";
            this.lblEdClientPassword.Size = new System.Drawing.Size(67, 16);
            this.lblEdClientPassword.TabIndex = 10;
            this.lblEdClientPassword.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client ID";
            // 
            // txtBxEdClientEmail
            // 
            this.txtBxEdClientEmail.Location = new System.Drawing.Point(99, 148);
            this.txtBxEdClientEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdClientEmail.Name = "txtBxEdClientEmail";
            this.txtBxEdClientEmail.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdClientEmail.TabIndex = 9;
            // 
            // txtBxEdClientID
            // 
            this.txtBxEdClientID.Location = new System.Drawing.Point(99, 64);
            this.txtBxEdClientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdClientID.Name = "txtBxEdClientID";
            this.txtBxEdClientID.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdClientID.TabIndex = 3;
            // 
            // lblEdClientEmail
            // 
            this.lblEdClientEmail.AutoSize = true;
            this.lblEdClientEmail.Location = new System.Drawing.Point(7, 151);
            this.lblEdClientEmail.Name = "lblEdClientEmail";
            this.lblEdClientEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEdClientEmail.TabIndex = 8;
            this.lblEdClientEmail.Text = "Email";
            // 
            // lblEdClientName
            // 
            this.lblEdClientName.AutoSize = true;
            this.lblEdClientName.Location = new System.Drawing.Point(7, 95);
            this.lblEdClientName.Name = "lblEdClientName";
            this.lblEdClientName.Size = new System.Drawing.Size(44, 16);
            this.lblEdClientName.TabIndex = 4;
            this.lblEdClientName.Text = "Name";
            // 
            // txtBxEdClientSurname
            // 
            this.txtBxEdClientSurname.Location = new System.Drawing.Point(99, 121);
            this.txtBxEdClientSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdClientSurname.Name = "txtBxEdClientSurname";
            this.txtBxEdClientSurname.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdClientSurname.TabIndex = 7;
            // 
            // txtBxEdClientName
            // 
            this.txtBxEdClientName.Location = new System.Drawing.Point(99, 92);
            this.txtBxEdClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdClientName.Name = "txtBxEdClientName";
            this.txtBxEdClientName.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdClientName.TabIndex = 5;
            // 
            // lblEdClientSername
            // 
            this.lblEdClientSername.AutoSize = true;
            this.lblEdClientSername.Location = new System.Drawing.Point(7, 123);
            this.lblEdClientSername.Name = "lblEdClientSername";
            this.lblEdClientSername.Size = new System.Drawing.Size(61, 16);
            this.lblEdClientSername.TabIndex = 6;
            this.lblEdClientSername.Text = "Surname";
            // 
            // tabPgEvent
            // 
            this.tabPgEvent.Controls.Add(this.grpBxEvent);
            this.tabPgEvent.Location = new System.Drawing.Point(4, 25);
            this.tabPgEvent.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgEvent.Name = "tabPgEvent";
            this.tabPgEvent.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgEvent.Size = new System.Drawing.Size(989, 549);
            this.tabPgEvent.TabIndex = 3;
            this.tabPgEvent.Text = "Event";
            this.tabPgEvent.UseVisualStyleBackColor = true;
            // 
            // grpBxEvent
            // 
            this.grpBxEvent.AutoSize = true;
            this.grpBxEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxEvent.Controls.Add(this.dtPckrEventEndDate);
            this.grpBxEvent.Controls.Add(this.lblEventEndDate);
            this.grpBxEvent.Controls.Add(this.cmbBxEventEndTime);
            this.grpBxEvent.Controls.Add(this.cmbBxEventStartTime);
            this.grpBxEvent.Controls.Add(this.radioBtnExam);
            this.grpBxEvent.Controls.Add(this.radioBtnTraining);
            this.grpBxEvent.Controls.Add(this.cmbBxSelectEvent);
            this.grpBxEvent.Controls.Add(this.lblEventEndTime);
            this.grpBxEvent.Controls.Add(this.txtBxEventName);
            this.grpBxEvent.Controls.Add(this.lblEventName);
            this.grpBxEvent.Controls.Add(this.dtPckrEventStartDate);
            this.grpBxEvent.Controls.Add(this.btnEventDelete);
            this.grpBxEvent.Controls.Add(this.btnNewEventSubmit);
            this.grpBxEvent.Controls.Add(this.btnEventCancle);
            this.grpBxEvent.Controls.Add(this.btnEventUpdate);
            this.grpBxEvent.Controls.Add(this.lblEventStartDate);
            this.grpBxEvent.Controls.Add(this.lblEventStartTime);
            this.grpBxEvent.Controls.Add(this.lblEventType);
            this.grpBxEvent.Controls.Add(this.lblSelectEvent);
            this.grpBxEvent.Controls.Add(this.txtBxEventID);
            this.grpBxEvent.Controls.Add(this.lblEventID);
            this.grpBxEvent.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpBxEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxEvent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grpBxEvent.Location = new System.Drawing.Point(4, 4);
            this.grpBxEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxEvent.Name = "grpBxEvent";
            this.grpBxEvent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxEvent.Size = new System.Drawing.Size(981, 541);
            this.grpBxEvent.TabIndex = 0;
            this.grpBxEvent.TabStop = false;
            this.grpBxEvent.Text = "Events";
            // 
            // dtPckrEventEndDate
            // 
            this.dtPckrEventEndDate.Location = new System.Drawing.Point(136, 166);
            this.dtPckrEventEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPckrEventEndDate.Name = "dtPckrEventEndDate";
            this.dtPckrEventEndDate.Size = new System.Drawing.Size(263, 22);
            this.dtPckrEventEndDate.TabIndex = 31;
            this.dtPckrEventEndDate.Value = new System.DateTime(2022, 9, 13, 0, 0, 0, 0);
            // 
            // lblEventEndDate
            // 
            this.lblEventEndDate.AutoSize = true;
            this.lblEventEndDate.Location = new System.Drawing.Point(16, 171);
            this.lblEventEndDate.Name = "lblEventEndDate";
            this.lblEventEndDate.Size = new System.Drawing.Size(100, 16);
            this.lblEventEndDate.TabIndex = 30;
            this.lblEventEndDate.Text = "Event End Date";
            // 
            // cmbBxEventEndTime
            // 
            this.cmbBxEventEndTime.FormatString = "t";
            this.cmbBxEventEndTime.FormattingEnabled = true;
            this.cmbBxEventEndTime.Items.AddRange(new object[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30"});
            this.cmbBxEventEndTime.Location = new System.Drawing.Point(136, 230);
            this.cmbBxEventEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxEventEndTime.Name = "cmbBxEventEndTime";
            this.cmbBxEventEndTime.Size = new System.Drawing.Size(263, 24);
            this.cmbBxEventEndTime.TabIndex = 29;
            // 
            // cmbBxEventStartTime
            // 
            this.cmbBxEventStartTime.FormatString = "t";
            this.cmbBxEventStartTime.FormattingEnabled = true;
            this.cmbBxEventStartTime.Items.AddRange(new object[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00"});
            this.cmbBxEventStartTime.Location = new System.Drawing.Point(136, 197);
            this.cmbBxEventStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxEventStartTime.Name = "cmbBxEventStartTime";
            this.cmbBxEventStartTime.Size = new System.Drawing.Size(263, 24);
            this.cmbBxEventStartTime.TabIndex = 28;
            // 
            // radioBtnExam
            // 
            this.radioBtnExam.AutoSize = true;
            this.radioBtnExam.Location = new System.Drawing.Point(285, 110);
            this.radioBtnExam.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnExam.Name = "radioBtnExam";
            this.radioBtnExam.Size = new System.Drawing.Size(62, 20);
            this.radioBtnExam.TabIndex = 27;
            this.radioBtnExam.TabStop = true;
            this.radioBtnExam.Text = "Exam";
            this.radioBtnExam.UseVisualStyleBackColor = true;
            // 
            // radioBtnTraining
            // 
            this.radioBtnTraining.AutoSize = true;
            this.radioBtnTraining.Location = new System.Drawing.Point(136, 110);
            this.radioBtnTraining.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnTraining.Name = "radioBtnTraining";
            this.radioBtnTraining.Size = new System.Drawing.Size(77, 20);
            this.radioBtnTraining.TabIndex = 26;
            this.radioBtnTraining.TabStop = true;
            this.radioBtnTraining.Text = "Training";
            this.radioBtnTraining.UseVisualStyleBackColor = true;
            // 
            // cmbBxSelectEvent
            // 
            this.cmbBxSelectEvent.FormattingEnabled = true;
            this.cmbBxSelectEvent.Location = new System.Drawing.Point(136, 22);
            this.cmbBxSelectEvent.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxSelectEvent.Name = "cmbBxSelectEvent";
            this.cmbBxSelectEvent.Size = new System.Drawing.Size(261, 24);
            this.cmbBxSelectEvent.TabIndex = 25;
            // 
            // lblEventEndTime
            // 
            this.lblEventEndTime.AutoSize = true;
            this.lblEventEndTime.Location = new System.Drawing.Point(16, 234);
            this.lblEventEndTime.Name = "lblEventEndTime";
            this.lblEventEndTime.Size = new System.Drawing.Size(102, 16);
            this.lblEventEndTime.TabIndex = 23;
            this.lblEventEndTime.Text = "Event End Time";
            // 
            // txtBxEventName
            // 
            this.txtBxEventName.Location = new System.Drawing.Point(136, 81);
            this.txtBxEventName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEventName.Name = "txtBxEventName";
            this.txtBxEventName.Size = new System.Drawing.Size(263, 22);
            this.txtBxEventName.TabIndex = 22;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(16, 84);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(81, 16);
            this.lblEventName.TabIndex = 21;
            this.lblEventName.Text = "Event Name";
            // 
            // dtPckrEventStartDate
            // 
            this.dtPckrEventStartDate.Location = new System.Drawing.Point(136, 137);
            this.dtPckrEventStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPckrEventStartDate.Name = "dtPckrEventStartDate";
            this.dtPckrEventStartDate.Size = new System.Drawing.Size(263, 22);
            this.dtPckrEventStartDate.TabIndex = 19;
            this.dtPckrEventStartDate.Value = new System.DateTime(2022, 9, 13, 0, 0, 0, 0);
            // 
            // btnEventDelete
            // 
            this.btnEventDelete.Location = new System.Drawing.Point(279, 262);
            this.btnEventDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEventDelete.Name = "btnEventDelete";
            this.btnEventDelete.Size = new System.Drawing.Size(121, 23);
            this.btnEventDelete.TabIndex = 18;
            this.btnEventDelete.Text = "Delete";
            this.btnEventDelete.UseVisualStyleBackColor = true;
            // 
            // btnNewEventSubmit
            // 
            this.btnNewEventSubmit.Location = new System.Drawing.Point(19, 262);
            this.btnNewEventSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewEventSubmit.Name = "btnNewEventSubmit";
            this.btnNewEventSubmit.Size = new System.Drawing.Size(129, 23);
            this.btnNewEventSubmit.TabIndex = 16;
            this.btnNewEventSubmit.Text = "Submit";
            this.btnNewEventSubmit.UseVisualStyleBackColor = true;
            // 
            // btnEventCancle
            // 
            this.btnEventCancle.Location = new System.Drawing.Point(279, 292);
            this.btnEventCancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEventCancle.Name = "btnEventCancle";
            this.btnEventCancle.Size = new System.Drawing.Size(121, 23);
            this.btnEventCancle.TabIndex = 17;
            this.btnEventCancle.Text = "Cancel";
            this.btnEventCancle.UseVisualStyleBackColor = true;
            // 
            // btnEventUpdate
            // 
            this.btnEventUpdate.Location = new System.Drawing.Point(153, 262);
            this.btnEventUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEventUpdate.Name = "btnEventUpdate";
            this.btnEventUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnEventUpdate.TabIndex = 15;
            this.btnEventUpdate.Text = "Update";
            this.btnEventUpdate.UseVisualStyleBackColor = true;
            // 
            // lblEventStartDate
            // 
            this.lblEventStartDate.AutoSize = true;
            this.lblEventStartDate.Location = new System.Drawing.Point(16, 142);
            this.lblEventStartDate.Name = "lblEventStartDate";
            this.lblEventStartDate.Size = new System.Drawing.Size(103, 16);
            this.lblEventStartDate.TabIndex = 9;
            this.lblEventStartDate.Text = "Event Start Date";
            // 
            // lblEventStartTime
            // 
            this.lblEventStartTime.AutoSize = true;
            this.lblEventStartTime.Location = new System.Drawing.Point(16, 201);
            this.lblEventStartTime.Name = "lblEventStartTime";
            this.lblEventStartTime.Size = new System.Drawing.Size(105, 16);
            this.lblEventStartTime.TabIndex = 6;
            this.lblEventStartTime.Text = "Event Start Time";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(16, 112);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(76, 16);
            this.lblEventType.TabIndex = 4;
            this.lblEventType.Text = "Event Type";
            // 
            // lblSelectEvent
            // 
            this.lblSelectEvent.AutoSize = true;
            this.lblSelectEvent.Location = new System.Drawing.Point(16, 26);
            this.lblSelectEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectEvent.Name = "lblSelectEvent";
            this.lblSelectEvent.Size = new System.Drawing.Size(82, 16);
            this.lblSelectEvent.TabIndex = 2;
            this.lblSelectEvent.Text = "Select Event";
            // 
            // txtBxEventID
            // 
            this.txtBxEventID.Location = new System.Drawing.Point(136, 53);
            this.txtBxEventID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEventID.Name = "txtBxEventID";
            this.txtBxEventID.Size = new System.Drawing.Size(263, 22);
            this.txtBxEventID.TabIndex = 1;
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(16, 55);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(57, 16);
            this.lblEventID.TabIndex = 0;
            this.lblEventID.Text = "Event ID";
            // 
            // tabPgBooking
            // 
            this.tabPgBooking.Controls.Add(this.grpBxBooking);
            this.tabPgBooking.Location = new System.Drawing.Point(4, 25);
            this.tabPgBooking.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgBooking.Name = "tabPgBooking";
            this.tabPgBooking.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgBooking.Size = new System.Drawing.Size(1238, 681);
            this.tabPgBooking.TabIndex = 4;
            this.tabPgBooking.Text = "Booking";
            this.tabPgBooking.UseVisualStyleBackColor = true;
            // 
            // grpBxBooking
            // 
            this.grpBxBooking.Controls.Add(this.radioBtnNotApproved);
            this.grpBxBooking.Controls.Add(this.radioBtnApproved);
            this.grpBxBooking.Controls.Add(this.lblBookApprove);
            this.grpBxBooking.Controls.Add(this.btnOpenAttendeeList);
            this.grpBxBooking.Controls.Add(this.lstBxBookClients);
            this.grpBxBooking.Controls.Add(this.btnAddAttendees);
            this.grpBxBooking.Controls.Add(this.lblBookAttendees);
            this.grpBxBooking.Controls.Add(this.lstBxBookAttendees);
            this.grpBxBooking.Controls.Add(this.cmbBxBookTrainerSelect);
            this.grpBxBooking.Controls.Add(this.lblBookTrainer);
            this.grpBxBooking.Controls.Add(this.cmbBxBookEventSelect);
            this.grpBxBooking.Controls.Add(this.label2);
            this.grpBxBooking.Controls.Add(this.textBox2);
            this.grpBxBooking.Controls.Add(this.lblBookComments);
            this.grpBxBooking.Controls.Add(this.cmbBxSlctBooking);
            this.grpBxBooking.Controls.Add(this.lblSlctBooking);
            this.grpBxBooking.Controls.Add(this.textBox1);
            this.grpBxBooking.Controls.Add(this.lblBookingName);
            this.grpBxBooking.Controls.Add(this.txtBxBookingID);
            this.grpBxBooking.Controls.Add(this.lblBookingID);
            this.grpBxBooking.Location = new System.Drawing.Point(8, 7);
            this.grpBxBooking.Name = "grpBxBooking";
            this.grpBxBooking.Size = new System.Drawing.Size(700, 534);
            this.grpBxBooking.TabIndex = 0;
            this.grpBxBooking.TabStop = false;
            this.grpBxBooking.Text = "Bookings";
            // 
            // radioBtnNotApproved
            // 
            this.radioBtnNotApproved.AutoSize = true;
            this.radioBtnNotApproved.Checked = true;
            this.radioBtnNotApproved.Location = new System.Drawing.Point(250, 369);
            this.radioBtnNotApproved.Name = "radioBtnNotApproved";
            this.radioBtnNotApproved.Size = new System.Drawing.Size(172, 20);
            this.radioBtnNotApproved.TabIndex = 39;
            this.radioBtnNotApproved.TabStop = true;
            this.radioBtnNotApproved.Text = "Pending / Not Approved";
            this.radioBtnNotApproved.UseVisualStyleBackColor = true;
            // 
            // radioBtnApproved
            // 
            this.radioBtnApproved.AutoSize = true;
            this.radioBtnApproved.Location = new System.Drawing.Point(156, 369);
            this.radioBtnApproved.Name = "radioBtnApproved";
            this.radioBtnApproved.Size = new System.Drawing.Size(88, 20);
            this.radioBtnApproved.TabIndex = 38;
            this.radioBtnApproved.Text = "Approved";
            this.radioBtnApproved.UseVisualStyleBackColor = true;
            // 
            // lblBookApprove
            // 
            this.lblBookApprove.AutoSize = true;
            this.lblBookApprove.Location = new System.Drawing.Point(7, 369);
            this.lblBookApprove.Name = "lblBookApprove";
            this.lblBookApprove.Size = new System.Drawing.Size(67, 16);
            this.lblBookApprove.TabIndex = 37;
            this.lblBookApprove.Text = "Approved";
            // 
            // btnOpenAttendeeList
            // 
            this.btnOpenAttendeeList.Location = new System.Drawing.Point(6, 186);
            this.btnOpenAttendeeList.Name = "btnOpenAttendeeList";
            this.btnOpenAttendeeList.Size = new System.Drawing.Size(127, 45);
            this.btnOpenAttendeeList.TabIndex = 36;
            this.btnOpenAttendeeList.Text = "Add More Attendees";
            this.btnOpenAttendeeList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAttendeeList.UseVisualStyleBackColor = true;
            // 
            // lstBxBookClients
            // 
            this.lstBxBookClients.FormattingEnabled = true;
            this.lstBxBookClients.ItemHeight = 16;
            this.lstBxBookClients.Location = new System.Drawing.Point(428, 21);
            this.lstBxBookClients.Name = "lstBxBookClients";
            this.lstBxBookClients.ScrollAlwaysVisible = true;
            this.lstBxBookClients.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBxBookClients.Size = new System.Drawing.Size(244, 308);
            this.lstBxBookClients.Sorted = true;
            this.lstBxBookClients.TabIndex = 35;
            this.lstBxBookClients.Visible = false;
            // 
            // btnAddAttendees
            // 
            this.btnAddAttendees.Location = new System.Drawing.Point(428, 335);
            this.btnAddAttendees.Name = "btnAddAttendees";
            this.btnAddAttendees.Size = new System.Drawing.Size(127, 28);
            this.btnAddAttendees.TabIndex = 34;
            this.btnAddAttendees.Text = "Add Attendees";
            this.btnAddAttendees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAttendees.UseVisualStyleBackColor = true;
            this.btnAddAttendees.Visible = false;
            // 
            // lblBookAttendees
            // 
            this.lblBookAttendees.AutoSize = true;
            this.lblBookAttendees.Location = new System.Drawing.Point(7, 167);
            this.lblBookAttendees.Name = "lblBookAttendees";
            this.lblBookAttendees.Size = new System.Drawing.Size(68, 16);
            this.lblBookAttendees.TabIndex = 33;
            this.lblBookAttendees.Text = "Attendees";
            // 
            // lstBxBookAttendees
            // 
            this.lstBxBookAttendees.FormattingEnabled = true;
            this.lstBxBookAttendees.ItemHeight = 16;
            this.lstBxBookAttendees.Location = new System.Drawing.Point(156, 167);
            this.lstBxBookAttendees.Name = "lstBxBookAttendees";
            this.lstBxBookAttendees.ScrollAlwaysVisible = true;
            this.lstBxBookAttendees.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBxBookAttendees.Size = new System.Drawing.Size(266, 196);
            this.lstBxBookAttendees.Sorted = true;
            this.lstBxBookAttendees.TabIndex = 32;
            // 
            // cmbBxBookTrainerSelect
            // 
            this.cmbBxBookTrainerSelect.FormattingEnabled = true;
            this.cmbBxBookTrainerSelect.Location = new System.Drawing.Point(156, 137);
            this.cmbBxBookTrainerSelect.Name = "cmbBxBookTrainerSelect";
            this.cmbBxBookTrainerSelect.Size = new System.Drawing.Size(266, 24);
            this.cmbBxBookTrainerSelect.TabIndex = 31;
            // 
            // lblBookTrainer
            // 
            this.lblBookTrainer.AutoSize = true;
            this.lblBookTrainer.Location = new System.Drawing.Point(7, 140);
            this.lblBookTrainer.Name = "lblBookTrainer";
            this.lblBookTrainer.Size = new System.Drawing.Size(50, 16);
            this.lblBookTrainer.TabIndex = 30;
            this.lblBookTrainer.Text = "Trainer";
            // 
            // cmbBxBookEventSelect
            // 
            this.cmbBxBookEventSelect.FormattingEnabled = true;
            this.cmbBxBookEventSelect.Location = new System.Drawing.Point(156, 21);
            this.cmbBxBookEventSelect.Name = "cmbBxBookEventSelect";
            this.cmbBxBookEventSelect.Size = new System.Drawing.Size(266, 24);
            this.cmbBxBookEventSelect.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Select Event to Book";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 395);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(516, 122);
            this.textBox2.TabIndex = 27;
            // 
            // lblBookComments
            // 
            this.lblBookComments.AutoSize = true;
            this.lblBookComments.Location = new System.Drawing.Point(7, 398);
            this.lblBookComments.Name = "lblBookComments";
            this.lblBookComments.Size = new System.Drawing.Size(71, 16);
            this.lblBookComments.TabIndex = 26;
            this.lblBookComments.Text = "Comments";
            // 
            // cmbBxSlctBooking
            // 
            this.cmbBxSlctBooking.FormattingEnabled = true;
            this.cmbBxSlctBooking.Location = new System.Drawing.Point(156, 51);
            this.cmbBxSlctBooking.Name = "cmbBxSlctBooking";
            this.cmbBxSlctBooking.Size = new System.Drawing.Size(266, 24);
            this.cmbBxSlctBooking.TabIndex = 25;
            // 
            // lblSlctBooking
            // 
            this.lblSlctBooking.AutoSize = true;
            this.lblSlctBooking.Location = new System.Drawing.Point(7, 54);
            this.lblSlctBooking.Name = "lblSlctBooking";
            this.lblSlctBooking.Size = new System.Drawing.Size(98, 16);
            this.lblSlctBooking.TabIndex = 24;
            this.lblSlctBooking.Text = "Select Booking";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 22);
            this.textBox1.TabIndex = 23;
            // 
            // lblBookingName
            // 
            this.lblBookingName.AutoSize = true;
            this.lblBookingName.Location = new System.Drawing.Point(7, 112);
            this.lblBookingName.Name = "lblBookingName";
            this.lblBookingName.Size = new System.Drawing.Size(97, 16);
            this.lblBookingName.TabIndex = 22;
            this.lblBookingName.Text = "Booking Name";
            // 
            // txtBxBookingID
            // 
            this.txtBxBookingID.Location = new System.Drawing.Point(156, 81);
            this.txtBxBookingID.Name = "txtBxBookingID";
            this.txtBxBookingID.Size = new System.Drawing.Size(266, 22);
            this.txtBxBookingID.TabIndex = 21;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(7, 84);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(73, 16);
            this.lblBookingID.TabIndex = 20;
            this.lblBookingID.Text = "Booking ID";
            // 
            // tabPgReporting
            // 
            this.tabPgReporting.Controls.Add(this.grpBxReporting);
            this.tabPgReporting.Location = new System.Drawing.Point(4, 25);
            this.tabPgReporting.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgReporting.Name = "tabPgReporting";
            this.tabPgReporting.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgReporting.Size = new System.Drawing.Size(989, 549);
            this.tabPgReporting.TabIndex = 5;
            this.tabPgReporting.Text = "Reporting";
            this.tabPgReporting.UseVisualStyleBackColor = true;
            // 
            // grpBxReporting
            // 
            this.grpBxReporting.Controls.Add(this.listBox4);
            this.grpBxReporting.Controls.Add(this.listBox3);
            this.grpBxReporting.Controls.Add(this.listBox2);
            this.grpBxReporting.Controls.Add(this.listBox1);
            this.grpBxReporting.Controls.Add(this.label6);
            this.grpBxReporting.Controls.Add(this.label5);
            this.grpBxReporting.Controls.Add(this.label4);
            this.grpBxReporting.Controls.Add(this.label1);
            this.grpBxReporting.Controls.Add(this.button4);
            this.grpBxReporting.Controls.Add(this.button3);
            this.grpBxReporting.Controls.Add(this.button2);
            this.grpBxReporting.Controls.Add(this.button1);
            this.grpBxReporting.Location = new System.Drawing.Point(8, 7);
            this.grpBxReporting.Name = "grpBxReporting";
            this.grpBxReporting.Size = new System.Drawing.Size(970, 533);
            this.grpBxReporting.TabIndex = 0;
            this.grpBxReporting.TabStop = false;
            this.grpBxReporting.Text = "Reporting";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(483, 320);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(457, 212);
            this.listBox4.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(483, 77);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(457, 212);
            this.listBox3.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(9, 320);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(457, 212);
            this.listBox2.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(9, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(457, 212);
            this.listBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bookings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Events";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "User information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Training done";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(414, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bookings";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Events";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Client";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Admin/Trainer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(997, 606);
            this.Controls.Add(this.tabCtrlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabCtrlMain.ResumeLayout(false);
            this.tabPgLogin.ResumeLayout(false);
            this.tabPgLogin.PerformLayout();
            this.grpBxLogin.ResumeLayout(false);
            this.grpBxLogin.PerformLayout();
            this.grtBxNewSignUp.ResumeLayout(false);
            this.grtBxNewSignUp.PerformLayout();
            this.tabPgUser.ResumeLayout(false);
            this.tabPgUser.PerformLayout();
            this.grpBxEdUser.ResumeLayout(false);
            this.grpBxEdUser.PerformLayout();
            this.tabPgClient.ResumeLayout(false);
            this.tabPgClient.PerformLayout();
            this.grpBxEdClient.ResumeLayout(false);
            this.grpBxEdClient.PerformLayout();
            this.tabPgEvent.ResumeLayout(false);
            this.tabPgEvent.PerformLayout();
            this.grpBxEvent.ResumeLayout(false);
            this.grpBxEvent.PerformLayout();
            this.tabPgBooking.ResumeLayout(false);
            this.grpBxBooking.ResumeLayout(false);
            this.grpBxBooking.PerformLayout();
            this.tabPgReporting.ResumeLayout(false);
            this.grpBxReporting.ResumeLayout(false);
            this.grpBxReporting.PerformLayout();
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
        private System.Windows.Forms.GroupBox grtBxNewSignUp;
        private System.Windows.Forms.TextBox txtBxConfNewPass;
        private System.Windows.Forms.Label lblNewClientConPass;
        private System.Windows.Forms.Button btnSignCancel;
        private System.Windows.Forms.Button btnCreateClint;
        private System.Windows.Forms.TextBox txtBxNewPass;
        private System.Windows.Forms.TextBox txtBxNewUserName;
        private System.Windows.Forms.Label lblNewClintPassword;
        private System.Windows.Forms.Label lblNewClient;
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
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.GroupBox grpBxEdUser;
        private System.Windows.Forms.Button btnEdDelete;
        private System.Windows.Forms.Button btnEdNewUserSubmit;
        private System.Windows.Forms.Button btnEdCancel;
        private System.Windows.Forms.Button btnEdUpdate;
        private System.Windows.Forms.TextBox txtBxEdPassword;
        private System.Windows.Forms.Label lblEdPassword;
        private System.Windows.Forms.TextBox txtBxEdEmail;
        private System.Windows.Forms.TextBox txtBxUserID;
        private System.Windows.Forms.Label lblEdEmail;
        private System.Windows.Forms.Label lblEdName;
        private System.Windows.Forms.TextBox txtBxEdSurname;
        private System.Windows.Forms.TextBox txtBxEdName;
        private System.Windows.Forms.Label lblEdSername;
        private System.Windows.Forms.GroupBox grpBxEdClient;
        private System.Windows.Forms.Button btnEdClientDelete;
        private System.Windows.Forms.Button btnEdNewClientSubmit;
        private System.Windows.Forms.Button btnEdClientCancel;
        private System.Windows.Forms.Button btnEdClientUpdate;
        private System.Windows.Forms.Label lblEdSlctClient;
        private System.Windows.Forms.TextBox txtBxEdClientPassword;
        private System.Windows.Forms.Label lblEdClientPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxEdClientEmail;
        private System.Windows.Forms.TextBox txtBxEdClientID;
        private System.Windows.Forms.Label lblEdClientEmail;
        private System.Windows.Forms.Label lblEdClientName;
        private System.Windows.Forms.TextBox txtBxEdClientSurname;
        private System.Windows.Forms.TextBox txtBxEdClientName;
        private System.Windows.Forms.Label lblEdClientSername;
        private System.Windows.Forms.Button btnEventDelete;
        private System.Windows.Forms.Button btnNewEventSubmit;
        private System.Windows.Forms.Button btnEventCancle;
        private System.Windows.Forms.Button btnEventUpdate;
        private System.Windows.Forms.Label lblEventStartDate;
        private System.Windows.Forms.Label lblEventStartTime;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblSelectEvent;
        private System.Windows.Forms.TextBox txtBxEventID;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.DateTimePicker dtPckrEventStartDate;
        private System.Windows.Forms.TextBox txtBxEventName;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventEndTime;
        private System.Windows.Forms.RadioButton radioBtnExam;
        private System.Windows.Forms.RadioButton radioBtnTraining;
        private System.Windows.Forms.ComboBox cmbBxSelectEvent;
        private System.Windows.Forms.ComboBox cmbBxEdSlctUser;
        private System.Windows.Forms.ComboBox cmbBxEdSlctClient;
        private System.Windows.Forms.ComboBox cmbBxEventEndTime;
        private System.Windows.Forms.ComboBox cmbBxEventStartTime;
        private System.Windows.Forms.DateTimePicker dtPckrEventEndDate;
        private System.Windows.Forms.Label lblEventEndDate;
        private System.Windows.Forms.GroupBox grpBxEvent;
        private System.Windows.Forms.GroupBox grpBxBooking;
        private System.Windows.Forms.RadioButton radioBtnNotApproved;
        private System.Windows.Forms.RadioButton radioBtnApproved;
        private System.Windows.Forms.Label lblBookApprove;
        private System.Windows.Forms.Button btnOpenAttendeeList;
        private System.Windows.Forms.ListBox lstBxBookClients;
        private System.Windows.Forms.Button btnAddAttendees;
        private System.Windows.Forms.Label lblBookAttendees;
        private System.Windows.Forms.ListBox lstBxBookAttendees;
        private System.Windows.Forms.ComboBox cmbBxBookTrainerSelect;
        private System.Windows.Forms.Label lblBookTrainer;
        private System.Windows.Forms.ComboBox cmbBxBookEventSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblBookComments;
        private System.Windows.Forms.ComboBox cmbBxSlctBooking;
        private System.Windows.Forms.Label lblSlctBooking;
        private System.Windows.Forms.Label lblBookingName;
        private System.Windows.Forms.TextBox txtBxBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.GroupBox grpBxReporting;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

