using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string EventName;
        public int EventType;
        public DateTime EventStartDate;
        public DateTime EventEndDate;
        public DateTime EventStartTime;
        public DateTime EventEndTime;

        
    }
}
