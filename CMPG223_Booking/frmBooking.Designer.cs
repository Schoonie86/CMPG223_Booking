namespace CMPG223_Booking
{
    partial class frmBooking
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
            this.lblBookingID = new System.Windows.Forms.Label();
            this.txtBxBookingID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBookingName = new System.Windows.Forms.Label();
            this.lblSlctBooking = new System.Windows.Forms.Label();
            this.cmbBxSlctBooking = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblBookComments = new System.Windows.Forms.Label();
            this.cmbBxBookEventSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBxBookTrainerSelect = new System.Windows.Forms.ComboBox();
            this.lblBookTrainer = new System.Windows.Forms.Label();
            this.lstBxBookAttendees = new System.Windows.Forms.ListBox();
            this.lblBookAttendees = new System.Windows.Forms.Label();
            this.btnAddAttendees = new System.Windows.Forms.Button();
            this.lstBxBookClients = new System.Windows.Forms.ListBox();
            this.btnOpenAttendeeList = new System.Windows.Forms.Button();
            this.lblBookApprove = new System.Windows.Forms.Label();
            this.radioBtnApproved = new System.Windows.Forms.RadioButton();
            this.radioBtnNotApproved = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(10, 60);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(73, 16);
            this.lblBookingID.TabIndex = 0;
            this.lblBookingID.Text = "Booking ID";
            // 
            // txtBxBookingID
            // 
            this.txtBxBookingID.Location = new System.Drawing.Point(159, 72);
            this.txtBxBookingID.Name = "txtBxBookingID";
            this.txtBxBookingID.Size = new System.Drawing.Size(266, 22);
            this.txtBxBookingID.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lblBookingName
            // 
            this.lblBookingName.AutoSize = true;
            this.lblBookingName.Location = new System.Drawing.Point(10, 83);
            this.lblBookingName.Name = "lblBookingName";
            this.lblBookingName.Size = new System.Drawing.Size(97, 16);
            this.lblBookingName.TabIndex = 2;
            this.lblBookingName.Text = "Booking Name";
            // 
            // lblSlctBooking
            // 
            this.lblSlctBooking.AutoSize = true;
            this.lblSlctBooking.Location = new System.Drawing.Point(10, 36);
            this.lblSlctBooking.Name = "lblSlctBooking";
            this.lblSlctBooking.Size = new System.Drawing.Size(98, 16);
            this.lblSlctBooking.TabIndex = 4;
            this.lblSlctBooking.Text = "Select Booking";
            // 
            // cmbBxSlctBooking
            // 
            this.cmbBxSlctBooking.FormattingEnabled = true;
            this.cmbBxSlctBooking.Location = new System.Drawing.Point(159, 42);
            this.cmbBxSlctBooking.Name = "cmbBxSlctBooking";
            this.cmbBxSlctBooking.Size = new System.Drawing.Size(266, 24);
            this.cmbBxSlctBooking.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 386);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(516, 122);
            this.textBox2.TabIndex = 7;
            // 
            // lblBookComments
            // 
            this.lblBookComments.AutoSize = true;
            this.lblBookComments.Location = new System.Drawing.Point(12, 389);
            this.lblBookComments.Name = "lblBookComments";
            this.lblBookComments.Size = new System.Drawing.Size(71, 16);
            this.lblBookComments.TabIndex = 6;
            this.lblBookComments.Text = "Comments";
            // 
            // cmbBxBookEventSelect
            // 
            this.cmbBxBookEventSelect.FormattingEnabled = true;
            this.cmbBxBookEventSelect.Location = new System.Drawing.Point(159, 12);
            this.cmbBxBookEventSelect.Name = "cmbBxBookEventSelect";
            this.cmbBxBookEventSelect.Size = new System.Drawing.Size(266, 24);
            this.cmbBxBookEventSelect.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Event to Book";
            // 
            // cmbBxBookTrainerSelect
            // 
            this.cmbBxBookTrainerSelect.FormattingEnabled = true;
            this.cmbBxBookTrainerSelect.Location = new System.Drawing.Point(159, 128);
            this.cmbBxBookTrainerSelect.Name = "cmbBxBookTrainerSelect";
            this.cmbBxBookTrainerSelect.Size = new System.Drawing.Size(266, 24);
            this.cmbBxBookTrainerSelect.TabIndex = 11;
            // 
            // lblBookTrainer
            // 
            this.lblBookTrainer.AutoSize = true;
            this.lblBookTrainer.Location = new System.Drawing.Point(10, 105);
            this.lblBookTrainer.Name = "lblBookTrainer";
            this.lblBookTrainer.Size = new System.Drawing.Size(50, 16);
            this.lblBookTrainer.TabIndex = 10;
            this.lblBookTrainer.Text = "Trainer";
            // 
            // lstBxBookAttendees
            // 
            this.lstBxBookAttendees.FormattingEnabled = true;
            this.lstBxBookAttendees.ItemHeight = 16;
            this.lstBxBookAttendees.Location = new System.Drawing.Point(159, 158);
            this.lstBxBookAttendees.Name = "lstBxBookAttendees";
            this.lstBxBookAttendees.ScrollAlwaysVisible = true;
            this.lstBxBookAttendees.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstBxBookAttendees.Size = new System.Drawing.Size(266, 196);
            this.lstBxBookAttendees.Sorted = true;
            this.lstBxBookAttendees.TabIndex = 12;
            // 
            // lblBookAttendees
            // 
            this.lblBookAttendees.AutoSize = true;
            this.lblBookAttendees.Location = new System.Drawing.Point(11, 127);
            this.lblBookAttendees.Name = "lblBookAttendees";
            this.lblBookAttendees.Size = new System.Drawing.Size(68, 16);
            this.lblBookAttendees.TabIndex = 13;
            this.lblBookAttendees.Text = "Attendees";
            // 
            // btnAddAttendees
            // 
            this.btnAddAttendees.Location = new System.Drawing.Point(431, 326);
            this.btnAddAttendees.Name = "btnAddAttendees";
            this.btnAddAttendees.Size = new System.Drawing.Size(127, 28);
            this.btnAddAttendees.TabIndex = 14;
            this.btnAddAttendees.Text = "Add Attendees";
            this.btnAddAttendees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAttendees.UseVisualStyleBackColor = true;
            // 
            // lstBxBookClients
            // 
            this.lstBxBookClients.FormattingEnabled = true;
            this.lstBxBookClients.ItemHeight = 16;
            this.lstBxBookClients.Location = new System.Drawing.Point(431, 12);
            this.lstBxBookClients.Name = "lstBxBookClients";
            this.lstBxBookClients.ScrollAlwaysVisible = true;
            this.lstBxBookClients.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBxBookClients.Size = new System.Drawing.Size(244, 308);
            this.lstBxBookClients.Sorted = true;
            this.lstBxBookClients.TabIndex = 15;
            // 
            // btnOpenAttendeeList
            // 
            this.btnOpenAttendeeList.Location = new System.Drawing.Point(15, 177);
            this.btnOpenAttendeeList.Name = "btnOpenAttendeeList";
            this.btnOpenAttendeeList.Size = new System.Drawing.Size(127, 45);
            this.btnOpenAttendeeList.TabIndex = 16;
            this.btnOpenAttendeeList.Text = "Add More Attendees";
            this.btnOpenAttendeeList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAttendeeList.UseVisualStyleBackColor = true;
            // 
            // lblBookApprove
            // 
            this.lblBookApprove.AutoSize = true;
            this.lblBookApprove.Location = new System.Drawing.Point(16, 362);
            this.lblBookApprove.Name = "lblBookApprove";
            this.lblBookApprove.Size = new System.Drawing.Size(67, 16);
            this.lblBookApprove.TabIndex = 17;
            this.lblBookApprove.Text = "Approved";
            // 
            // radioBtnApproved
            // 
            this.radioBtnApproved.AutoSize = true;
            this.radioBtnApproved.Location = new System.Drawing.Point(159, 360);
            this.radioBtnApproved.Name = "radioBtnApproved";
            this.radioBtnApproved.Size = new System.Drawing.Size(88, 20);
            this.radioBtnApproved.TabIndex = 18;
            this.radioBtnApproved.Text = "Approved";
            this.radioBtnApproved.UseVisualStyleBackColor = true;
            // 
            // radioBtnNotApproved
            // 
            this.radioBtnNotApproved.AutoSize = true;
            this.radioBtnNotApproved.Checked = true;
            this.radioBtnNotApproved.Location = new System.Drawing.Point(253, 360);
            this.radioBtnNotApproved.Name = "radioBtnNotApproved";
            this.radioBtnNotApproved.Size = new System.Drawing.Size(172, 20);
            this.radioBtnNotApproved.TabIndex = 19;
            this.radioBtnNotApproved.TabStop = true;
            this.radioBtnNotApproved.Text = "Pending / Not Approved";
            this.radioBtnNotApproved.UseVisualStyleBackColor = true;
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(693, 528);
            this.Controls.Add(this.radioBtnNotApproved);
            this.Controls.Add(this.radioBtnApproved);
            this.Controls.Add(this.lblBookApprove);
            this.Controls.Add(this.btnOpenAttendeeList);
            this.Controls.Add(this.lstBxBookClients);
            this.Controls.Add(this.btnAddAttendees);
            this.Controls.Add(this.lblBookAttendees);
            this.Controls.Add(this.lstBxBookAttendees);
            this.Controls.Add(this.cmbBxBookTrainerSelect);
            this.Controls.Add(this.lblBookTrainer);
            this.Controls.Add(this.cmbBxBookEventSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblBookComments);
            this.Controls.Add(this.cmbBxSlctBooking);
            this.Controls.Add(this.lblSlctBooking);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBookingName);
            this.Controls.Add(this.txtBxBookingID);
            this.Controls.Add(this.lblBookingID);
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.TextBox txtBxBookingID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBookingName;
        private System.Windows.Forms.Label lblSlctBooking;
        private System.Windows.Forms.ComboBox cmbBxSlctBooking;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblBookComments;
        private System.Windows.Forms.ComboBox cmbBxBookEventSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBxBookTrainerSelect;
        private System.Windows.Forms.Label lblBookTrainer;
        private System.Windows.Forms.ListBox lstBxBookAttendees;
        private System.Windows.Forms.Label lblBookAttendees;
        private System.Windows.Forms.Button btnAddAttendees;
        private System.Windows.Forms.ListBox lstBxBookClients;
        private System.Windows.Forms.Button btnOpenAttendeeList;
        private System.Windows.Forms.Label lblBookApprove;
        private System.Windows.Forms.RadioButton radioBtnApproved;
        private System.Windows.Forms.RadioButton radioBtnNotApproved;
    }
}