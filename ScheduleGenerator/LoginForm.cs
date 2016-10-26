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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
       // String serverInfo = "Data Source=MARK-PC\\MWSQLSERVER;Initial Catalog=SchedulingDatabase;Integrated Security=True";
        String serverInfo = "Data Source=HEADQUARTERS\\SQLEXPRESS;Initial Catalog=SchedulingDatabase;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

        }
        
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(serverInfo);
                con.Open();
                string userID = UsernameTextBox.Text;
                int userIDint = Convert.ToInt32(userID);
                string password = PasswordMaskedTextBox.Text;

                // SqlCommand cmd = new SqlCommand("getPassword", con);
                // cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.Add(new SqlParameter("@pID", email));

                SqlCommand cmd = new SqlCommand("select EmployeeID,Password from Employee where EmployeeID='" + userID + "'and Password='" + password + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlCommand adminCheck = new SqlCommand("select * from Employee where EmployeeID='" + userID + "'and Admin='True'", con);
                    //You might need to check the procedure as I'm not sure what you called the Admin column so it could cause errors.
                    SqlDataAdapter idDataAdapter = new SqlDataAdapter(adminCheck);


                   // SqlCommand adminCheck = new SqlCommand("getAdmin", con);
                   // adminCheck.Parameters.Add(new SqlParameter("@pID", userID));
                   // adminCheck.CommandType = CommandType.StoredProcedure;
                     DataSet userDataSetID = new DataSet();
                     idDataAdapter.Fill(userDataSetID, "EmployeeID");
                    //int userID = userDataSetID.

                  //  SqlCommand adminCheck = new SqlCommand("getAdmin", con);
                  //  adminCheck.CommandType = CommandType.StoredProcedure;
                  //  adminCheck.Parameters.Add(new SqlParameter("@pEmail", email));
                    SqlDataAdapter adminDA = new SqlDataAdapter(adminCheck);
                    DataTable adminDT = new DataTable();

                    adminDA.Fill(adminDT);
                    if(adminDT.Rows.Count > 0)
                    {
                        MessageBox.Show("Login successful");
                        new AdministratorForm().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login successful");
                        new UserForm(userIDint).Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

       // private void LoginForm_Load(object sender, EventArgs e)
        //{
            // TODO: This line of code loads data into the 'email.Employee' table. You can move, or remove it, as needed.
          //  this.employeeTableAdapter1.Fill(this.email.Employee);
        //}
    }
}
