using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPG223_Booking.Classes
{           /*EventClass events = new EventClass();
            events.EventName = txtBxEventName.Text;
            if (radioBtnTraining.Checked)
            {
                events.EventType = 0;
            }
            else if (radioBtnExam.Checked)
            {
                events.EventType = 1;
            }
            events.EventStartDate = dtPckrEventStartDate.MaxDate;
            events.EventEndDate = dtPckrEventEndDate.MaxDate;
            events.EventStartTime = DateTime.Parse(cmbBxEventStartTime.Text);
            events.EventEndTime = DateTime.Parse(cmbBxEventEndTime.Text);*/
    public class EventClass
    {
        public int EventID;
        public string EventName;
        public bool EventType;
        public string EventDiscription;
        public DateTime EventStartDate;
        public DateTime EventEndDate;
        public DateTime EventStartTime;
        public DateTime EventEndTime;

        SqlCommand sqlComm;
        SqlDataAdapter sqlDatAdap;
        DataSet ds;
        SqlDataReader sqlDatRead;
        GlobalConnection sqlConn;
        DataTable dt;

        public EventClass()
        {
            EventID = 0;
            EventName = "";
            EventDiscription = "";
            EventStartDate = DateTime.Now;
            EventEndDate = DateTime.Now;
            EventStartTime = DateTime.Now;
            EventEndTime = DateTime.Now;
        }

        public void CreateEvent()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"INSERT INTO tbEvent (Name, Type, Discription, EventStartDate, EventEndDate, EventStartTime, EventEndtime) VALUES ('{EventName}','{EventType}','{EventDiscription}','{EventStartDate}','{EventEndDate}','{EventStartTime}','{EventEndTime}') ", sqlConn.sqlGlbConn);
                sqlDatAdap.InsertCommand = sqlComm;
                sqlDatAdap.InsertCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
                MessageBox.Show("You Successfully added a new event.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateEvent()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"UPDATE tbEvent SET Name = {EventName}, Type = {EventType}, Discription = {EventDiscription}, EventStartDate = {EventStartDate}, EventEndDate = {EventEndDate}, EventStartTime = {EventStartTime}, EventEndtime = {EventEndTime}) ", sqlConn.sqlGlbConn);
                sqlDatAdap.UpdateCommand = sqlComm;
                sqlDatAdap.UpdateCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
                MessageBox.Show("You Successfully Updated the Event.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteEvent()
        {
            try
            {
                sqlConn = new GlobalConnection();
                sqlConn.glbConn();
                sqlConn.sqlGlbConn.Open();
                sqlDatAdap = new SqlDataAdapter();
                sqlComm = new SqlCommand($"DELETE FROM tbEvent WHERE EventID = {EventID}", sqlConn.sqlGlbConn);
                sqlDatAdap.DeleteCommand = sqlComm;
                sqlDatAdap.DeleteCommand.ExecuteNonQuery();
                sqlConn.sqlGlbConn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
