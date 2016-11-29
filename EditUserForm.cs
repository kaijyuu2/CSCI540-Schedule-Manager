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
		String serverInfo = "Data Source=" + System.Environment.GetEnvironmentVariable("COMPUTERNAME") + "\\SQLEXPRESS;Initial Catalog=SchedulingDatabase;Integrated Security=True";
        private List<int> employeeIDs = new List<int>();
        private int currentID;

        public EditUserForm()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();
            SqlCommand fillName = new SqlCommand("select * from Employee", con);

            try
            {
                SqlDataReader dr = fillName.ExecuteReader();

                while(dr.Read())
                {
                    EditUserBox.Items.Add(dr["First name"] + " " + dr["Last name"]);
                    employeeIDs.Add(int.Parse(dr["EmployeeID"].ToString()));
                }

                dr.Close();
                dr.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void EditUserForm_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'schedulingDatabaseDataSet1.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.schedulingDatabaseDataSet1.Employee);

        }

        private void SubmitChangesButton_Click(object sender, EventArgs e)
        {
            if (EditUserBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an employee first.");
                return;
            }
            if (SetEmailBoxx.TextLength <= 0)
            {
                MessageBox.Show("Must have an email entered.");
                return;
            }
            if (SetPasswordBox.TextLength <= 0)
            {
                MessageBox.Show("Must have a password entered.");
                return;
            }
            if (SetLastNameTextBox.TextLength <= 0)
            {
                MessageBox.Show("Must have a last name entered.");
                return;
            }
            if (SetFirstNameTextBox.TextLength <= 0)
            {
                MessageBox.Show("Must have a password entered.");
                return;
            }
            //Update users password.
            string newPassword = SetEmailBoxx.Text;
            string newEmail = SetPasswordBox.Text;
            string newLName = SetLastNameTextBox.Text;
            string newFName = SetFirstNameTextBox.Text;

            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();

            SqlCommand cmd = new SqlCommand("setPassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            cmd.Parameters.Add(new SqlParameter("@pNewPassword", newPassword));
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("setEmail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            cmd.Parameters.Add(new SqlParameter("@pNewEmail", newEmail));
            cmd.ExecuteNonQuery();
            
            cmd = new SqlCommand("setLastName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            cmd.Parameters.Add(new SqlParameter("@pNewLastName", newLName));
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("setFirstName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            cmd.Parameters.Add(new SqlParameter("@pNewFirstName", newFName));
            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void EditUserBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentID = employeeIDs[EditUserBox.SelectedIndex];

            //Instead of having all of these label click methods this info needs to load on selection of employee.
            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();

            //Get first name.
            SqlCommand cmd = new SqlCommand("getFirstName", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pID", currentID);
            //            cmd.ExecuteNonQuery();
            //Store result. I don't know how as you seem to display the knowledge in the login form.
            SetFirstNameTextBox.Text = cmd.ExecuteScalar().ToString();

            //Get last name.
            cmd = new SqlCommand("getLastName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pID", currentID);
            //Store result.
            SetLastNameTextBox.Text = cmd.ExecuteScalar().ToString();

            //Get email.
            cmd = new SqlCommand("getEmail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            //Store result.
            SetEmailBoxx.Text = cmd.ExecuteScalar().ToString();

            //Get password.
            cmd = new SqlCommand("getPassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
            //Store result.
            SetPasswordBox.Text = cmd.ExecuteScalar().ToString();


            con.Close();
        }
    }
}
