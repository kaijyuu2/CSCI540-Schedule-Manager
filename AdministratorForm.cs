using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ScheduleGenerator
{
    public partial class AdministratorForm : Form
    {
        SqlConnection con = new SqlConnection();
		String serverInfo = "Data Source=" + System.Environment.GetEnvironmentVariable("COMPUTERNAME") + "\\SQLEXPRESS;Initial Catalog=SchedulingDatabase;Integrated Security=True";
        Availability[] Availabilities = new Availability[50];

        public AdministratorForm()
        {
            InitializeComponent();
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
            //For each day of the week.         

            for (int i = 0; i < 7; i++)
            {
                //i represents the day of the week.
                fillArray(i);
                //Select availabilites to use for the day based on the current array of availabilities.
                selectAvailabilites(Availabilities);
                wipeAvailabilites();

            }
        }

        private void fillArray(int day)
        {
            //Initialize the array.
            for (int i = 0; i < Availabilities.Length; i++)
            {
                Availabilities[i] = new Availability();
            }

            //Open connection.
            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();
            //Get availabilities by day.

            SqlCommand cmd = new SqlCommand("getDayAvailabilities", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            //By the day number.
            cmd.Parameters.AddWithValue("@pDayID", day);

            //Get the information for each index from the database.
            int counter = 0;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //For each index create a new object for the array.
                    //Converts object to string, and string to int to put into array.
                    Availabilities[counter] = new Availability(Int32.Parse(dr["AvailabilityID"].ToString()), Int32.Parse(dr["EmployeeID"].ToString()),
                        Int32.Parse(dr["DayID"].ToString()), Int32.Parse(dr["StartTime"].ToString()), Int32.Parse(dr["EndTime"].ToString()));
                    counter++;
                }

                dr.Close();
                dr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            for(int i = 0; i < Availabilities.Length; i++)
            {
                int startTime = Availabilities[i].getStartTime();
                startTime /= 100;
                Availabilities[i].setStartTime(startTime);

                int endTime = Availabilities[i].getEndTime();
                endTime /= 100;
                Availabilities[i].setEndTime(endTime);
            }

        }

        private void selectAvailabilites(Availability[] availabilities)
        {
            //Checkpad for hours worked per day
            int[] checkPad = new int[18];
            Random generator = new Random();
            Availability selected = new Availability();
            //Not correct because byRef and not byVal? Should I recopy a new array?
            selected = availabilities[generator.Next(availabilities.Length)];

            for (int i = 0; i < checkPad.Length; i++)
            {
                if(i < 9)
                {
                    checkPad[i] = 1;
                }
                else
                {
                    checkPad[i] = 0;
                }
               
            }

            //Add this availability to the database for schedule table

            int start = 0, end = 0;

            start = selected.getStartTime();
            end = selected.getEndTime();

            //Block off times that the selected user takes up.
            for (; start <= end; start++)
            {
                checkPad[start] = 1;
            }

            //Fill out rest of time blocks.

            //For each in array
            for (int i = 0; i < availabilities.Length; i++)
            {
                selected = availabilities[i];
                start = selected.getStartTime();
                end = selected.getEndTime();

                for (; start <= end; start++)
                {
                    if (checkPad[start] == 0)
                    {
                        //Add the availability to the db.
                        richTextBox1.Text += "Emp ID: " + availabilities[i].getEmployeeID() + " Day ID: " + availabilities[i].getDayID() + " Start Time: " + availabilities[i].getStartTime() + " End Time: " + availabilities[i].getEndTime() + " \n";
                        checkPad[start] = 1;
                        //Delete the availability array or something.
                        //Here
                    }
                }

                //Catch last hour working.
                if((checkPad[start - 1] == 0))
                {
                    checkPad[start - 1] = 1;
                }

                //Add a check to see if checkpad is full? Save time
                if (checkFull(checkPad))
                {
                    break;
                }

            }
            con.Close();
        }

        private void wipeAvailabilites()
        {
            //Remove availabilities from the database.
            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();


            SqlCommand cmd = new SqlCommand("clearAvailabilities", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private Boolean checkFull(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }



}
