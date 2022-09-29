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
            this.lblEventDiscr = new System.Windows.Forms.Label();
            this.txtBxEventDiscrip = new System.Windows.Forms.TextBox();
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
            this.btnBookDelet = new System.Windows.Forms.Button();
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
            this.btnRprtGenerate = new System.Windows.Forms.Button();
            this.grpBxDataView = new System.Windows.Forms.GroupBox();
            this.dtgrvRprt = new System.Windows.Forms.DataGridView();
            this.grpBxRprtType = new System.Windows.Forms.GroupBox();
            this.radioBtnRprtTypeDetaild = new System.Windows.Forms.RadioButton();
            this.radioBtnRprtTypeSummery = new System.Windows.Forms.RadioButton();
            this.grpBxRprtDate = new System.Windows.Forms.GroupBox();
            this.lblRprtEndDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblRprtStartDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpBxEvents = new System.Windows.Forms.GroupBox();
            this.radioBtnRprtEventAll = new System.Windows.Forms.RadioButton();
            this.radioBtnRprtEventExams = new System.Windows.Forms.RadioButton();
            this.radioBtnRprtEventTrain = new System.Windows.Forms.RadioButton();
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
            this.grpBxDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvRprt)).BeginInit();
            this.grpBxRprtType.SuspendLayout();
            this.grpBxRprtDate.SuspendLayout();
            this.grpBxEvents.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eventToolStripMenuItem.Text = "Event";
            this.eventToolStripMenuItem.Click += new System.EventHandler(this.eventToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // reprotingToolStripMenuItem
            // 
            this.reprotingToolStripMenuItem.Name = "reprotingToolStripMenuItem";
            this.reprotingToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
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
            this.tabCtrlMain.Location = new System.Drawing.Point(10, 26);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(693, 439);
            this.tabCtrlMain.TabIndex = 1;
            // 
            // tabPgUser
            // 
            this.tabPgUser.Controls.Add(this.grpBxEdUser);
            this.tabPgUser.Location = new System.Drawing.Point(4, 22);
            this.tabPgUser.Name = "tabPgUser";
            this.tabPgUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgUser.Size = new System.Drawing.Size(685, 413);
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
            this.grpBxEdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxEdUser.Location = new System.Drawing.Point(3, 3);
            this.grpBxEdUser.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxEdUser.Name = "grpBxEdUser";
            this.grpBxEdUser.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxEdUser.Size = new System.Drawing.Size(679, 407);
            this.grpBxEdUser.TabIndex = 12;
            this.grpBxEdUser.TabStop = false;
            this.grpBxEdUser.Text = "User";
            // 
            // cmbBxEdSlctUser
            // 
            this.cmbBxEdSlctUser.FormattingEnabled = true;
            this.cmbBxEdSlctUser.Location = new System.Drawing.Point(115, 26);
            this.cmbBxEdSlctUser.Name = "cmbBxEdSlctUser";
            this.cmbBxEdSlctUser.Size = new System.Drawing.Size(215, 21);
            this.cmbBxEdSlctUser.TabIndex = 16;
            this.cmbBxEdSlctUser.SelectedIndexChanged += new System.EventHandler(this.cmbBxEdSlctUser_SelectedIndexChanged);
            // 
            // btnEdDelete
            // 
            this.btnEdDelete.Location = new System.Drawing.Point(243, 378);
            this.btnEdDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdDelete.Name = "btnEdDelete";
            this.btnEdDelete.Size = new System.Drawing.Size(91, 25);
            this.btnEdDelete.TabIndex = 14;
            this.btnEdDelete.Text = "Delete";
            this.btnEdDelete.UseVisualStyleBackColor = true;
            this.btnEdDelete.Click += new System.EventHandler(this.btnEdDelete_Click);
            // 
            // btnEdNewUserSubmit
            // 
            this.btnEdNewUserSubmit.Location = new System.Drawing.Point(8, 378);
            this.btnEdNewUserSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdNewUserSubmit.Name = "btnEdNewUserSubmit";
            this.btnEdNewUserSubmit.Size = new System.Drawing.Size(91, 25);
            this.btnEdNewUserSubmit.TabIndex = 13;
            this.btnEdNewUserSubmit.Text = "Create";
            this.btnEdNewUserSubmit.UseVisualStyleBackColor = true;
            this.btnEdNewUserSubmit.Click += new System.EventHandler(this.btnEdNewUserSubmit_Click);
            // 
            // btnEdCancel
            // 
            this.btnEdCancel.Location = new System.Drawing.Point(560, 378);
            this.btnEdCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdCancel.Name = "btnEdCancel";
            this.btnEdCancel.Size = new System.Drawing.Size(91, 25);
            this.btnEdCancel.TabIndex = 13;
            this.btnEdCancel.Text = "Cancel";
            this.btnEdCancel.UseVisualStyleBackColor = true;
            this.btnEdCancel.Click += new System.EventHandler(this.btnEdCancel_Click);
            // 
            // btnEdUpdate
            // 
            this.btnEdUpdate.Location = new System.Drawing.Point(119, 378);
            this.btnEdUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdUpdate.Name = "btnEdUpdate";
            this.btnEdUpdate.Size = new System.Drawing.Size(91, 25);
            this.btnEdUpdate.TabIndex = 12;
            this.btnEdUpdate.Text = "Update";
            this.btnEdUpdate.UseVisualStyleBackColor = true;
            this.btnEdUpdate.Click += new System.EventHandler(this.btnEdUpdate_Click);
            // 
            // lblSlctUser
            // 
            this.lblSlctUser.AutoSize = true;
            this.lblSlctUser.Location = new System.Drawing.Point(5, 29);
            this.lblSlctUser.Name = "lblSlctUser";
            this.lblSlctUser.Size = new System.Drawing.Size(62, 13);
            this.lblSlctUser.TabIndex = 0;
            this.lblSlctUser.Text = "Select User";
            // 
            // txtBxEdPassword
            // 
            this.txtBxEdPassword.Location = new System.Drawing.Point(115, 100);
            this.txtBxEdPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxEdPassword.Name = "txtBxEdPassword";
            this.txtBxEdPassword.Size = new System.Drawing.Size(215, 20);
            this.txtBxEdPassword.TabIndex = 11;
            // 
            // lblEdPassword
            // 
            this.lblEdPassword.AutoSize = true;
            this.lblEdPassword.Location = new System.Drawing.Point(5, 102);
            this.lblEdPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdPassword.Name = "lblEdPassword";
            this.lblEdPassword.Size = new System.Drawing.Size(53, 13);
            this.lblEdPassword.TabIndex = 10;
            this.lblEdPassword.Text = "Password";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(363, 28);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(43, 13);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "User ID";
            // 
            // txtBxEdEmail
            // 
            this.txtBxEdEmail.Location = new System.Drawing.Point(115, 76);
            this.txtBxEdEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxEdEmail.Name = "txtBxEdEmail";
            this.txtBxEdEmail.Size = new System.Drawing.Size(215, 20);
            this.txtBxEdEmail.TabIndex = 9;
            // 
            // txtBxUserID
            // 
            this.txtBxUserID.Enabled = false;
            this.txtBxUserID.Location = new System.Drawing.Point(432, 26);
            this.txtBxUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxUserID.Name = "txtBxUserID";
            this.txtBxUserID.ReadOnly = true;
            this.txtBxUserID.Size = new System.Drawing.Size(215, 20);
            this.txtBxUserID.TabIndex = 3;
            // 
            // lblEdEmail
            // 
            this.lblEdEmail.AutoSize = true;
            this.lblEdEmail.Location = new System.Drawing.Point(5, 79);
            this.lblEdEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdEmail.Name = "lblEdEmail";
            this.lblEdEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEdEmail.TabIndex = 8;
            this.lblEdEmail.Text = "Email";
            // 
            // lblEdName
            // 
            this.lblEdName.AutoSize = true;
            this.lblEdName.Location = new System.Drawing.Point(5, 54);
            this.lblEdName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdName.Name = "lblEdName";
            this.lblEdName.Size = new System.Drawing.Size(35, 13);
            this.lblEdName.TabIndex = 4;
            this.lblEdName.Text = "Name";
            // 
            // txtBxEdSurname
            // 
            this.txtBxEdSurname.Location = new System.Drawing.Point(432, 51);
            this.txtBxEdSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxEdSurname.Name = "txtBxEdSurname";
            this.txtBxEdSurname.Size = new System.Drawing.Size(215, 20);
            this.txtBxEdSurname.TabIndex = 7;
            // 
            // txtBxEdName
            // 
            this.txtBxEdName.Location = new System.Drawing.Point(115, 52);
            this.txtBxEdName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxEdName.Name = "txtBxEdName";
            this.txtBxEdName.Size = new System.Drawing.Size(215, 20);
            this.txtBxEdName.TabIndex = 5;
            // 
            // lblEdSername
            // 
            this.lblEdSername.AutoSize = true;
            this.lblEdSername.Location = new System.Drawing.Point(363, 53);
            this.lblEdSername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdSername.Name = "lblEdSername";
            this.lblEdSername.Size = new System.Drawing.Size(49, 13);
            this.lblEdSername.TabIndex = 6;
            this.lblEdSername.Text = "Surname";
            // 
            // tabPgClient
            // 
            this.tabPgClient.Controls.Add(this.grpBxEdClient);
            this.tabPgClient.Location = new System.Drawing.Point(4, 22);
            this.tabPgClient.Name = "tabPgClient";
            this.tabPgClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgClient.Size = new System.Drawing.Size(685, 413);
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
            this.grpBxEdClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxEdClient.Location = new System.Drawing.Point(3, 3);
            this.grpBxEdClient.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxEdClient.Name = "grpBxEdClient";
            this.grpBxEdClient.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxEdClient.Size = new System.Drawing.Size(679, 407);
            this.grpBxEdClient.TabIndex = 13;
            this.grpBxEdClient.TabStop = false;
            this.grpBxEdClient.Text = "Client";
            // 
            // cmbBxEdSlctClient
            // 
            this.cmbBxEdSlctClient.FormattingEnabled = true;
            this.cmbBxEdSlctClient.Location = new System.Drawing.Point(115, 25);
            this.cmbBxEdSlctClient.Name = "cmbBxEdSlctClient";
            this.cmbBxEdSlctClient.Size = new System.Drawing.Size(215, 21);
            this.cmbBxEdSlctClient.TabIndex = 15;
            this.cmbBxEdSlctClient.SelectedIndexChanged += new System.EventHandler(this.cmbBxEdSlctClient_SelectedIndexChanged);
            // 
            // txtBxEdClientID
            // 
            this.txtBxEdClientID.Enabled = false;
            this.txtBxEdClientID.Location = new System.Drawing.Point(432, 26);
            this.txtBxEdClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxEdClientID.Name = "txtBxEdClientID";
            this.txtBxEdClientID.ReadOnly = true;
            this.txtBxEdClientID.Size = new System.Drawing.Size(215, 20);
            this.txtBxEdClientID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client ID";
            // 
            // btnEdClientDelete
            // 
            this.btnEdClientDelete.Location = new System.Drawing.Point(242, 378);
            this.btnEdClientDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdClientDelete.Name = "btnEdClientDelete";
            this.btnEdClientDelete.Size = new System.Drawing.Size(91, 25);
            this.btnEdClientDelete.TabIndex = 14;
            this.btnEdClientDelete.Text = "Delete";
            this.btnEdClientDelete.UseVisualStyleBackColor = true;
            this.btnEdClientDelete.Click += new System.EventHandler(this.btnEdClientDelete_Click);
            // 
            // btnEdNewClientSubmit
            // 
            this.btnEdNewClientSubmit.Location = new System.Drawing.Point(8, 378);
            this.btnEdNewClientSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdNewClientSubmit.Name = "btnEdNewClientSubmit";
            this.btnEdNewClientSubmit.Size = new System.Drawing.Size(91, 25);
            this.btnEdNewClientSubmit.TabIndex = 13;
            this.btnEdNewClientSubmit.Text = "Create";
            this.btnEdNewClientSubmit.UseVisualStyleBackColor = true;
            this.btnEdNewClientSubmit.Click += new System.EventHandler(this.btnEdNewClientSubmit_Click);
            // 
            // btnEdClientCancel
            // 
            this.btnEdClientCancel.Location = new System.Drawing.Point(559, 378);
            this.btnEdClientCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdClientCancel.Name = "btnEdClientCancel";
            this.btnEdClientCancel.Size = new System.Drawing.Size(91, 25);
            this.btnEdClientCancel.TabIndex = 13;
            this.btnEdClientCancel.Text = "Cancel";
            this.btnEdClientCancel.UseVisualStyleBackColor = true;
            this.btnEdClientCancel.Click += new System.EventHandler(this.btnEdClientCancel_Click);
            // 
            // btnEdClientUpdate
            // 
            this.btnEdClientUpdate.Location = new System.Drawing.Point(118, 378);
            this.btnEdClientUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdClientUpdate.Name = "btnEdClientUpdate";
            this.btnEdClientUpdate.Size = new System.Drawing.Size(91, 25);
            this.btnEdClientUpdate.TabIndex = 12;
            this.btnEdClientUpdate.Text = "Update";
            this.btnEdClientUpdate.UseVisualStyleBackColor = true;
            this.btnEdClientUpdate.Click += new System.EventHandler(this.btnEdClientUpdate_Click);
            // 
            // lblEdSlctClient
            // 
            this.lblEdSlctClient.AutoSize = true;
            this.lblEdSlctClient.Location = new System.Drawing.Point(5, 29);
            this.lblEdSlctClient.Name = "lblEdSlctClient";
            this.lblEdSlctClient.Size = new System.Drawing.Size(66, 13);
            this.lblEdSlctClient.TabIndex = 0;
            this.lblEdSlctClient.Text = "Select Client";
            // 
            // txtBxEdClientPassword
            // 
            this.txtBxEdClientPassword.Location = new System.Drawing.Point(115, 99);
            this.txtBxEdClientPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxEdClientPassword.Name = "txtBxEdClientPassword";
            this.txtBxEdClientPassword.Size = new System.Drawing.Size(215, 20);
            this.txtBxEdClientPassword.TabIndex = 11;
            // 
            // lblEdClientPassword
            // 
            this.lblEdClientPassword.AutoSize = true;
            this.lblEdClientPassword.Location = new System.Drawing.Point(5, 102);
            this.lblEdClientPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdClientPassword.Name = "lblEdClientPassword";
            this.lblEdClientPassword.Size = new System.Drawing.Size(53, 13);
            this.lblEdClientPassword.TabIndex = 10;
            this.lblEdClientPassword.Text = "Password";
            // 
            // txtBxEdClientEmail
            // 
            this.txtBxEdClientEmail.Location = new System.Drawing.Point(115, 75);
            this.txtBxEdClientEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxEdClientEmail.Name = "txtBxEdClientEmail";
            this.txtBxEdClientEmail.Size = new System.Drawing.Size(215, 20);
            this.txtBxEdClientEmail.TabIndex = 9;
            // 
            // lblEdClientEmail
            // 
            this.lblEdClientEmail.AutoSize = true;
            this.lblEdClientEmail.Location = new System.Drawing.Point(5, 79);
            this.lblEdClientEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdClientEmail.Name = "lblEdClientEmail";
            this.lblEdClientEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEdClientEmail.TabIndex = 8;
            this.lblEdClientEmail.Text = "Email";
            // 
            // lblEdClientName
            // 
            this.lblEdClientName.AutoSize = true;
            this.lblEdClientName.Location = new System.Drawing.Point(5, 54);
            this.lblEdClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdClientName.Name = "lblEdClientName";
            this.lblEdClientName.Size = new System.Drawing.Size(35, 13);
            this.lblEdClientName.TabIndex = 4;
            this.lblEdClientName.Text = "Name";
            // 
            // txtBxEdClientSurname
            // 
            this.txtBxEdClientSurname.Location = new System.Drawing.Point(432, 50);
            this.txtBxEdClientSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxEdClientSurname.Name = "txtBxEdClientSurname";
            this.txtBxEdClientSurname.Size = new System.Drawing.Size(215, 20);
            this.txtBxEdClientSurname.TabIndex = 7;
            // 
            // txtBxEdClientName
            // 
            this.txtBxEdClientName.Location = new System.Drawing.Point(115, 51);
            this.txtBxEdClientName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxEdClientName.Name = "txtBxEdClientName";
            this.txtBxEdClientName.Size = new System.Drawing.Size(215, 20);
            this.txtBxEdClientName.TabIndex = 5;
            // 
            // lblEdClientSername
            // 
            this.lblEdClientSername.AutoSize = true;
            this.lblEdClientSername.Location = new System.Drawing.Point(363, 52);
            this.lblEdClientSername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdClientSername.Name = "lblEdClientSername";
            this.lblEdClientSername.Size = new System.Drawing.Size(49, 13);
            this.lblEdClientSername.TabIndex = 6;
            this.lblEdClientSername.Text = "Surname";
            // 
            // tabPgEvent
            // 
            this.tabPgEvent.Controls.Add(this.grpBxEvent);
            this.tabPgEvent.Location = new System.Drawing.Point(4, 22);
            this.tabPgEvent.Name = "tabPgEvent";
            this.tabPgEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgEvent.Size = new System.Drawing.Size(685, 413);
            this.tabPgEvent.TabIndex = 3;
            this.tabPgEvent.Text = "Event";
            this.tabPgEvent.UseVisualStyleBackColor = true;
            // 
            // grpBxEvent
            // 
            this.grpBxEvent.AutoSize = true;
            this.grpBxEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxEvent.Controls.Add(this.lblEventDiscr);
            this.grpBxEvent.Controls.Add(this.txtBxEventDiscrip);
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
            this.grpBxEvent.Location = new System.Drawing.Point(3, 3);
            this.grpBxEvent.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxEvent.Name = "grpBxEvent";
            this.grpBxEvent.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxEvent.Size = new System.Drawing.Size(679, 407);
            this.grpBxEvent.TabIndex = 0;
            this.grpBxEvent.TabStop = false;
            this.grpBxEvent.Text = "Events";
            // 
            // lblEventDiscr
            // 
            this.lblEventDiscr.AutoSize = true;
            this.lblEventDiscr.Location = new System.Drawing.Point(12, 127);
            this.lblEventDiscr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventDiscr.Name = "lblEventDiscr";
            this.lblEventDiscr.Size = new System.Drawing.Size(56, 13);
            this.lblEventDiscr.TabIndex = 33;
            this.lblEventDiscr.Text = "Discription";
            // 
            // txtBxEventDiscrip
            // 
            this.txtBxEventDiscrip.Location = new System.Drawing.Point(135, 124);
            this.txtBxEventDiscrip.Multiline = true;
            this.txtBxEventDiscrip.Name = "txtBxEventDiscrip";
            this.txtBxEventDiscrip.Size = new System.Drawing.Size(532, 104);
            this.txtBxEventDiscrip.TabIndex = 32;
            // 
            // dtPckrEventEndDate
            // 
            this.dtPckrEventEndDate.Location = new System.Drawing.Point(469, 68);
            this.dtPckrEventEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtPckrEventEndDate.Name = "dtPckrEventEndDate";
            this.dtPckrEventEndDate.Size = new System.Drawing.Size(198, 20);
            this.dtPckrEventEndDate.TabIndex = 31;
            this.dtPckrEventEndDate.Value = new System.DateTime(2022, 9, 29, 0, 0, 0, 0);
            // 
            // lblEventEndDate
            // 
            this.lblEventEndDate.AutoSize = true;
            this.lblEventEndDate.Location = new System.Drawing.Point(379, 72);
            this.lblEventEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventEndDate.Name = "lblEventEndDate";
            this.lblEventEndDate.Size = new System.Drawing.Size(83, 13);
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
            this.cmbBxEventEndTime.Location = new System.Drawing.Point(469, 93);
            this.cmbBxEventEndTime.Name = "cmbBxEventEndTime";
            this.cmbBxEventEndTime.Size = new System.Drawing.Size(198, 21);
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
            this.cmbBxEventStartTime.Location = new System.Drawing.Point(135, 93);
            this.cmbBxEventStartTime.Name = "cmbBxEventStartTime";
            this.cmbBxEventStartTime.Size = new System.Drawing.Size(198, 21);
            this.cmbBxEventStartTime.TabIndex = 28;
            // 
            // radioBtnExam
            // 
            this.radioBtnExam.AutoSize = true;
            this.radioBtnExam.Location = new System.Drawing.Point(581, 45);
            this.radioBtnExam.Name = "radioBtnExam";
            this.radioBtnExam.Size = new System.Drawing.Size(51, 17);
            this.radioBtnExam.TabIndex = 27;
            this.radioBtnExam.TabStop = true;
            this.radioBtnExam.Text = "Exam";
            this.radioBtnExam.UseVisualStyleBackColor = true;
            // 
            // radioBtnTraining
            // 
            this.radioBtnTraining.AutoSize = true;
            this.radioBtnTraining.Location = new System.Drawing.Point(469, 45);
            this.radioBtnTraining.Name = "radioBtnTraining";
            this.radioBtnTraining.Size = new System.Drawing.Size(63, 17);
            this.radioBtnTraining.TabIndex = 26;
            this.radioBtnTraining.TabStop = true;
            this.radioBtnTraining.Text = "Training";
            this.radioBtnTraining.UseVisualStyleBackColor = true;
            // 
            // cmbBxSlctEvent
            // 
            this.cmbBxSlctEvent.FormattingEnabled = true;
            this.cmbBxSlctEvent.Location = new System.Drawing.Point(135, 18);
            this.cmbBxSlctEvent.Name = "cmbBxSlctEvent";
            this.cmbBxSlctEvent.Size = new System.Drawing.Size(197, 21);
            this.cmbBxSlctEvent.TabIndex = 25;
            this.cmbBxSlctEvent.SelectedIndexChanged += new System.EventHandler(this.cmbBxSlctEvent_SelectedIndexChanged);
            // 
            // lblEventEndTime
            // 
            this.lblEventEndTime.AutoSize = true;
            this.lblEventEndTime.Location = new System.Drawing.Point(379, 96);
            this.lblEventEndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventEndTime.Name = "lblEventEndTime";
            this.lblEventEndTime.Size = new System.Drawing.Size(83, 13);
            this.lblEventEndTime.TabIndex = 23;
            this.lblEventEndTime.Text = "Event End Time";
            // 
            // txtBxEventName
            // 
            this.txtBxEventName.Location = new System.Drawing.Point(135, 44);
            this.txtBxEventName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxEventName.Name = "txtBxEventName";
            this.txtBxEventName.Size = new System.Drawing.Size(198, 20);
            this.txtBxEventName.TabIndex = 22;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(12, 46);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(66, 13);
            this.lblEventName.TabIndex = 21;
            this.lblEventName.Text = "Event Name";
            // 
            // dtPckrEventStartDate
            // 
            this.dtPckrEventStartDate.Location = new System.Drawing.Point(135, 68);
            this.dtPckrEventStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtPckrEventStartDate.Name = "dtPckrEventStartDate";
            this.dtPckrEventStartDate.Size = new System.Drawing.Size(198, 20);
            this.dtPckrEventStartDate.TabIndex = 19;
            this.dtPckrEventStartDate.Value = new System.DateTime(2022, 9, 29, 0, 0, 0, 0);
            // 
            // btnEventDelete
            // 
            this.btnEventDelete.Location = new System.Drawing.Point(242, 376);
            this.btnEventDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventDelete.Name = "btnEventDelete";
            this.btnEventDelete.Size = new System.Drawing.Size(91, 27);
            this.btnEventDelete.TabIndex = 18;
            this.btnEventDelete.Text = "Delete";
            this.btnEventDelete.UseVisualStyleBackColor = true;
            this.btnEventDelete.Click += new System.EventHandler(this.btnEventDelete_Click);
            // 
            // btnNewEventSubmit
            // 
            this.btnNewEventSubmit.Location = new System.Drawing.Point(15, 376);
            this.btnNewEventSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewEventSubmit.Name = "btnNewEventSubmit";
            this.btnNewEventSubmit.Size = new System.Drawing.Size(97, 27);
            this.btnNewEventSubmit.TabIndex = 16;
            this.btnNewEventSubmit.Text = "Create";
            this.btnNewEventSubmit.UseVisualStyleBackColor = true;
            this.btnNewEventSubmit.Click += new System.EventHandler(this.btnNewEventSubmit_Click);
            // 
            // btnEventCancle
            // 
            this.btnEventCancle.Location = new System.Drawing.Point(576, 376);
            this.btnEventCancle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventCancle.Name = "btnEventCancle";
            this.btnEventCancle.Size = new System.Drawing.Size(91, 27);
            this.btnEventCancle.TabIndex = 17;
            this.btnEventCancle.Text = "Cancel";
            this.btnEventCancle.UseVisualStyleBackColor = true;
            this.btnEventCancle.Click += new System.EventHandler(this.btnEventCancle_Click);
            // 
            // btnEventUpdate
            // 
            this.btnEventUpdate.Location = new System.Drawing.Point(135, 376);
            this.btnEventUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventUpdate.Name = "btnEventUpdate";
            this.btnEventUpdate.Size = new System.Drawing.Size(91, 27);
            this.btnEventUpdate.TabIndex = 15;
            this.btnEventUpdate.Text = "Update";
            this.btnEventUpdate.UseVisualStyleBackColor = true;
            this.btnEventUpdate.Click += new System.EventHandler(this.btnEventUpdate_Click);
            // 
            // lblEventStartDate
            // 
            this.lblEventStartDate.AutoSize = true;
            this.lblEventStartDate.Location = new System.Drawing.Point(12, 72);
            this.lblEventStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventStartDate.Name = "lblEventStartDate";
            this.lblEventStartDate.Size = new System.Drawing.Size(86, 13);
            this.lblEventStartDate.TabIndex = 9;
            this.lblEventStartDate.Text = "Event Start Date";
            // 
            // lblEventStartTime
            // 
            this.lblEventStartTime.AutoSize = true;
            this.lblEventStartTime.Location = new System.Drawing.Point(12, 96);
            this.lblEventStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventStartTime.Name = "lblEventStartTime";
            this.lblEventStartTime.Size = new System.Drawing.Size(86, 13);
            this.lblEventStartTime.TabIndex = 6;
            this.lblEventStartTime.Text = "Event Start Time";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(379, 47);
            this.lblEventType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(62, 13);
            this.lblEventType.TabIndex = 4;
            this.lblEventType.Text = "Event Type";
            // 
            // lblSelectEvent
            // 
            this.lblSelectEvent.AutoSize = true;
            this.lblSelectEvent.Location = new System.Drawing.Point(12, 21);
            this.lblSelectEvent.Name = "lblSelectEvent";
            this.lblSelectEvent.Size = new System.Drawing.Size(68, 13);
            this.lblSelectEvent.TabIndex = 2;
            this.lblSelectEvent.Text = "Select Event";
            // 
            // txtBxEventID
            // 
            this.txtBxEventID.Location = new System.Drawing.Point(469, 19);
            this.txtBxEventID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxEventID.Name = "txtBxEventID";
            this.txtBxEventID.ReadOnly = true;
            this.txtBxEventID.Size = new System.Drawing.Size(198, 20);
            this.txtBxEventID.TabIndex = 1;
            // 
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(379, 21);
            this.lblEventID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(49, 13);
            this.lblEventID.TabIndex = 0;
            this.lblEventID.Text = "Event ID";
            // 
            // tabPgBooking
            // 
            this.tabPgBooking.Controls.Add(this.grpBxBooking);
            this.tabPgBooking.Location = new System.Drawing.Point(4, 22);
            this.tabPgBooking.Name = "tabPgBooking";
            this.tabPgBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgBooking.Size = new System.Drawing.Size(685, 413);
            this.tabPgBooking.TabIndex = 4;
            this.tabPgBooking.Text = "Booking";
            this.tabPgBooking.UseVisualStyleBackColor = true;
            // 
            // grpBxBooking
            // 
            this.grpBxBooking.Controls.Add(this.btnBookDelet);
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
            this.grpBxBooking.Location = new System.Drawing.Point(6, 6);
            this.grpBxBooking.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxBooking.Name = "grpBxBooking";
            this.grpBxBooking.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxBooking.Size = new System.Drawing.Size(670, 399);
            this.grpBxBooking.TabIndex = 0;
            this.grpBxBooking.TabStop = false;
            this.grpBxBooking.Text = "Bookings";
            // 
            // btnBookDelet
            // 
            this.btnBookDelet.Location = new System.Drawing.Point(170, 364);
            this.btnBookDelet.Name = "btnBookDelet";
            this.btnBookDelet.Size = new System.Drawing.Size(75, 30);
            this.btnBookDelet.TabIndex = 51;
            this.btnBookDelet.Text = "Delete";
            this.btnBookDelet.UseVisualStyleBackColor = true;
            this.btnBookDelet.Click += new System.EventHandler(this.btnBookDelet_Click);
            // 
            // lstBxBookAttendees
            // 
            this.lstBxBookAttendees.FormattingEnabled = true;
            this.lstBxBookAttendees.Location = new System.Drawing.Point(117, 92);
            this.lstBxBookAttendees.Name = "lstBxBookAttendees";
            this.lstBxBookAttendees.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBxBookAttendees.Size = new System.Drawing.Size(211, 160);
            this.lstBxBookAttendees.TabIndex = 50;
            // 
            // txtBxBookingName
            // 
            this.txtBxBookingName.Location = new System.Drawing.Point(445, 43);
            this.txtBxBookingName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxBookingName.Multiline = true;
            this.txtBxBookingName.Name = "txtBxBookingName";
            this.txtBxBookingName.Size = new System.Drawing.Size(212, 20);
            this.txtBxBookingName.TabIndex = 48;
            // 
            // lblBookingName
            // 
            this.lblBookingName.AutoSize = true;
            this.lblBookingName.Location = new System.Drawing.Point(333, 46);
            this.lblBookingName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingName.Name = "lblBookingName";
            this.lblBookingName.Size = new System.Drawing.Size(77, 13);
            this.lblBookingName.TabIndex = 47;
            this.lblBookingName.Text = "Booking Name";
            // 
            // btnBookAddAttend
            // 
            this.btnBookAddAttend.Location = new System.Drawing.Point(445, 93);
            this.btnBookAddAttend.Name = "btnBookAddAttend";
            this.btnBookAddAttend.Size = new System.Drawing.Size(103, 23);
            this.btnBookAddAttend.TabIndex = 46;
            this.btnBookAddAttend.Text = "Add Attendee";
            this.btnBookAddAttend.UseVisualStyleBackColor = true;
            this.btnBookAddAttend.Click += new System.EventHandler(this.btnAddAttendee_Click);
            // 
            // cmbBxBookSlctClient
            // 
            this.cmbBxBookSlctClient.FormattingEnabled = true;
            this.cmbBxBookSlctClient.Location = new System.Drawing.Point(445, 67);
            this.cmbBxBookSlctClient.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBxBookSlctClient.Name = "cmbBxBookSlctClient";
            this.cmbBxBookSlctClient.Size = new System.Drawing.Size(212, 21);
            this.cmbBxBookSlctClient.TabIndex = 45;
            // 
            // lblBookAttendee
            // 
            this.lblBookAttendee.AutoSize = true;
            this.lblBookAttendee.Location = new System.Drawing.Point(333, 70);
            this.lblBookAttendee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookAttendee.Name = "lblBookAttendee";
            this.lblBookAttendee.Size = new System.Drawing.Size(50, 13);
            this.lblBookAttendee.TabIndex = 44;
            this.lblBookAttendee.Text = "Attendee";
            // 
            // btnBookApply
            // 
            this.btnBookApply.Location = new System.Drawing.Point(501, 364);
            this.btnBookApply.Name = "btnBookApply";
            this.btnBookApply.Size = new System.Drawing.Size(75, 30);
            this.btnBookApply.TabIndex = 43;
            this.btnBookApply.Text = "Apply";
            this.btnBookApply.UseVisualStyleBackColor = true;
            this.btnBookApply.Click += new System.EventHandler(this.btnBookApply_Click);
            // 
            // btnBookCancel
            // 
            this.btnBookCancel.Location = new System.Drawing.Point(582, 364);
            this.btnBookCancel.Name = "btnBookCancel";
            this.btnBookCancel.Size = new System.Drawing.Size(75, 30);
            this.btnBookCancel.TabIndex = 42;
            this.btnBookCancel.Text = "Cancle";
            this.btnBookCancel.UseVisualStyleBackColor = true;
            this.btnBookCancel.Click += new System.EventHandler(this.btnBookCancel_Click);
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(89, 364);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnBookUpdate.TabIndex = 41;
            this.btnBookUpdate.Text = "Update";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click);
            // 
            // btnBookCreate
            // 
            this.btnBookCreate.Location = new System.Drawing.Point(8, 364);
            this.btnBookCreate.Name = "btnBookCreate";
            this.btnBookCreate.Size = new System.Drawing.Size(75, 30);
            this.btnBookCreate.TabIndex = 40;
            this.btnBookCreate.Text = "Create";
            this.btnBookCreate.UseVisualStyleBackColor = true;
            this.btnBookCreate.Click += new System.EventHandler(this.btnBookCreate_Click);
            // 
            // radioBtnNotApproved
            // 
            this.radioBtnNotApproved.AutoSize = true;
            this.radioBtnNotApproved.Location = new System.Drawing.Point(445, 147);
            this.radioBtnNotApproved.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnNotApproved.Name = "radioBtnNotApproved";
            this.radioBtnNotApproved.Size = new System.Drawing.Size(141, 17);
            this.radioBtnNotApproved.TabIndex = 39;
            this.radioBtnNotApproved.Text = "Pending / Not Approved";
            this.radioBtnNotApproved.UseVisualStyleBackColor = true;
            // 
            // radioBtnApproved
            // 
            this.radioBtnApproved.AutoSize = true;
            this.radioBtnApproved.Location = new System.Drawing.Point(445, 121);
            this.radioBtnApproved.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnApproved.Name = "radioBtnApproved";
            this.radioBtnApproved.Size = new System.Drawing.Size(71, 17);
            this.radioBtnApproved.TabIndex = 38;
            this.radioBtnApproved.Text = "Approved";
            this.radioBtnApproved.UseVisualStyleBackColor = true;
            // 
            // lblBookApprove
            // 
            this.lblBookApprove.AutoSize = true;
            this.lblBookApprove.Location = new System.Drawing.Point(333, 121);
            this.lblBookApprove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookApprove.Name = "lblBookApprove";
            this.lblBookApprove.Size = new System.Drawing.Size(53, 13);
            this.lblBookApprove.TabIndex = 37;
            this.lblBookApprove.Text = "Approved";
            // 
            // lblBookAttendees
            // 
            this.lblBookAttendees.AutoSize = true;
            this.lblBookAttendees.Location = new System.Drawing.Point(5, 93);
            this.lblBookAttendees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookAttendees.Name = "lblBookAttendees";
            this.lblBookAttendees.Size = new System.Drawing.Size(55, 13);
            this.lblBookAttendees.TabIndex = 33;
            this.lblBookAttendees.Text = "Attendees";
            // 
            // cmbBxBookSlctTrain
            // 
            this.cmbBxBookSlctTrain.FormattingEnabled = true;
            this.cmbBxBookSlctTrain.Location = new System.Drawing.Point(117, 67);
            this.cmbBxBookSlctTrain.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBxBookSlctTrain.Name = "cmbBxBookSlctTrain";
            this.cmbBxBookSlctTrain.Size = new System.Drawing.Size(212, 21);
            this.cmbBxBookSlctTrain.TabIndex = 31;
            // 
            // lblBookSlctTrainer
            // 
            this.lblBookSlctTrainer.AutoSize = true;
            this.lblBookSlctTrainer.Location = new System.Drawing.Point(5, 70);
            this.lblBookSlctTrainer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookSlctTrainer.Name = "lblBookSlctTrainer";
            this.lblBookSlctTrainer.Size = new System.Drawing.Size(40, 13);
            this.lblBookSlctTrainer.TabIndex = 30;
            this.lblBookSlctTrainer.Text = "Trainer";
            // 
            // cmbBxBookSlctEvent
            // 
            this.cmbBxBookSlctEvent.FormattingEnabled = true;
            this.cmbBxBookSlctEvent.Location = new System.Drawing.Point(117, 42);
            this.cmbBxBookSlctEvent.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBxBookSlctEvent.Name = "cmbBxBookSlctEvent";
            this.cmbBxBookSlctEvent.Size = new System.Drawing.Size(212, 21);
            this.cmbBxBookSlctEvent.TabIndex = 29;
            // 
            // lblBookSlctEvent
            // 
            this.lblBookSlctEvent.AutoSize = true;
            this.lblBookSlctEvent.Location = new System.Drawing.Point(5, 45);
            this.lblBookSlctEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookSlctEvent.Name = "lblBookSlctEvent";
            this.lblBookSlctEvent.Size = new System.Drawing.Size(108, 13);
            this.lblBookSlctEvent.TabIndex = 28;
            this.lblBookSlctEvent.Text = "Select Event to Book";
            // 
            // txtBxBookComments
            // 
            this.txtBxBookComments.Location = new System.Drawing.Point(117, 257);
            this.txtBxBookComments.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxBookComments.Multiline = true;
            this.txtBxBookComments.Name = "txtBxBookComments";
            this.txtBxBookComments.Size = new System.Drawing.Size(540, 100);
            this.txtBxBookComments.TabIndex = 27;
            // 
            // lblBookComments
            // 
            this.lblBookComments.AutoSize = true;
            this.lblBookComments.Location = new System.Drawing.Point(5, 259);
            this.lblBookComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookComments.Name = "lblBookComments";
            this.lblBookComments.Size = new System.Drawing.Size(56, 13);
            this.lblBookComments.TabIndex = 26;
            this.lblBookComments.Text = "Comments";
            // 
            // cmbBxBookSlctBook
            // 
            this.cmbBxBookSlctBook.FormattingEnabled = true;
            this.cmbBxBookSlctBook.Location = new System.Drawing.Point(117, 17);
            this.cmbBxBookSlctBook.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBxBookSlctBook.Name = "cmbBxBookSlctBook";
            this.cmbBxBookSlctBook.Size = new System.Drawing.Size(212, 21);
            this.cmbBxBookSlctBook.TabIndex = 25;
            this.cmbBxBookSlctBook.SelectedIndexChanged += new System.EventHandler(this.cmbBxSlctBooking_SelectedIndexChanged);
            // 
            // lblBookSlctBooking
            // 
            this.lblBookSlctBooking.AutoSize = true;
            this.lblBookSlctBooking.Location = new System.Drawing.Point(5, 20);
            this.lblBookSlctBooking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookSlctBooking.Name = "lblBookSlctBooking";
            this.lblBookSlctBooking.Size = new System.Drawing.Size(79, 13);
            this.lblBookSlctBooking.TabIndex = 24;
            this.lblBookSlctBooking.Text = "Select Booking";
            // 
            // txtBxBookingID
            // 
            this.txtBxBookingID.Location = new System.Drawing.Point(445, 18);
            this.txtBxBookingID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxBookingID.Name = "txtBxBookingID";
            this.txtBxBookingID.ReadOnly = true;
            this.txtBxBookingID.Size = new System.Drawing.Size(212, 20);
            this.txtBxBookingID.TabIndex = 21;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(333, 20);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(60, 13);
            this.lblBookingID.TabIndex = 20;
            this.lblBookingID.Text = "Booking ID";
            // 
            // tabPgReporting
            // 
            this.tabPgReporting.Controls.Add(this.grpBxReporting);
            this.tabPgReporting.Location = new System.Drawing.Point(4, 22);
            this.tabPgReporting.Name = "tabPgReporting";
            this.tabPgReporting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgReporting.Size = new System.Drawing.Size(685, 413);
            this.tabPgReporting.TabIndex = 5;
            this.tabPgReporting.Text = "Reporting";
            this.tabPgReporting.UseVisualStyleBackColor = true;
            // 
            // grpBxReporting
            // 
            this.grpBxReporting.Controls.Add(this.btnRprtGenerate);
            this.grpBxReporting.Controls.Add(this.grpBxDataView);
            this.grpBxReporting.Controls.Add(this.grpBxRprtType);
            this.grpBxReporting.Controls.Add(this.grpBxRprtDate);
            this.grpBxReporting.Controls.Add(this.grpBxEvents);
            this.grpBxReporting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxReporting.Location = new System.Drawing.Point(3, 3);
            this.grpBxReporting.Margin = new System.Windows.Forms.Padding(2);
            this.grpBxReporting.Name = "grpBxReporting";
            this.grpBxReporting.Padding = new System.Windows.Forms.Padding(2);
            this.grpBxReporting.Size = new System.Drawing.Size(679, 407);
            this.grpBxReporting.TabIndex = 0;
            this.grpBxReporting.TabStop = false;
            this.grpBxReporting.Text = "Reporting";
            // 
            // btnRprtGenerate
            // 
            this.btnRprtGenerate.Location = new System.Drawing.Point(6, 147);
            this.btnRprtGenerate.Name = "btnRprtGenerate";
            this.btnRprtGenerate.Size = new System.Drawing.Size(84, 30);
            this.btnRprtGenerate.TabIndex = 4;
            this.btnRprtGenerate.Text = "Generate";
            this.btnRprtGenerate.UseVisualStyleBackColor = true;
            // 
            // grpBxDataView
            // 
            this.grpBxDataView.Controls.Add(this.dtgrvRprt);
            this.grpBxDataView.Location = new System.Drawing.Point(5, 183);
            this.grpBxDataView.Name = "grpBxDataView";
            this.grpBxDataView.Size = new System.Drawing.Size(669, 219);
            this.grpBxDataView.TabIndex = 3;
            this.grpBxDataView.TabStop = false;
            this.grpBxDataView.Text = "Data View";
            // 
            // dtgrvRprt
            // 
            this.dtgrvRprt.AllowUserToDeleteRows = false;
            this.dtgrvRprt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvRprt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrvRprt.Location = new System.Drawing.Point(3, 16);
            this.dtgrvRprt.Name = "dtgrvRprt";
            this.dtgrvRprt.ReadOnly = true;
            this.dtgrvRprt.Size = new System.Drawing.Size(663, 200);
            this.dtgrvRprt.TabIndex = 0;
            // 
            // grpBxRprtType
            // 
            this.grpBxRprtType.Controls.Add(this.radioBtnRprtTypeDetaild);
            this.grpBxRprtType.Controls.Add(this.radioBtnRprtTypeSummery);
            this.grpBxRprtType.Location = new System.Drawing.Point(318, 19);
            this.grpBxRprtType.Name = "grpBxRprtType";
            this.grpBxRprtType.Size = new System.Drawing.Size(94, 122);
            this.grpBxRprtType.TabIndex = 2;
            this.grpBxRprtType.TabStop = false;
            this.grpBxRprtType.Text = "Type Of Report";
            // 
            // radioBtnRprtTypeDetaild
            // 
            this.radioBtnRprtTypeDetaild.AutoSize = true;
            this.radioBtnRprtTypeDetaild.Location = new System.Drawing.Point(6, 43);
            this.radioBtnRprtTypeDetaild.Name = "radioBtnRprtTypeDetaild";
            this.radioBtnRprtTypeDetaild.Size = new System.Drawing.Size(64, 17);
            this.radioBtnRprtTypeDetaild.TabIndex = 1;
            this.radioBtnRprtTypeDetaild.TabStop = true;
            this.radioBtnRprtTypeDetaild.Text = "Detailed";
            this.radioBtnRprtTypeDetaild.UseVisualStyleBackColor = true;
            // 
            // radioBtnRprtTypeSummery
            // 
            this.radioBtnRprtTypeSummery.AutoSize = true;
            this.radioBtnRprtTypeSummery.Location = new System.Drawing.Point(6, 20);
            this.radioBtnRprtTypeSummery.Name = "radioBtnRprtTypeSummery";
            this.radioBtnRprtTypeSummery.Size = new System.Drawing.Size(68, 17);
            this.radioBtnRprtTypeSummery.TabIndex = 0;
            this.radioBtnRprtTypeSummery.TabStop = true;
            this.radioBtnRprtTypeSummery.Text = "Summery";
            this.radioBtnRprtTypeSummery.UseVisualStyleBackColor = true;
            // 
            // grpBxRprtDate
            // 
            this.grpBxRprtDate.Controls.Add(this.lblRprtEndDate);
            this.grpBxRprtDate.Controls.Add(this.dateTimePicker2);
            this.grpBxRprtDate.Controls.Add(this.lblRprtStartDate);
            this.grpBxRprtDate.Controls.Add(this.dateTimePicker1);
            this.grpBxRprtDate.Location = new System.Drawing.Point(97, 19);
            this.grpBxRprtDate.Name = "grpBxRprtDate";
            this.grpBxRprtDate.Size = new System.Drawing.Size(215, 122);
            this.grpBxRprtDate.TabIndex = 1;
            this.grpBxRprtDate.TabStop = false;
            this.grpBxRprtDate.Text = "Date";
            // 
            // lblRprtEndDate
            // 
            this.lblRprtEndDate.AutoSize = true;
            this.lblRprtEndDate.Location = new System.Drawing.Point(7, 77);
            this.lblRprtEndDate.Name = "lblRprtEndDate";
            this.lblRprtEndDate.Size = new System.Drawing.Size(103, 13);
            this.lblRprtEndDate.TabIndex = 3;
            this.lblRprtEndDate.Text = "Select the End Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2022, 9, 28, 0, 0, 0, 0);
            // 
            // lblRprtStartDate
            // 
            this.lblRprtStartDate.AutoSize = true;
            this.lblRprtStartDate.Location = new System.Drawing.Point(7, 20);
            this.lblRprtStartDate.Name = "lblRprtStartDate";
            this.lblRprtStartDate.Size = new System.Drawing.Size(120, 13);
            this.lblRprtStartDate.TabIndex = 1;
            this.lblRprtStartDate.Text = "Select the Starting Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2022, 9, 28, 0, 0, 0, 0);
            // 
            // grpBxEvents
            // 
            this.grpBxEvents.Controls.Add(this.radioBtnRprtEventAll);
            this.grpBxEvents.Controls.Add(this.radioBtnRprtEventExams);
            this.grpBxEvents.Controls.Add(this.radioBtnRprtEventTrain);
            this.grpBxEvents.Location = new System.Drawing.Point(6, 19);
            this.grpBxEvents.Name = "grpBxEvents";
            this.grpBxEvents.Size = new System.Drawing.Size(84, 122);
            this.grpBxEvents.TabIndex = 0;
            this.grpBxEvents.TabStop = false;
            this.grpBxEvents.Text = "Events";
            // 
            // radioBtnRprtEventAll
            // 
            this.radioBtnRprtEventAll.AutoSize = true;
            this.radioBtnRprtEventAll.Location = new System.Drawing.Point(6, 66);
            this.radioBtnRprtEventAll.Name = "radioBtnRprtEventAll";
            this.radioBtnRprtEventAll.Size = new System.Drawing.Size(72, 17);
            this.radioBtnRprtEventAll.TabIndex = 2;
            this.radioBtnRprtEventAll.TabStop = true;
            this.radioBtnRprtEventAll.Text = "All Events";
            this.radioBtnRprtEventAll.UseVisualStyleBackColor = true;
            // 
            // radioBtnRprtEventExams
            // 
            this.radioBtnRprtEventExams.AutoSize = true;
            this.radioBtnRprtEventExams.Location = new System.Drawing.Point(6, 43);
            this.radioBtnRprtEventExams.Name = "radioBtnRprtEventExams";
            this.radioBtnRprtEventExams.Size = new System.Drawing.Size(56, 17);
            this.radioBtnRprtEventExams.TabIndex = 1;
            this.radioBtnRprtEventExams.TabStop = true;
            this.radioBtnRprtEventExams.Text = "Exams";
            this.radioBtnRprtEventExams.UseVisualStyleBackColor = true;
            // 
            // radioBtnRprtEventTrain
            // 
            this.radioBtnRprtEventTrain.AutoSize = true;
            this.radioBtnRprtEventTrain.Location = new System.Drawing.Point(6, 20);
            this.radioBtnRprtEventTrain.Name = "radioBtnRprtEventTrain";
            this.radioBtnRprtEventTrain.Size = new System.Drawing.Size(63, 17);
            this.radioBtnRprtEventTrain.TabIndex = 0;
            this.radioBtnRprtEventTrain.TabStop = true;
            this.radioBtnRprtEventTrain.Text = "Training";
            this.radioBtnRprtEventTrain.UseVisualStyleBackColor = true;
            // 
            // grtBxNewSignUp
            // 
            this.grtBxNewSignUp.AutoSize = true;
            this.grtBxNewSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grtBxNewSignUp.Controls.Add(this.btnSignUp);
            this.grtBxNewSignUp.Controls.Add(this.btnSignCancel);
            this.grtBxNewSignUp.Location = new System.Drawing.Point(364, 204);
            this.grtBxNewSignUp.Name = "grtBxNewSignUp";
            this.grtBxNewSignUp.Size = new System.Drawing.Size(168, 61);
            this.grtBxNewSignUp.TabIndex = 1;
            this.grtBxNewSignUp.TabStop = false;
            this.grtBxNewSignUp.Text = "New Sign up";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(6, 19);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignCancel
            // 
            this.btnSignCancel.Location = new System.Drawing.Point(87, 19);
            this.btnSignCancel.Name = "btnSignCancel";
            this.btnSignCancel.Size = new System.Drawing.Size(75, 23);
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
            this.grpBxLogin.Location = new System.Drawing.Point(187, 204);
            this.grpBxLogin.Margin = new System.Windows.Forms.Padding(6);
            this.grpBxLogin.Name = "grpBxLogin";
            this.grpBxLogin.Size = new System.Drawing.Size(168, 61);
            this.grpBxLogin.TabIndex = 0;
            this.grpBxLogin.TabStop = false;
            this.grpBxLogin.Text = "User Login";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(87, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 19);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(709, 470);
            this.Controls.Add(this.tabCtrlMain);
            this.Controls.Add(this.grtBxNewSignUp);
            this.Controls.Add(this.grpBxLogin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            this.grpBxDataView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvRprt)).EndInit();
            this.grpBxRprtType.ResumeLayout(false);
            this.grpBxRprtType.PerformLayout();
            this.grpBxRprtDate.ResumeLayout(false);
            this.grpBxRprtDate.PerformLayout();
            this.grpBxEvents.ResumeLayout(false);
            this.grpBxEvents.PerformLayout();
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
        private System.Windows.Forms.TextBox txtBxEventDiscrip;
        private System.Windows.Forms.Button btnBookDelet;
        private System.Windows.Forms.Label lblEventDiscr;
        private System.Windows.Forms.DateTimePicker dtPckrEventStartDate;
        private System.Windows.Forms.Button btnRprtGenerate;
        private System.Windows.Forms.GroupBox grpBxDataView;
        private System.Windows.Forms.DataGridView dtgrvRprt;
        private System.Windows.Forms.GroupBox grpBxRprtType;
        private System.Windows.Forms.RadioButton radioBtnRprtTypeDetaild;
        private System.Windows.Forms.RadioButton radioBtnRprtTypeSummery;
        private System.Windows.Forms.GroupBox grpBxRprtDate;
        private System.Windows.Forms.Label lblRprtEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblRprtStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grpBxEvents;
        private System.Windows.Forms.RadioButton radioBtnRprtEventAll;
        private System.Windows.Forms.RadioButton radioBtnRprtEventExams;
        private System.Windows.Forms.RadioButton radioBtnRprtEventTrain;
    }
}

