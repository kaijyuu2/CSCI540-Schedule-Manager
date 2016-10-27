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

       // String serverInfo = "Data Source=MARK-PC\\MWSQLSERVER;Initial Catalog=SchedulingDatabase;Integrated Security=True";
        String serverInfo = "Data Source=HEADQUARTERS\\SQLEXPRESS;Initial Catalog=SchedulingDatabase;Integrated Security=True";

        //String serverInfo = "Data Source=" + System.Environment.GetEnvironmentVariable("COMPUTERNAME") + "\\SQLEXPRESS;Initial Catalog=SchedulingDatabase;Integrated Security=True";

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
                //SqlConnection con = new SqlConnection(serverInfo);
                con.Open();

                //Sunday
                string fTime = fromSundayTextBox.Text;
                int fromTime = Convert.ToInt32(fTime);
                string tTime = toSundayTextBox.Text;
                int toTime = Convert.ToInt32(tTime);
                //SqlCommand cmd = new SqlCommand("INSERT INTO Availability(EmployeeID, DayID, StartTIme, EndTime) VALUES(" + currentUserId + ", " + 1 + " , " + fromTime + ", " + toTime +")");
                SqlCommand cmd = new SqlCommand("[dbo].[addAvailability]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 1 for Sunday.
                cmd.Parameters.AddWithValue("@pNewDayID", 1);
                cmd.Parameters.AddWithValue("@pNewStartTime", fromTime);
                cmd.Parameters.AddWithValue("@pNewEndTime", toTime);
                cmd.ExecuteNonQuery();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //da.InsertCommand;

                //Monday
                fTime = fromMondayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toMondayTextBox.Text;
                toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("[dbo].[addAvailability]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 2 for Monday.
                cmd.Parameters.AddWithValue("@pNewDayID", 2);
                cmd.Parameters.AddWithValue("@pNewStartTime", fromTime);
                cmd.Parameters.AddWithValue("@pNewEndTime", toTime);
                cmd.ExecuteNonQuery();

                //Tuesday
                fTime = fromTuesdayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toTuesdayTextBox.Text;
                toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 3 for Tuesday.
                cmd.Parameters.AddWithValue("@pNewDayID", 3);
                cmd.Parameters.AddWithValue("@pNewStartTime", fromTime);
                cmd.Parameters.AddWithValue("@pNewEndTime", toTime);
                cmd.ExecuteNonQuery();

                //Wednesday
                fTime = fromWednesdayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toWednesdayTextBox.Text;
                toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 4 for Wednesday.
                cmd.Parameters.AddWithValue("@pNewDayID", 4);
                cmd.Parameters.AddWithValue("@pNewStartTime", fromTime);
                cmd.Parameters.AddWithValue("@pNewEndTime", toTime);
                cmd.ExecuteNonQuery();

                //Thursday
                fTime = fromThursdayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toThursdayTextBox.Text;
                toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 5 for Thursday.
                cmd.Parameters.AddWithValue("@pNewDayID", 5);
                cmd.Parameters.AddWithValue("@pNewStartTime", fromTime);
                cmd.Parameters.AddWithValue("@pNewEndTime", toTime);
                cmd.ExecuteNonQuery();

                //Friday
                fTime = fromFridayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toFridayTextBox.Text;
                toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 6 for Friday.
                cmd.Parameters.AddWithValue("@pNewDayID", 6);
                cmd.Parameters.AddWithValue("@pNewStartTime", fromTime);
                cmd.Parameters.AddWithValue("@pNewEndTime", toTime);
                cmd.ExecuteNonQuery();

                //Saturday
                fTime = fromSaturdayTextBox.Text;
                fromTime = Convert.ToInt32(fTime);
                tTime = toSaturdayTextBox.Text;
                toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 7 for Saturday.
                cmd.Parameters.AddWithValue("@pNewDayID", 7);
                cmd.Parameters.AddWithValue("@pNewStartTime", fromTime);
                cmd.Parameters.AddWithValue("@pNewEndTime", toTime);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Changes have been pushed!");

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
