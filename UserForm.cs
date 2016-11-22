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
        String serverInfo = "Data Source=.;Initial Catalog=SchedulingDatabase;Integrated Security=True";

        //String serverInfo = "Data Source=" + System.Environment.GetEnvironmentVariable("COMPUTERNAME") + "\\SQLEXPRESS;Initial Catalog=SchedulingDatabase;Integrated Security=True";

        private int currentUserId;

        //Must have a way to keep track of which user is using the form.

        public UserForm(int id)
        {
            currentUserId = id;
            InitializeComponent();
            LoadSchedule();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AvailabilityButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(serverInfo);
            //SqlConnection con = new SqlConnection(serverInfo);
            con.Open();
            SqlCommand cmd = null;
            bool flag = false;
            try
            {
                foreach (Control c in tableLayoutPanel2.Controls)
                {
                    if ((c is CheckBox) && ((CheckBox)c).Checked)
                    {
                        cmd = new SqlCommand("[dbo].[addAvailability]", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                        //Day id is 1 for Sunday.
                        cmd.Parameters.AddWithValue("@pNewDayID", int.Parse(c.Tag.ToString().Substring(0, 1)));
                        cmd.Parameters.AddWithValue("@pDurationID", int.Parse(c.Tag.ToString().Substring(1)));
                        cmd.Parameters.AddWithValue("@pDeleteFlag", flag);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        flag = true;
                    }
                }
                if (!flag)
                    MessageBox.Show("No selection made. Cannot save details.");
                else
                    MessageBox.Show("Changes have been pushed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AvailabilityButton_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(serverInfo);
                //SqlConnection con = new SqlConnection(serverInfo);
                con.Open();

                //Sunday
                //string fTime = fromSundayTimePicker.Text;
                //int fromTime = Convert.ToInt32(fTime);
                //string tTime = toSundayTimePicker.Text;
                //int toTime = Convert.ToInt32(tTime);
                //SqlCommand cmd = new SqlCommand("INSERT INTO Availability(EmployeeID, DayID, StartTIme, EndTime) VALUES(" + currentUserId + ", " + 1 + " , " + fromTime + ", " + toTime +")");
                SqlCommand cmd = new SqlCommand("[dbo].[addAvailability]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 1 for Sunday.
                cmd.Parameters.AddWithValue("@pNewDayID", 1);
                //cmd.Parameters.AddWithValue("@pNewStartTime", fromSundayTimePicker.Text);
                //cmd.Parameters.AddWithValue("@pNewEndTime", toSundayTimePicker.Text);
                cmd.ExecuteNonQuery();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //da.InsertCommand;

                //Monday
                //fTime = fromMondayTimePicker.Text;
                //fromTime = Convert.ToInt32(fTime);
                //tTime = toMondayTimePicker.Text;
                //toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("[dbo].[addAvailability]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 2 for Monday.
                cmd.Parameters.AddWithValue("@pNewDayID", 2);
                //cmd.Parameters.AddWithValue("@pNewStartTime", k.Text);
                //cmd.Parameters.AddWithValue("@pNewEndTime", toMondayTimePicker.Text);
                cmd.ExecuteNonQuery();

                //Tuesday
                //fTime = fromTuesdayTimePicker.Text;
                //fromTime = Convert.ToInt32(fTime);
                //tTime = toTuesdayTimePicker.Text;
                //toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 3 for Tuesday.
                cmd.Parameters.AddWithValue("@pNewDayID", 3);
                //cmd.Parameters.AddWithValue("@pNewStartTime", fromTuesdayTimePicker.Text);
                //cmd.Parameters.AddWithValue("@pNewEndTime", toTuesdayTimePicker.Text);
                cmd.ExecuteNonQuery();

                //Wednesday
                //fTime = fromWednesdayTimePicker.Text;
                //fromTime = Convert.ToInt32(fTime);
                //tTime = toWednesdayTimePicker.Text;
                //toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 4 for Wednesday.
                cmd.Parameters.AddWithValue("@pNewDayID", 4);
                //cmd.Parameters.AddWithValue("@pNewStartTime", fromWednesdayTimePicker.Text);
                //cmd.Parameters.AddWithValue("@pNewEndTime", toWednesdayTimePicker.Text);
                cmd.ExecuteNonQuery();

                //Thursday
                //fTime = fromThursdayTimePicker.Text;
                //fromTime = Convert.ToInt32(fTime);
                //tTime = toThursdayTimePicker.Text;
                //toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 5 for Thursday.
                cmd.Parameters.AddWithValue("@pNewDayID", 5);
                // cmd.Parameters.AddWithValue("@pNewStartTime", fromThursdayTimePicker.Text);
                //cmd.Parameters.AddWithValue("@pNewEndTime", toThursdayTimePicker.Text);
                cmd.ExecuteNonQuery();

                //Friday
                //fTime = fromFridayTimePicker.Text;
                //fromTime = Convert.ToInt32(fTime);
                //tTime = toFridayTimePicker.Text;
                //toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 6 for Friday.
                cmd.Parameters.AddWithValue("@pNewDayID", 6);
                // cmd.Parameters.AddWithValue("@pNewStartTime", fromFridayTimePicker.Text);
                //cmd.Parameters.AddWithValue("@pNewEndTime", toFridayTimePicker.Text);
                cmd.ExecuteNonQuery();

                //Saturday
                //fTime = fromSaturdayTimePicker.Text;
                //fromTime = Convert.ToInt32(fTime);
                //tTime = toSaturdayTimePicker.Text;
                //toTime = Convert.ToInt32(tTime);

                cmd = new SqlCommand("addAvailability", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pNewEmployeeID", currentUserId);
                //Day id is 7 for Saturday.
                cmd.Parameters.AddWithValue("@pNewDayID", 7);
                //cmd.Parameters.AddWithValue("@pNewStartTime", fromSaturdayTimePicker.Text);
                //cmd.Parameters.AddWithValue("@pNewEndTime", toSaturdayTimePicker.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Changes have been pushed!");

            }
            catch (Exception ex)
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

        private void LoadSchedule()
        {
            SqlConnection con = new SqlConnection(serverInfo);
            //SqlConnection con = new SqlConnection(serverInfo);
            con.Open();
            try
            {
                SqlCommand cmd = null;
                for (int i = 1; i <= 7; i++)
                {
                    for (int j = 1; j <= 12; j++)
                    {
                        cmd = con.CreateCommand();
                        cmd.CommandText = "Select TOP 1 EmployeeID from FinalSchedule where DayID=" + i + " and DurationID=" + j + " order by TimeStamp desc";

                        int? result = ((int?)cmd.ExecuteScalar());
                        if (result == null || result == 0)
                        {
                            Label lbl = this.Controls.Find("lbl" + i.ToString() + j.ToString(), true).FirstOrDefault() as Label;
                            lbl.Text = "NA";
                        }
                        else
                        {
                            Label lbl = this.Controls.Find("lbl" + i.ToString() + j.ToString(), true).FirstOrDefault() as Label;
                            lbl.Text = "Emp-ID: " + result;
                        }
                        cmd.Dispose();
                        cmd = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            con.Close();
            con.Dispose();
        }
    }
}
