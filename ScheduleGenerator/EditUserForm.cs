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
                    EditUserBox.Items.Add(dr["EmployeeID"]);
                }

                dr.Close();
                dr.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SelectUserButton_Click(object sender, EventArgs e)
        {
            string currentID = EditUserBox.Text;
            int currentIDint = Convert.ToInt32(currentID);


            //Instead of having all of these label click methods this info needs to load on selection of employee.
            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();

            //Get first name.
            SqlCommand cmd = new SqlCommand("getFirstName", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pID", currentIDint);
//            cmd.ExecuteNonQuery();
            //Store result. I don't know how as you seem to display the knowledge in the login form.
            SetFirstNameTextBox.Text = cmd.ExecuteScalar().ToString();

            //Get last name.
            cmd = new SqlCommand("getLastName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pID", currentID));
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

        private void EditUserForm_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'schedulingDatabaseDataSet1.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.schedulingDatabaseDataSet1.Employee);

        }

        private void SubmitChangesButton_Click(object sender, EventArgs e)
        {
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
    }
}
