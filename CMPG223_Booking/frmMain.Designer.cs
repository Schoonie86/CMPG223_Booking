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
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprotingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
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
            this.txtBxEdClientID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdClientDelete = new System.Windows.Forms.Button();
            this.btnEdNewClientSubmit = new System.Windows.Forms.Button();
            this.btnEdClientCancel = new System.Windows.Forms.Button();
            this.btnEdClientUpdate = new System.Windows.Forms.Button();
            this.lblEdSlctClient = new System.Windows.Forms.Label();
            this.txtBxEdClientPassword = new System.Windows.Forms.TextBox();
            this.lblEdClientPassword = new System.Windows.Forms.Label();
            this.txtBxEdClientEmail = new System.Windows.Forms.TextBox();
            this.lblEdClientEmail = new System.Windows.Forms.Label();
            this.lblEdClientName = new System.Windows.Forms.Label();
            this.txtBxEdClientSurname = new System.Windows.Forms.TextBox();
            this.txtBxEdClientName = new System.Windows.Forms.TextBox();
            this.lblEdClientSername = new System.Windows.Forms.Label();
            this.tabPgEvent = new System.Windows.Forms.TabPage();
            this.grpBxEvent = new System.Windows.Forms.GroupBox();
            this.txtDiscription = new System.Windows.Forms.Label();
            this.rTxtBxDiscription = new System.Windows.Forms.RichTextBox();
            this.dtPckrEventEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventEndDate = new System.Windows.Forms.Label();
            this.cmbBxEventEndTime = new System.Windows.Forms.ComboBox();
            this.cmbBxEventStartTime = new System.Windows.Forms.ComboBox();
            this.radioBtnExam = new System.Windows.Forms.RadioButton();
            this.radioBtnTraining = new System.Windows.Forms.RadioButton();
            this.cmbBxSlctEvent = new System.Windows.Forms.ComboBox();
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
            this.lstBxBookAttendees = new System.Windows.Forms.ListBox();
            this.txtBxBookingName = new System.Windows.Forms.TextBox();
            this.lblBookingName = new System.Windows.Forms.Label();
            this.btnBookAddAttend = new System.Windows.Forms.Button();
            this.cmbBxBookSlctClient = new System.Windows.Forms.ComboBox();
            this.lblBookAttendee = new System.Windows.Forms.Label();
            this.btnBookApply = new System.Windows.Forms.Button();
            this.btnBookCancel = new System.Windows.Forms.Button();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.btnBookCreate = new System.Windows.Forms.Button();
            this.radioBtnNotApproved = new System.Windows.Forms.RadioButton();
            this.radioBtnApproved = new System.Windows.Forms.RadioButton();
            this.lblBookApprove = new System.Windows.Forms.Label();
            this.lblBookAttendees = new System.Windows.Forms.Label();
            this.cmbBxBookSlctTrain = new System.Windows.Forms.ComboBox();
            this.lblBookSlctTrainer = new System.Windows.Forms.Label();
            this.cmbBxBookSlctEvent = new System.Windows.Forms.ComboBox();
            this.lblBookSlctEvent = new System.Windows.Forms.Label();
            this.txtBxBookComments = new System.Windows.Forms.TextBox();
            this.lblBookComments = new System.Windows.Forms.Label();
            this.cmbBxBookSlctBook = new System.Windows.Forms.ComboBox();
            this.lblBookSlctBooking = new System.Windows.Forms.Label();
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
            this.grtBxNewSignUp = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignCancel = new System.Windows.Forms.Button();
            this.grpBxLogin = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
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
            this.grtBxNewSignUp.SuspendLayout();
            this.grpBxLogin.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(945, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.eventToolStripMenuItem.Text = "Event";
            this.eventToolStripMenuItem.Click += new System.EventHandler(this.eventToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // reprotingToolStripMenuItem
            // 
            this.reprotingToolStripMenuItem.Name = "reprotingToolStripMenuItem";
            this.reprotingToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.reprotingToolStripMenuItem.Text = "Reproting";
            this.reprotingToolStripMenuItem.Click += new System.EventHandler(this.reprotingToolStripMenuItem_Click);
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabPgUser);
            this.tabCtrlMain.Controls.Add(this.tabPgClient);
            this.tabCtrlMain.Controls.Add(this.tabPgEvent);
            this.tabCtrlMain.Controls.Add(this.tabPgBooking);
            this.tabCtrlMain.Controls.Add(this.tabPgReporting);
            this.tabCtrlMain.HotTrack = true;
            this.tabCtrlMain.Location = new System.Drawing.Point(13, 32);
            this.tabCtrlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(924, 540);
            this.tabCtrlMain.TabIndex = 1;
            // 
            // tabPgUser
            // 
            this.tabPgUser.Controls.Add(this.grpBxEdUser);
            this.tabPgUser.Location = new System.Drawing.Point(4, 25);
            this.tabPgUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgUser.Name = "tabPgUser";
            this.tabPgUser.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgUser.Size = new System.Drawing.Size(916, 511);
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
            this.grpBxEdUser.Size = new System.Drawing.Size(868, 195);
            this.grpBxEdUser.TabIndex = 12;
            this.grpBxEdUser.TabStop = false;
            this.grpBxEdUser.Text = "User";
            // 
            // cmbBxEdSlctUser
            // 
            this.cmbBxEdSlctUser.FormattingEnabled = true;
            this.cmbBxEdSlctUser.Location = new System.Drawing.Point(153, 32);
            this.cmbBxEdSlctUser.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxEdSlctUser.Name = "cmbBxEdSlctUser";
            this.cmbBxEdSlctUser.Size = new System.Drawing.Size(285, 24);
            this.cmbBxEdSlctUser.TabIndex = 16;
            this.cmbBxEdSlctUser.SelectedIndexChanged += new System.EventHandler(this.cmbBxEdSlctUser_SelectedIndexChanged);
            // 
            // btnEdDelete
            // 
            this.btnEdDelete.Location = new System.Drawing.Point(319, 153);
            this.btnEdDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdDelete.Name = "btnEdDelete";
            this.btnEdDelete.Size = new System.Drawing.Size(121, 23);
            this.btnEdDelete.TabIndex = 14;
            this.btnEdDelete.Text = "Delete";
            this.btnEdDelete.UseVisualStyleBackColor = true;
            this.btnEdDelete.Click += new System.EventHandler(this.btnEdDelete_Click);
            // 
            // btnEdNewUserSubmit
            // 
            this.btnEdNewUserSubmit.Location = new System.Drawing.Point(5, 153);
            this.btnEdNewUserSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdNewUserSubmit.Name = "btnEdNewUserSubmit";
            this.btnEdNewUserSubmit.Size = new System.Drawing.Size(121, 23);
            this.btnEdNewUserSubmit.TabIndex = 13;
            this.btnEdNewUserSubmit.Text = "Create";
            this.btnEdNewUserSubmit.UseVisualStyleBackColor = true;
            this.btnEdNewUserSubmit.Click += new System.EventHandler(this.btnEdNewUserSubmit_Click);
            // 
            // btnEdCancel
            // 
            this.btnEdCancel.Location = new System.Drawing.Point(741, 153);
            this.btnEdCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdCancel.Name = "btnEdCancel";
            this.btnEdCancel.Size = new System.Drawing.Size(121, 23);
            this.btnEdCancel.TabIndex = 13;
            this.btnEdCancel.Text = "Cancel";
            this.btnEdCancel.UseVisualStyleBackColor = true;
            this.btnEdCancel.Click += new System.EventHandler(this.btnEdCancel_Click);
            // 
            // btnEdUpdate
            // 
            this.btnEdUpdate.Location = new System.Drawing.Point(153, 153);
            this.btnEdUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdUpdate.Name = "btnEdUpdate";
            this.btnEdUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnEdUpdate.TabIndex = 12;
            this.btnEdUpdate.Text = "Update";
            this.btnEdUpdate.UseVisualStyleBackColor = true;
            this.btnEdUpdate.Click += new System.EventHandler(this.btnEdUpdate_Click);
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
            this.txtBxEdPassword.Location = new System.Drawing.Point(153, 123);
            this.txtBxEdPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdPassword.Name = "txtBxEdPassword";
            this.txtBxEdPassword.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdPassword.TabIndex = 11;
            // 
            // lblEdPassword
            // 
            this.lblEdPassword.AutoSize = true;
            this.lblEdPassword.Location = new System.Drawing.Point(7, 126);
            this.lblEdPassword.Name = "lblEdPassword";
            this.lblEdPassword.Size = new System.Drawing.Size(67, 16);
            this.lblEdPassword.TabIndex = 10;
            this.lblEdPassword.Text = "Password";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(484, 34);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(52, 16);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "User ID";
            // 
            // txtBxEdEmail
            // 
            this.txtBxEdEmail.Location = new System.Drawing.Point(153, 94);
            this.txtBxEdEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdEmail.Name = "txtBxEdEmail";
            this.txtBxEdEmail.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdEmail.TabIndex = 9;
            // 
            // txtBxUserID
            // 
            this.txtBxUserID.Enabled = false;
            this.txtBxUserID.Location = new System.Drawing.Point(576, 32);
            this.txtBxUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxUserID.Name = "txtBxUserID";
            this.txtBxUserID.ReadOnly = true;
            this.txtBxUserID.Size = new System.Drawing.Size(285, 22);
            this.txtBxUserID.TabIndex = 3;
            // 
            // lblEdEmail
            // 
            this.lblEdEmail.AutoSize = true;
            this.lblEdEmail.Location = new System.Drawing.Point(7, 97);
            this.lblEdEmail.Name = "lblEdEmail";
            this.lblEdEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEdEmail.TabIndex = 8;
            this.lblEdEmail.Text = "Email";
            // 
            // lblEdName
            // 
            this.lblEdName.AutoSize = true;
            this.lblEdName.Location = new System.Drawing.Point(7, 66);
            this.lblEdName.Name = "lblEdName";
            this.lblEdName.Size = new System.Drawing.Size(44, 16);
            this.lblEdName.TabIndex = 4;
            this.lblEdName.Text = "Name";
            // 
            // txtBxEdSurname
            // 
            this.txtBxEdSurname.Location = new System.Drawing.Point(576, 63);
            this.txtBxEdSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdSurname.Name = "txtBxEdSurname";
            this.txtBxEdSurname.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdSurname.TabIndex = 7;
            // 
            // txtBxEdName
            // 
            this.txtBxEdName.Location = new System.Drawing.Point(153, 64);
            this.txtBxEdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdName.Name = "txtBxEdName";
            this.txtBxEdName.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdName.TabIndex = 5;
            // 
            // lblEdSername
            // 
            this.lblEdSername.AutoSize = true;
            this.lblEdSername.Location = new System.Drawing.Point(484, 65);
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
            this.tabPgClient.Size = new System.Drawing.Size(916, 511);
            this.tabPgClient.TabIndex = 2;
            this.tabPgClient.Text = "Client";
            this.tabPgClient.UseVisualStyleBackColor = true;
            // 
            // grpBxEdClient
            // 
            this.grpBxEdClient.AutoSize = true;
            this.grpBxEdClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxEdClient.Controls.Add(this.cmbBxEdSlctClient);
            this.grpBxEdClient.Controls.Add(this.txtBxEdClientID);
            this.grpBxEdClient.Controls.Add(this.label3);
            this.grpBxEdClient.Controls.Add(this.btnEdClientDelete);
            this.grpBxEdClient.Controls.Add(this.btnEdNewClientSubmit);
            this.grpBxEdClient.Controls.Add(this.btnEdClientCancel);
            this.grpBxEdClient.Controls.Add(this.btnEdClientUpdate);
            this.grpBxEdClient.Controls.Add(this.lblEdSlctClient);
            this.grpBxEdClient.Controls.Add(this.txtBxEdClientPassword);
            this.grpBxEdClient.Controls.Add(this.lblEdClientPassword);
            this.grpBxEdClient.Controls.Add(this.txtBxEdClientEmail);
            this.grpBxEdClient.Controls.Add(this.lblEdClientEmail);
            this.grpBxEdClient.Controls.Add(this.lblEdClientName);
            this.grpBxEdClient.Controls.Add(this.txtBxEdClientSurname);
            this.grpBxEdClient.Controls.Add(this.txtBxEdClientName);
            this.grpBxEdClient.Controls.Add(this.lblEdClientSername);
            this.grpBxEdClient.Location = new System.Drawing.Point(7, 6);
            this.grpBxEdClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxEdClient.Name = "grpBxEdClient";
            this.grpBxEdClient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxEdClient.Size = new System.Drawing.Size(868, 195);
            this.grpBxEdClient.TabIndex = 13;
            this.grpBxEdClient.TabStop = false;
            this.grpBxEdClient.Text = "Client";
            // 
            // cmbBxEdSlctClient
            // 
            this.cmbBxEdSlctClient.FormattingEnabled = true;
            this.cmbBxEdSlctClient.Location = new System.Drawing.Point(153, 31);
            this.cmbBxEdSlctClient.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxEdSlctClient.Name = "cmbBxEdSlctClient";
            this.cmbBxEdSlctClient.Size = new System.Drawing.Size(285, 24);
            this.cmbBxEdSlctClient.TabIndex = 15;
            this.cmbBxEdSlctClient.SelectedIndexChanged += new System.EventHandler(this.cmbBxEdSlctClient_SelectedIndexChanged);
            // 
            // txtBxEdClientID
            // 
            this.txtBxEdClientID.Enabled = false;
            this.txtBxEdClientID.Location = new System.Drawing.Point(576, 32);
            this.txtBxEdClientID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdClientID.Name = "txtBxEdClientID";
            this.txtBxEdClientID.ReadOnly = true;
            this.txtBxEdClientID.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdClientID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client ID";
            // 
            // btnEdClientDelete
            // 
            this.btnEdClientDelete.Location = new System.Drawing.Point(319, 153);
            this.btnEdClientDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdClientDelete.Name = "btnEdClientDelete";
            this.btnEdClientDelete.Size = new System.Drawing.Size(121, 23);
            this.btnEdClientDelete.TabIndex = 14;
            this.btnEdClientDelete.Text = "Delete";
            this.btnEdClientDelete.UseVisualStyleBackColor = true;
            this.btnEdClientDelete.Click += new System.EventHandler(this.btnEdClientDelete_Click);
            // 
            // btnEdNewClientSubmit
            // 
            this.btnEdNewClientSubmit.Location = new System.Drawing.Point(7, 153);
            this.btnEdNewClientSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdNewClientSubmit.Name = "btnEdNewClientSubmit";
            this.btnEdNewClientSubmit.Size = new System.Drawing.Size(121, 23);
            this.btnEdNewClientSubmit.TabIndex = 13;
            this.btnEdNewClientSubmit.Text = "Create";
            this.btnEdNewClientSubmit.UseVisualStyleBackColor = true;
            this.btnEdNewClientSubmit.Click += new System.EventHandler(this.btnEdNewClientSubmit_Click);
            // 
            // btnEdClientCancel
            // 
            this.btnEdClientCancel.Location = new System.Drawing.Point(741, 153);
            this.btnEdClientCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdClientCancel.Name = "btnEdClientCancel";
            this.btnEdClientCancel.Size = new System.Drawing.Size(121, 23);
            this.btnEdClientCancel.TabIndex = 13;
            this.btnEdClientCancel.Text = "Cancel";
            this.btnEdClientCancel.UseVisualStyleBackColor = true;
            this.btnEdClientCancel.Click += new System.EventHandler(this.btnEdClientCancel_Click);
            // 
            // btnEdClientUpdate
            // 
            this.btnEdClientUpdate.Location = new System.Drawing.Point(153, 153);
            this.btnEdClientUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdClientUpdate.Name = "btnEdClientUpdate";
            this.btnEdClientUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnEdClientUpdate.TabIndex = 12;
            this.btnEdClientUpdate.Text = "Update";
            this.btnEdClientUpdate.UseVisualStyleBackColor = true;
            this.btnEdClientUpdate.Click += new System.EventHandler(this.btnEdClientUpdate_Click);
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
            this.txtBxEdClientPassword.Location = new System.Drawing.Point(153, 122);
            this.txtBxEdClientPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdClientPassword.Name = "txtBxEdClientPassword";
            this.txtBxEdClientPassword.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdClientPassword.TabIndex = 11;
            // 
            // lblEdClientPassword
            // 
            this.lblEdClientPassword.AutoSize = true;
            this.lblEdClientPassword.Location = new System.Drawing.Point(7, 126);
            this.lblEdClientPassword.Name = "lblEdClientPassword";
            this.lblEdClientPassword.Size = new System.Drawing.Size(67, 16);
            this.lblEdClientPassword.TabIndex = 10;
            this.lblEdClientPassword.Text = "Password";
            // 
            // txtBxEdClientEmail
            // 
            this.txtBxEdClientEmail.Location = new System.Drawing.Point(153, 92);
            this.txtBxEdClientEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdClientEmail.Name = "txtBxEdClientEmail";
            this.txtBxEdClientEmail.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdClientEmail.TabIndex = 9;
            // 
            // lblEdClientEmail
            // 
            this.lblEdClientEmail.AutoSize = true;
            this.lblEdClientEmail.Location = new System.Drawing.Point(7, 97);
            this.lblEdClientEmail.Name = "lblEdClientEmail";
            this.lblEdClientEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEdClientEmail.TabIndex = 8;
            this.lblEdClientEmail.Text = "Email";
            // 
            // lblEdClientName
            // 
            this.lblEdClientName.AutoSize = true;
            this.lblEdClientName.Location = new System.Drawing.Point(7, 66);
            this.lblEdClientName.Name = "lblEdClientName";
            this.lblEdClientName.Size = new System.Drawing.Size(44, 16);
            this.lblEdClientName.TabIndex = 4;
            this.lblEdClientName.Text = "Name";
            // 
            // txtBxEdClientSurname
            // 
            this.txtBxEdClientSurname.Location = new System.Drawing.Point(576, 62);
            this.txtBxEdClientSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdClientSurname.Name = "txtBxEdClientSurname";
            this.txtBxEdClientSurname.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdClientSurname.TabIndex = 7;
            // 
            // txtBxEdClientName
            // 
            this.txtBxEdClientName.Location = new System.Drawing.Point(153, 63);
            this.txtBxEdClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEdClientName.Name = "txtBxEdClientName";
            this.txtBxEdClientName.Size = new System.Drawing.Size(285, 22);
            this.txtBxEdClientName.TabIndex = 5;
            // 
            // lblEdClientSername
            // 
            this.lblEdClientSername.AutoSize = true;
            this.lblEdClientSername.Location = new System.Drawing.Point(484, 64);
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
            this.tabPgEvent.Size = new System.Drawing.Size(916, 511);
            this.tabPgEvent.TabIndex = 3;
            this.tabPgEvent.Text = "Event";
            this.tabPgEvent.UseVisualStyleBackColor = true;
            // 
            // grpBxEvent
            // 
            this.grpBxEvent.AutoSize = true;
            this.grpBxEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxEvent.Controls.Add(this.txtDiscription);
            this.grpBxEvent.Controls.Add(this.rTxtBxDiscription);
            this.grpBxEvent.Controls.Add(this.dtPckrEventEndDate);
            this.grpBxEvent.Controls.Add(this.lblEventEndDate);
            this.grpBxEvent.Controls.Add(this.cmbBxEventEndTime);
            this.grpBxEvent.Controls.Add(this.cmbBxEventStartTime);
            this.grpBxEvent.Controls.Add(this.radioBtnExam);
            this.grpBxEvent.Controls.Add(this.radioBtnTraining);
            this.grpBxEvent.Controls.Add(this.cmbBxSlctEvent);
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
            this.grpBxEvent.Size = new System.Drawing.Size(908, 503);
            this.grpBxEvent.TabIndex = 0;
            this.grpBxEvent.TabStop = false;
            this.grpBxEvent.Text = "Events";
            // 
            // txtDiscription
            // 
            this.txtDiscription.AutoSize = true;
            this.txtDiscription.Location = new System.Drawing.Point(16, 148);
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(70, 16);
            this.txtDiscription.TabIndex = 33;
            this.txtDiscription.Text = "Discription";
            // 
            // rTxtBxDiscription
            // 
            this.rTxtBxDiscription.Location = new System.Drawing.Point(19, 167);
            this.rTxtBxDiscription.Name = "rTxtBxDiscription";
            this.rTxtBxDiscription.Size = new System.Drawing.Size(869, 69);
            this.rTxtBxDiscription.TabIndex = 32;
            this.rTxtBxDiscription.Text = "";
            // 
            // dtPckrEventEndDate
            // 
            this.dtPckrEventEndDate.Location = new System.Drawing.Point(625, 84);
            this.dtPckrEventEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPckrEventEndDate.Name = "dtPckrEventEndDate";
            this.dtPckrEventEndDate.Size = new System.Drawing.Size(263, 22);
            this.dtPckrEventEndDate.TabIndex = 31;
            this.dtPckrEventEndDate.Value = new System.DateTime(2022, 9, 13, 0, 0, 0, 0);
            // 
            // lblEventEndDate
            // 
            this.lblEventEndDate.AutoSize = true;
            this.lblEventEndDate.Location = new System.Drawing.Point(505, 89);
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
            this.cmbBxEventEndTime.Location = new System.Drawing.Point(625, 114);
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
            this.cmbBxEventStartTime.Location = new System.Drawing.Point(180, 114);
            this.cmbBxEventStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxEventStartTime.Name = "cmbBxEventStartTime";
            this.cmbBxEventStartTime.Size = new System.Drawing.Size(263, 24);
            this.cmbBxEventStartTime.TabIndex = 28;
            // 
            // radioBtnExam
            // 
            this.radioBtnExam.AutoSize = true;
            this.radioBtnExam.Location = new System.Drawing.Point(775, 55);
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
            this.radioBtnTraining.Location = new System.Drawing.Point(625, 55);
            this.radioBtnTraining.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnTraining.Name = "radioBtnTraining";
            this.radioBtnTraining.Size = new System.Drawing.Size(77, 20);
            this.radioBtnTraining.TabIndex = 26;
            this.radioBtnTraining.TabStop = true;
            this.radioBtnTraining.Text = "Training";
            this.radioBtnTraining.UseVisualStyleBackColor = true;
            // 
            // cmbBxSlctEvent
            // 
            this.cmbBxSlctEvent.FormattingEnabled = true;
            this.cmbBxSlctEvent.Location = new System.Drawing.Point(180, 22);
            this.cmbBxSlctEvent.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxSlctEvent.Name = "cmbBxSlctEvent";
            this.cmbBxSlctEvent.Size = new System.Drawing.Size(261, 24);
            this.cmbBxSlctEvent.TabIndex = 25;
            this.cmbBxSlctEvent.SelectedIndexChanged += new System.EventHandler(this.cmbBxSlctEvent_SelectedIndexChanged);
            // 
            // lblEventEndTime
            // 
            this.lblEventEndTime.AutoSize = true;
            this.lblEventEndTime.Location = new System.Drawing.Point(505, 118);
            this.lblEventEndTime.Name = "lblEventEndTime";
            this.lblEventEndTime.Size = new System.Drawing.Size(102, 16);
            this.lblEventEndTime.TabIndex = 23;
            this.lblEventEndTime.Text = "Event End Time";
            // 
            // txtBxEventName
            // 
            this.txtBxEventName.Location = new System.Drawing.Point(180, 54);
            this.txtBxEventName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEventName.Name = "txtBxEventName";
            this.txtBxEventName.Size = new System.Drawing.Size(263, 22);
            this.txtBxEventName.TabIndex = 22;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(16, 57);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(81, 16);
            this.lblEventName.TabIndex = 21;
            this.lblEventName.Text = "Event Name";
            // 
            // dtPckrEventStartDate
            // 
            this.dtPckrEventStartDate.Location = new System.Drawing.Point(180, 84);
            this.dtPckrEventStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPckrEventStartDate.Name = "dtPckrEventStartDate";
            this.dtPckrEventStartDate.Size = new System.Drawing.Size(263, 22);
            this.dtPckrEventStartDate.TabIndex = 19;
            this.dtPckrEventStartDate.Value = new System.DateTime(2022, 9, 13, 0, 0, 0, 0);
            // 
            // btnEventDelete
            // 
            this.btnEventDelete.Location = new System.Drawing.Point(328, 241);
            this.btnEventDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEventDelete.Name = "btnEventDelete";
            this.btnEventDelete.Size = new System.Drawing.Size(121, 23);
            this.btnEventDelete.TabIndex = 18;
            this.btnEventDelete.Text = "Delete";
            this.btnEventDelete.UseVisualStyleBackColor = true;
            this.btnEventDelete.Click += new System.EventHandler(this.btnEventDelete_Click);
            // 
            // btnNewEventSubmit
            // 
            this.btnNewEventSubmit.Location = new System.Drawing.Point(6, 241);
            this.btnNewEventSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewEventSubmit.Name = "btnNewEventSubmit";
            this.btnNewEventSubmit.Size = new System.Drawing.Size(129, 23);
            this.btnNewEventSubmit.TabIndex = 16;
            this.btnNewEventSubmit.Text = "Create";
            this.btnNewEventSubmit.UseVisualStyleBackColor = true;
            this.btnNewEventSubmit.Click += new System.EventHandler(this.btnNewEventSubmit_Click);
            // 
            // btnEventCancle
            // 
            this.btnEventCancle.Location = new System.Drawing.Point(773, 241);
            this.btnEventCancle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEventCancle.Name = "btnEventCancle";
            this.btnEventCancle.Size = new System.Drawing.Size(121, 23);
            this.btnEventCancle.TabIndex = 17;
            this.btnEventCancle.Text = "Cancel";
            this.btnEventCancle.UseVisualStyleBackColor = true;
            // 
            // btnEventUpdate
            // 
            this.btnEventUpdate.Location = new System.Drawing.Point(171, 241);
            this.btnEventUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEventUpdate.Name = "btnEventUpdate";
            this.btnEventUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnEventUpdate.TabIndex = 15;
            this.btnEventUpdate.Text = "Update";
            this.btnEventUpdate.UseVisualStyleBackColor = true;
            this.btnEventUpdate.Click += new System.EventHandler(this.btnEventUpdate_Click);
            // 
            // lblEventStartDate
            // 
            this.lblEventStartDate.AutoSize = true;
            this.lblEventStartDate.Location = new System.Drawing.Point(16, 89);
            this.lblEventStartDate.Name = "lblEventStartDate";
            this.lblEventStartDate.Size = new System.Drawing.Size(103, 16);
            this.lblEventStartDate.TabIndex = 9;
            this.lblEventStartDate.Text = "Event Start Date";
            // 
            // lblEventStartTime
            // 
            this.lblEventStartTime.AutoSize = true;
            this.lblEventStartTime.Location = new System.Drawing.Point(16, 118);
            this.lblEventStartTime.Name = "lblEventStartTime";
            this.lblEventStartTime.Size = new System.Drawing.Size(105, 16);
            this.lblEventStartTime.TabIndex = 6;
            this.lblEventStartTime.Text = "Event Start Time";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(505, 58);
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
            this.txtBxEventID.Location = new System.Drawing.Point(625, 23);
            this.txtBxEventID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxEventID.Name = "txtBxEventID";
            this.txtBxEventID.Size = new System.Drawing.Size(263, 22);
            this.txtBxEventID.TabIndex = 1;
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(505, 26);
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
            this.tabPgBooking.Size = new System.Drawing.Size(916, 511);
            this.tabPgBooking.TabIndex = 4;
            this.tabPgBooking.Text = "Booking";
            this.tabPgBooking.UseVisualStyleBackColor = true;
            // 
            // grpBxBooking
            // 
            this.grpBxBooking.Controls.Add(this.lstBxBookAttendees);
            this.grpBxBooking.Controls.Add(this.txtBxBookingName);
            this.grpBxBooking.Controls.Add(this.lblBookingName);
            this.grpBxBooking.Controls.Add(this.btnBookAddAttend);
            this.grpBxBooking.Controls.Add(this.cmbBxBookSlctClient);
            this.grpBxBooking.Controls.Add(this.lblBookAttendee);
            this.grpBxBooking.Controls.Add(this.btnBookApply);
            this.grpBxBooking.Controls.Add(this.btnBookCancel);
            this.grpBxBooking.Controls.Add(this.btnBookUpdate);
            this.grpBxBooking.Controls.Add(this.btnBookCreate);
            this.grpBxBooking.Controls.Add(this.radioBtnNotApproved);
            this.grpBxBooking.Controls.Add(this.radioBtnApproved);
            this.grpBxBooking.Controls.Add(this.lblBookApprove);
            this.grpBxBooking.Controls.Add(this.lblBookAttendees);
            this.grpBxBooking.Controls.Add(this.cmbBxBookSlctTrain);
            this.grpBxBooking.Controls.Add(this.lblBookSlctTrainer);
            this.grpBxBooking.Controls.Add(this.cmbBxBookSlctEvent);
            this.grpBxBooking.Controls.Add(this.lblBookSlctEvent);
            this.grpBxBooking.Controls.Add(this.txtBxBookComments);
            this.grpBxBooking.Controls.Add(this.lblBookComments);
            this.grpBxBooking.Controls.Add(this.cmbBxBookSlctBook);
            this.grpBxBooking.Controls.Add(this.lblBookSlctBooking);
            this.grpBxBooking.Controls.Add(this.txtBxBookingID);
            this.grpBxBooking.Controls.Add(this.lblBookingID);
            this.grpBxBooking.Location = new System.Drawing.Point(8, 7);
            this.grpBxBooking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxBooking.Name = "grpBxBooking";
            this.grpBxBooking.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxBooking.Size = new System.Drawing.Size(893, 491);
            this.grpBxBooking.TabIndex = 0;
            this.grpBxBooking.TabStop = false;
            this.grpBxBooking.Text = "Bookings";
            // 
            // lstBxBookAttendees
            // 
            this.lstBxBookAttendees.FormattingEnabled = true;
            this.lstBxBookAttendees.ItemHeight = 16;
            this.lstBxBookAttendees.Location = new System.Drawing.Point(156, 113);
            this.lstBxBookAttendees.Margin = new System.Windows.Forms.Padding(4);
            this.lstBxBookAttendees.Name = "lstBxBookAttendees";
            this.lstBxBookAttendees.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBxBookAttendees.Size = new System.Drawing.Size(280, 196);
            this.lstBxBookAttendees.TabIndex = 50;
            // 
            // txtBxBookingName
            // 
            this.txtBxBookingName.Location = new System.Drawing.Point(593, 53);
            this.txtBxBookingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxBookingName.Multiline = true;
            this.txtBxBookingName.Name = "txtBxBookingName";
            this.txtBxBookingName.Size = new System.Drawing.Size(281, 24);
            this.txtBxBookingName.TabIndex = 48;
            // 
            // lblBookingName
            // 
            this.lblBookingName.AutoSize = true;
            this.lblBookingName.Location = new System.Drawing.Point(444, 57);
            this.lblBookingName.Name = "lblBookingName";
            this.lblBookingName.Size = new System.Drawing.Size(97, 16);
            this.lblBookingName.TabIndex = 47;
            this.lblBookingName.Text = "Booking Name";
            // 
            // btnBookAddAttend
            // 
            this.btnBookAddAttend.Location = new System.Drawing.Point(593, 114);
            this.btnBookAddAttend.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookAddAttend.Name = "btnBookAddAttend";
            this.btnBookAddAttend.Size = new System.Drawing.Size(137, 28);
            this.btnBookAddAttend.TabIndex = 46;
            this.btnBookAddAttend.Text = "Add Attendee";
            this.btnBookAddAttend.UseVisualStyleBackColor = true;
            this.btnBookAddAttend.Click += new System.EventHandler(this.btnAddAttendee_Click);
            // 
            // cmbBxBookSlctClient
            // 
            this.cmbBxBookSlctClient.FormattingEnabled = true;
            this.cmbBxBookSlctClient.Location = new System.Drawing.Point(593, 82);
            this.cmbBxBookSlctClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBxBookSlctClient.Name = "cmbBxBookSlctClient";
            this.cmbBxBookSlctClient.Size = new System.Drawing.Size(281, 24);
            this.cmbBxBookSlctClient.TabIndex = 45;
            // 
            // lblBookAttendee
            // 
            this.lblBookAttendee.AutoSize = true;
            this.lblBookAttendee.Location = new System.Drawing.Point(444, 86);
            this.lblBookAttendee.Name = "lblBookAttendee";
            this.lblBookAttendee.Size = new System.Drawing.Size(61, 16);
            this.lblBookAttendee.TabIndex = 44;
            this.lblBookAttendee.Text = "Attendee";
            // 
            // btnBookApply
            // 
            this.btnBookApply.Location = new System.Drawing.Point(668, 446);
            this.btnBookApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookApply.Name = "btnBookApply";
            this.btnBookApply.Size = new System.Drawing.Size(100, 28);
            this.btnBookApply.TabIndex = 43;
            this.btnBookApply.Text = "Apply";
            this.btnBookApply.UseVisualStyleBackColor = true;
            // 
            // btnBookCancel
            // 
            this.btnBookCancel.Location = new System.Drawing.Point(776, 446);
            this.btnBookCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookCancel.Name = "btnBookCancel";
            this.btnBookCancel.Size = new System.Drawing.Size(100, 28);
            this.btnBookCancel.TabIndex = 42;
            this.btnBookCancel.Text = "Cancle";
            this.btnBookCancel.UseVisualStyleBackColor = true;
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(108, 446);
            this.btnBookUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnBookUpdate.TabIndex = 41;
            this.btnBookUpdate.Text = "Update";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            // 
            // btnBookCreate
            // 
            this.btnBookCreate.Location = new System.Drawing.Point(0, 446);
            this.btnBookCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnBookCreate.Name = "btnBookCreate";
            this.btnBookCreate.Size = new System.Drawing.Size(100, 28);
            this.btnBookCreate.TabIndex = 40;
            this.btnBookCreate.Text = "Create";
            this.btnBookCreate.UseVisualStyleBackColor = true;
            this.btnBookCreate.Click += new System.EventHandler(this.btnBookCreate_Click);
            // 
            // radioBtnNotApproved
            // 
            this.radioBtnNotApproved.AutoSize = true;
            this.radioBtnNotApproved.Checked = true;
            this.radioBtnNotApproved.Location = new System.Drawing.Point(593, 181);
            this.radioBtnNotApproved.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.radioBtnApproved.Location = new System.Drawing.Point(593, 149);
            this.radioBtnApproved.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnApproved.Name = "radioBtnApproved";
            this.radioBtnApproved.Size = new System.Drawing.Size(88, 20);
            this.radioBtnApproved.TabIndex = 38;
            this.radioBtnApproved.Text = "Approved";
            this.radioBtnApproved.UseVisualStyleBackColor = true;
            // 
            // lblBookApprove
            // 
            this.lblBookApprove.AutoSize = true;
            this.lblBookApprove.Location = new System.Drawing.Point(444, 149);
            this.lblBookApprove.Name = "lblBookApprove";
            this.lblBookApprove.Size = new System.Drawing.Size(67, 16);
            this.lblBookApprove.TabIndex = 37;
            this.lblBookApprove.Text = "Approved";
            // 
            // lblBookAttendees
            // 
            this.lblBookAttendees.AutoSize = true;
            this.lblBookAttendees.Location = new System.Drawing.Point(7, 114);
            this.lblBookAttendees.Name = "lblBookAttendees";
            this.lblBookAttendees.Size = new System.Drawing.Size(68, 16);
            this.lblBookAttendees.TabIndex = 33;
            this.lblBookAttendees.Text = "Attendees";
            // 
            // cmbBxBookSlctTrain
            // 
            this.cmbBxBookSlctTrain.FormattingEnabled = true;
            this.cmbBxBookSlctTrain.Location = new System.Drawing.Point(156, 82);
            this.cmbBxBookSlctTrain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBxBookSlctTrain.Name = "cmbBxBookSlctTrain";
            this.cmbBxBookSlctTrain.Size = new System.Drawing.Size(281, 24);
            this.cmbBxBookSlctTrain.TabIndex = 31;
            // 
            // lblBookSlctTrainer
            // 
            this.lblBookSlctTrainer.AutoSize = true;
            this.lblBookSlctTrainer.Location = new System.Drawing.Point(7, 86);
            this.lblBookSlctTrainer.Name = "lblBookSlctTrainer";
            this.lblBookSlctTrainer.Size = new System.Drawing.Size(50, 16);
            this.lblBookSlctTrainer.TabIndex = 30;
            this.lblBookSlctTrainer.Text = "Trainer";
            // 
            // cmbBxBookSlctEvent
            // 
            this.cmbBxBookSlctEvent.FormattingEnabled = true;
            this.cmbBxBookSlctEvent.Location = new System.Drawing.Point(156, 52);
            this.cmbBxBookSlctEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBxBookSlctEvent.Name = "cmbBxBookSlctEvent";
            this.cmbBxBookSlctEvent.Size = new System.Drawing.Size(281, 24);
            this.cmbBxBookSlctEvent.TabIndex = 29;
            // 
            // lblBookSlctEvent
            // 
            this.lblBookSlctEvent.AutoSize = true;
            this.lblBookSlctEvent.Location = new System.Drawing.Point(7, 55);
            this.lblBookSlctEvent.Name = "lblBookSlctEvent";
            this.lblBookSlctEvent.Size = new System.Drawing.Size(131, 16);
            this.lblBookSlctEvent.TabIndex = 28;
            this.lblBookSlctEvent.Text = "Select Event to Book";
            // 
            // txtBxBookComments
            // 
            this.txtBxBookComments.Location = new System.Drawing.Point(156, 316);
            this.txtBxBookComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxBookComments.Multiline = true;
            this.txtBxBookComments.Name = "txtBxBookComments";
            this.txtBxBookComments.Size = new System.Drawing.Size(719, 122);
            this.txtBxBookComments.TabIndex = 27;
            // 
            // lblBookComments
            // 
            this.lblBookComments.AutoSize = true;
            this.lblBookComments.Location = new System.Drawing.Point(7, 319);
            this.lblBookComments.Name = "lblBookComments";
            this.lblBookComments.Size = new System.Drawing.Size(71, 16);
            this.lblBookComments.TabIndex = 26;
            this.lblBookComments.Text = "Comments";
            // 
            // cmbBxBookSlctBook
            // 
            this.cmbBxBookSlctBook.FormattingEnabled = true;
            this.cmbBxBookSlctBook.Location = new System.Drawing.Point(156, 21);
            this.cmbBxBookSlctBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBxBookSlctBook.Name = "cmbBxBookSlctBook";
            this.cmbBxBookSlctBook.Size = new System.Drawing.Size(281, 24);
            this.cmbBxBookSlctBook.TabIndex = 25;
            this.cmbBxBookSlctBook.SelectedIndexChanged += new System.EventHandler(this.cmbBxSlctBooking_SelectedIndexChanged);
            // 
            // lblBookSlctBooking
            // 
            this.lblBookSlctBooking.AutoSize = true;
            this.lblBookSlctBooking.Location = new System.Drawing.Point(7, 25);
            this.lblBookSlctBooking.Name = "lblBookSlctBooking";
            this.lblBookSlctBooking.Size = new System.Drawing.Size(98, 16);
            this.lblBookSlctBooking.TabIndex = 24;
            this.lblBookSlctBooking.Text = "Select Booking";
            // 
            // txtBxBookingID
            // 
            this.txtBxBookingID.Location = new System.Drawing.Point(593, 22);
            this.txtBxBookingID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxBookingID.Name = "txtBxBookingID";
            this.txtBxBookingID.ReadOnly = true;
            this.txtBxBookingID.Size = new System.Drawing.Size(281, 22);
            this.txtBxBookingID.TabIndex = 21;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(444, 25);
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
            this.tabPgReporting.Size = new System.Drawing.Size(916, 511);
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
            this.grpBxReporting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxReporting.Name = "grpBxReporting";
            this.grpBxReporting.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBxReporting.Size = new System.Drawing.Size(971, 533);
            this.grpBxReporting.TabIndex = 0;
            this.grpBxReporting.TabStop = false;
            this.grpBxReporting.Text = "Reporting";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(483, 320);
            this.listBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(457, 212);
            this.listBox4.TabIndex = 11;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(483, 78);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(457, 212);
            this.listBox3.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(9, 320);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(457, 212);
            this.listBox2.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(9, 78);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(457, 212);
            this.listBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 302);
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
            this.label4.Location = new System.Drawing.Point(5, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "User information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Training done";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(413, 21);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bookings";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 21);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Events";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Client";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Admin/Trainer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grtBxNewSignUp
            // 
            this.grtBxNewSignUp.AutoSize = true;
            this.grtBxNewSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grtBxNewSignUp.Controls.Add(this.btnSignUp);
            this.grtBxNewSignUp.Controls.Add(this.btnSignCancel);
            this.grtBxNewSignUp.Location = new System.Drawing.Point(485, 251);
            this.grtBxNewSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.grtBxNewSignUp.Name = "grtBxNewSignUp";
            this.grtBxNewSignUp.Padding = new System.Windows.Forms.Padding(4);
            this.grtBxNewSignUp.Size = new System.Drawing.Size(224, 74);
            this.grtBxNewSignUp.TabIndex = 1;
            this.grtBxNewSignUp.TabStop = false;
            this.grtBxNewSignUp.Text = "New Sign up";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(8, 23);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 28);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignCancel
            // 
            this.btnSignCancel.Location = new System.Drawing.Point(116, 23);
            this.btnSignCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignCancel.Name = "btnSignCancel";
            this.btnSignCancel.Size = new System.Drawing.Size(100, 28);
            this.btnSignCancel.TabIndex = 5;
            this.btnSignCancel.Text = "Cancel";
            this.btnSignCancel.UseVisualStyleBackColor = true;
            // 
            // grpBxLogin
            // 
            this.grpBxLogin.AutoSize = true;
            this.grpBxLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxLogin.Controls.Add(this.btnCancel);
            this.grpBxLogin.Controls.Add(this.btnLogin);
            this.grpBxLogin.Location = new System.Drawing.Point(249, 251);
            this.grpBxLogin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grpBxLogin.Name = "grpBxLogin";
            this.grpBxLogin.Padding = new System.Windows.Forms.Padding(4);
            this.grpBxLogin.Size = new System.Drawing.Size(224, 74);
            this.grpBxLogin.TabIndex = 0;
            this.grpBxLogin.TabStop = false;
            this.grpBxLogin.Text = "User Login";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(116, 23);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(8, 23);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(945, 578);
            this.Controls.Add(this.tabCtrlMain);
            this.Controls.Add(this.grtBxNewSignUp);
            this.Controls.Add(this.grpBxLogin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabCtrlMain.ResumeLayout(false);
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
            this.grtBxNewSignUp.ResumeLayout(false);
            this.grpBxLogin.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPgUser;
        private System.Windows.Forms.TabPage tabPgClient;
        private System.Windows.Forms.TabPage tabPgEvent;
        private System.Windows.Forms.TabPage tabPgBooking;
        private System.Windows.Forms.TabPage tabPgReporting;
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
        private System.Windows.Forms.ComboBox cmbBxSlctEvent;
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
        private System.Windows.Forms.Label lblBookAttendees;
        private System.Windows.Forms.ComboBox cmbBxBookSlctTrain;
        private System.Windows.Forms.Label lblBookSlctTrainer;
        private System.Windows.Forms.ComboBox cmbBxBookSlctEvent;
        private System.Windows.Forms.Label lblBookSlctEvent;
        private System.Windows.Forms.TextBox txtBxBookComments;
        private System.Windows.Forms.Label lblBookComments;
        private System.Windows.Forms.ComboBox cmbBxBookSlctBook;
        private System.Windows.Forms.Label lblBookSlctBooking;
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
        private System.Windows.Forms.GroupBox grtBxNewSignUp;
        private System.Windows.Forms.Button btnSignCancel;
        private System.Windows.Forms.GroupBox grpBxLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnBookApply;
        private System.Windows.Forms.Button btnBookCancel;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.Button btnBookCreate;
        private System.Windows.Forms.Button btnBookAddAttend;
        private System.Windows.Forms.ComboBox cmbBxBookSlctClient;
        private System.Windows.Forms.Label lblBookAttendee;
        private System.Windows.Forms.TextBox txtBxBookingName;
        private System.Windows.Forms.Label lblBookingName;
        private System.Windows.Forms.ListBox lstBxBookAttendees;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rTxtBxDiscription;
        private System.Windows.Forms.Label txtDiscription;
    }
}

