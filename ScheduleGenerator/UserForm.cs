using System;
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
       // String serverInfo = "Data Source=MARK-PC\\MWSQLSERVER;Initial Catalog=SchedulingDatabase;Integrated Security=True";
        String serverInfo = "Data Source=HEADQUARTERS\\SQLEXPRESS;Initial Catalog=SchedulingDatabase;Integrated Security=True";
        private int currentUserId;

        //Must have a way to keep track of which user is using the form.

        public UserForm(int id)
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
            try
            {
                SqlConnection con = new SqlConnection(serverInfo);
                con.Open();

                //Sunday
                string fTime = fromSundayTextBox.Text;
                int fromTime = Convert.ToInt32(fTime);
                string tTime = toSundayTextBox.Text;
                int toTime = Convert.ToInt32(tTime);
                SqlCommand cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
                //Day id is 0 for Sunday.
                cmd.Parameters.Add(new SqlParameter("@pDayID", 0));
                cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
                cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

                //Monday
                fTime = fromMondayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toMondayTextBox.Text;
                toTime = Convert.ToInt32(tTime);
                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
                //Day id is 1 for Monday.
                cmd.Parameters.Add(new SqlParameter("@pDayID", 1));
                cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
                cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

                //Tuesday
                fTime = fromTuesdayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toTuesdayTextBox.Text;
                toTime = Convert.ToInt32(tTime);
                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
                //Day id is 2 for Tuesday.
                cmd.Parameters.Add(new SqlParameter("@pDayID", 2));
                cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
                cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

                //Wednesday
                fTime = fromWednesdayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toWednesdayTextBox.Text;
                toTime = Convert.ToInt32(tTime);
                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
                //Day id is 3 for Wednesday.
                cmd.Parameters.Add(new SqlParameter("@pDayID", 3));
                cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
                cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

                //Thursday
                fTime = fromThursdayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toThursdayTextBox.Text;
                toTime = Convert.ToInt32(tTime);
                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
                //Day id is 4 for Thursday.
                cmd.Parameters.Add(new SqlParameter("@pDayID", 4));
                cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
                cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

                //Friday
                fTime = fromFridayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toFridayTextBox.Text;
                toTime = Convert.ToInt32(tTime);
                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
                //Day id is 5 for Friday.
                cmd.Parameters.Add(new SqlParameter("@pDayID", 5));
                cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
                cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

                //Saturday
                fTime = fromSaturdayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toSaturdayTextBox.Text;
                toTime = Convert.ToInt32(tTime);
                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@pNewEmployeeID", currentUserId));
                //Day id is 6 for Saturday.
                cmd.Parameters.Add(new SqlParameter("@pDayID", 6));
                cmd.Parameters.Add(new SqlParameter("@pNewStartTime", fromTime));
                cmd.Parameters.Add(new SqlParameter("@pNewEndTime", toTime));

                MessageBox.Show("Changes have been pushed!");

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void askOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TimeOffForm(currentUserId).Show();
        }

        private void AvailabilityTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
