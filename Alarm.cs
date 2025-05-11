using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirHeater
{
    public class Alarm
    {

        public enum AlarmStatus
        {
            Active,
            off,
            Acknowledged
        }

        public string AlarmName { get; set; }
        public AlarmStatus Status { get; set; }
        public DateTime Timestamp { get; set; }

        public Alarm(string alarmname, AlarmStatus status)
        {

            AlarmName = alarmname;
            Status = status;
            Timestamp = DateTime.Now;
        }

        public void UpdateStatus(AlarmStatus newStatus)
        {
            Status = newStatus;
            Timestamp = DateTime.Now;

        }
    }
}
