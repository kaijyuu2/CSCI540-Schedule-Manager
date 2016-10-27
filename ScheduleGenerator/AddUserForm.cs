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
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ScheduleGenerator
{
    public partial class AddUserForm : Form
    {
        SqlConnection con = new SqlConnection();
        String serverInfo = "Data Source=MARK-PC\\MWSQLSERVER;Initial Catalog=SchedulingDatabase;Integrated Security=True";

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            //Call
            String FirstName = AddFirstNameTextBox.ToString();
            String LastName = AddLastNameTextBox.ToString();
            String Email = AddEmailTextBox.ToString();
            String Password = AddPasswordTextBox.ToString();
            String ID = addUserIDTextBox.ToString();

            SqlConnection con = new SqlConnection(serverInfo);
            SqlCommand cmd = new SqlCommand("addEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add( new SqlParameter("@pID", ID));
            cmd.Parameters.Add(new SqlParameter("@pFirstName", FirstName));
            cmd.Parameters.Add(new SqlParameter("@pLastName", LastName));
            cmd.Parameters.Add(new SqlParameter("@pEmail", Email));
            cmd.Parameters.Add(new SqlParameter("@pPassword", Password));
            //Flat 0 value for the admin bit.
            cmd.Parameters.Add(new SqlParameter("@pAdmin", 0));




            //      DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
       //     da.Fill(dt);
       //     da.Update(dt);
            con.Close();
            MessageBox.Show("User was added!");
            this.Hide();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'admin.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter4.Fill(this.admin.Employee);
            /*
                        // TODO: This line of code loads data into the 'password.Employee' table. You can move, or remove it, as needed.
                        this.employeeTableAdapter3.Fill(this.password.Employee);
                        // TODO: This line of code loads data into the 'email.Employee' table. You can move, or remove it, as needed.
                        this.employeeTableAdapter2.Fill(this.email.Employee);
                        // TODO: This line of code loads data into the 'lastName.Employee' table. You can move, or remove it, as needed.
                        this.employeeTableAdapter1.Fill(this.lastName.Employee);
                        // TODO: This line of code loads data into the 'firstName.Employee' table. You can move, or remove it, as needed.
                        this.employeeTableAdapter.Fill(this.firstName.Employee);
                       */
        }
    }
}
