using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleGenerator
{
    internal class Availability
    {
        private int AvailabilityID, EmployeeID, DayID, StartTime, EndTime;

        public Availability()
        {
            AvailabilityID = 0;
            EmployeeID = 0;
            DayID = 0;
            StartTime = 0;
            EndTime = 0;
        }

        public Availability(int avail, int employee, int day, int start, int end)
        {
            AvailabilityID = avail;
            EmployeeID = employee;
            DayID = day;
            StartTime = start;
            EndTime = end;
        }

        public int getAvailabilityID()
        {
            return AvailabilityID;
        }

        public int getEmployeeID()
        {
            return EmployeeID;
        }

        public int getDayID()
        {
            return DayID;
        }

        public int getStartTime()
        {
            return StartTime;
        }

        public int getEndTime()
        {
            return EndTime;
        }

        public void setStartTime(int time)
        {
            StartTime = time;
        }

        public void setEndTime(int time)
        {
            EndTime = time;
        }

    }
}