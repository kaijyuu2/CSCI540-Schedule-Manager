using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleGenerator
{
    public partial class AdministratorForm : Form
    {
        String serverInfo = "Data Source=.;Initial Catalog=SchedulingDatabase;Integrated Security=True";
        public AdministratorForm()
        {
            InitializeComponent();
            LoadSchedule();
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

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddUserMenuItem_Click(object sender, EventArgs e)
        {
            new AddUserForm().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This will be filled with users.
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditUserForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserForm(0).Show();
            this.Hide();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(serverInfo);
            //SqlConnection con = new SqlConnection(serverInfo);
            con.Open();
            try
            {
                for (int i = 1; i <= 7; i++)
                {
                    for (int j = 1; j <= 12; j++)
                    {
                        SqlCommand cmd = new SqlCommand("select EmployeeID from Availability where DayID=" + i + "and DurationID=" + j, con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            int rInt = 0;
                            if (dt.Rows.Count == 1)
                                rInt = 0;
                            else
                            {
                                Random r = new Random();
                                rInt = r.Next(0, dt.Rows.Count - 1);
                            }
                            cmd.Dispose();
                            cmd = null;
                            cmd = new SqlCommand("[dbo].[addSchedule]", con);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@pNewEmployeeID", dt.Rows[rInt].Field<int>("EmployeeID"));
                            //Day id is 1 for Sunday.
                            cmd.Parameters.AddWithValue("@pNewDayID", i);
                            cmd.Parameters.AddWithValue("@pDurationID", j);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            da.Dispose();
                            dt.Dispose();
                            Label lbl = this.Controls.Find("lbl" + i.ToString() + j.ToString(), true).FirstOrDefault() as Label;
                            lbl.Text = "Emp-ID: " + dt.Rows[rInt].Field<int>("EmployeeID");
                        }
                        else
                        {
                            cmd.Dispose();
                            da.Dispose();
                            dt.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            con.Dispose();
        }
    }
}
