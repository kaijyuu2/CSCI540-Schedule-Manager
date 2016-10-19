﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ScheduleGenerator
{
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection();
        String serverInfo = "Data Source=MARK-PC\\MWSQLSERVER;Initial Catalog=SchedulingDatabase;Integrated Security=True";
        private String currentUserId;

        //Must have a way to keep track of which user is using the form.
        public UserForm(String id)
        {
            currentUserId = id;
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AvailabilityButton_Click(object sender, EventArgs e)
        {
            //How will we create an availability ID?
            String availableId = "null? Should this be sequential?";
            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();

            //Sunday
            String fromTime = fromSundayTextBox.ToString();
            String toTime = toSundayTextBox.ToString();
            SqlCommand cmd = new SqlCommand("addAvailability", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", availableId));
            cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
            //Day id is 0 for Sunday.
            cmd.Parameters.Add(new SqlParameter("@pDayID", 0));
            cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
            cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

            //Monday
            fromTime = fromMondayTextBox.ToString();
            toTime = toMondayTextBox.ToString();
            cmd = new SqlCommand("addAvailability", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", availableId));
            cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
            //Day id is 1 for Monday.
            cmd.Parameters.Add(new SqlParameter("@pDayID", 1));
            cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
            cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

            //Tuesday
            fromTime = fromTuesdayTextBox.ToString();
            toTime = toTuesdayTextBox.ToString();
            cmd = new SqlCommand("addAvailability", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", availableId));
            cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
            //Day id is 2 for Tuesday.
            cmd.Parameters.Add(new SqlParameter("@pDayID", 2));
            cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
            cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

            //Wednesday
            fromTime = fromWednesdayTextBox.ToString();
            toTime = toWednesdayTextBox.ToString();
            cmd = new SqlCommand("addAvailability", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", availableId));
            cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
            //Day id is 3 for Wednesday.
            cmd.Parameters.Add(new SqlParameter("@pDayID", 3));
            cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
            cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

            //Thursday
            fromTime = fromThursdayTextBox.ToString();
            toTime = toThursdayTextBox.ToString();
            cmd = new SqlCommand("addAvailability", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", availableId));
            cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
            //Day id is 4 for Thursday.
            cmd.Parameters.Add(new SqlParameter("@pDayID", 4));
            cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
            cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

            //Friday
            fromTime = fromFridayTextBox.ToString();
            toTime = toFridayTextBox.ToString();
            cmd = new SqlCommand("addAvailability", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", availableId));
            cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
            //Day id is 5 for Friday.
            cmd.Parameters.Add(new SqlParameter("@pDayID", 5));
            cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
            cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

            //Saturday
            fromTime = fromSaturdayTextBox.ToString();
            toTime = toSaturdayTextBox.ToString();
            cmd = new SqlCommand("addAvailability", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", availableId));
            cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
            //Day id is 6 for Saturday.
            cmd.Parameters.Add(new SqlParameter("@pDayID", 6));
            cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
            cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));


            con.Close();
        }

        private void askOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TimeOffForm().Show();
        }

        private void AvailabilityTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
