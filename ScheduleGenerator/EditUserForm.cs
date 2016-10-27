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
    public partial class EditUserForm : Form
    {
        //PLEASE NOTE NO CHECKS FOR ENTRY OF THIS FORM HAVE BEEN ADDED YET.
        SqlConnection con = new SqlConnection();
        //String serverInfo = "Data Source=MARK-PC\\MWSQLSERVER;Initial Catalog=SchedulingDatabase;Integrated Security=True";
        String serverInfo = "Data Source=HEADQUARTERS\\SQLEXPRESS;Initial Catalog=SchedulingDatabase;Integrated Security=True";
        private String currentID;

        public EditUserForm()
        {
            //HAVE TO HAVE THE ID's Loaded into the combobox. I'm not sure how to do this so we need to talk about it.
            InitializeComponent();
        }

        private void SelectUserButton_Click(object sender, EventArgs e)
        {
            currentID = EditUserBox.ToString();
            String firstName, lastName, email, password;

            //Instead of having all of these label click methods this info needs to load on selection of employee.
            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();

            //Get first name.
            SqlCommand cmd = new SqlCommand("getFirstName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            //Store result. I don't know how as you seem to display the knowledge in the login form.
            //label1.Text = firstName;

            //Get last name.
            cmd = new SqlCommand("getLastName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            //Store result.
            //label2.Text = lastName;

            //Get email.
            cmd = new SqlCommand("getLastName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            //Store result.
            //label3.Text = email;

            //Get password.
            cmd = new SqlCommand("getLastName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            //Store result.
            //label5.Text = password;


            con.Close();
        }

        private void ChangeFirstNameButton_Click(object sender, EventArgs e)
        {
            //Update users first name.
            String newFName = SetFirstNameTextBox.ToString();

            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();

            SqlCommand cmd = new SqlCommand("setFirstName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            cmd.Parameters.Add(new SqlParameter("@pNewFirstName", newFName));
            //Call it.

            con.Close();
        }

        private void ChangeLastNameButton_Click(object sender, EventArgs e)
        {
            //Update users last name.
            String newLName = SetLastNameTextBox.ToString();

            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();

            SqlCommand cmd = new SqlCommand("setLastName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            cmd.Parameters.Add(new SqlParameter("@pNewLastName", newLName));
            //Call it.

            con.Close();
        }

        private void SetEmailButton_Click(object sender, EventArgs e)
        {
            //Update users email.
            String newEmail = SetEmailTextBox.ToString();

            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();

            SqlCommand cmd = new SqlCommand("setEmail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            cmd.Parameters.Add(new SqlParameter("@pNewEmail", newEmail));
            //Call it.

            con.Close();
        }

        private void SetPasswordButton_Click(object sender, EventArgs e)
        {
            //Update users password.
            String newPassword = SetPasswordTextBox.ToString();

            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();

            SqlCommand cmd = new SqlCommand("setPassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            cmd.Parameters.Add(new SqlParameter("@pNewPassword", newPassword));
            //Call it.

            con.Close();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schedulingDatabaseDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.schedulingDatabaseDataSet1.Employee);

        }
    }
}
