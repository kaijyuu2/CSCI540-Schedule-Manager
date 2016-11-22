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
        //String serverInfo = "Data Source="+System.Environment.GetEnvironmentVariable("COMPUTERNAME")+"\\SQLEXPRESS;Initial Catalog=SchedulingDatabase;Integrated Security=True";
        String serverInfo = "Data Source=.;Initial Catalog=SchedulingDatabase;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UsernameTextBox.Text) && !string.IsNullOrEmpty(PasswordMaskedTextBox.Text))
            {
                try
                {
                    SqlConnection con = new SqlConnection(serverInfo);
                    con.Open();

                    string userID = UsernameTextBox.Text;
                    int userIDint = Convert.ToInt32(userID);
                    string password = PasswordMaskedTextBox.Text;

                    //SqlCommand cmd = new SqlCommand("[dbo].[getPassword]", con);
                    // cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@pID", userIDint);
                    //cmd.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("select EmployeeID,Password     from Employee where EmployeeID='" + userID + "'and Password='" + password + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        SqlCommand adminCheck = new SqlCommand("select * from Employee where EmployeeID='" + userID + "'and Admin='True'", con);
                        //You might need to check the procedure as I'm not sure what you called the Admin column so it could cause errors.
                        SqlDataAdapter idDataAdapter = new SqlDataAdapter(adminCheck);


                        //SqlCommand adminCheck = new SqlCommand("getAdmin", con);
                        //adminCheck.CommandType = CommandType.StoredProcedure;
                        //adminCheck.Parameters.AddWithValue("@pID", userIDint);
                        //adminCheck.ExecuteNonQuery();

                        // DataSet userDataSetID = new DataSet();
                        //idDataAdapter.Fill(userDataSetID, "EmployeeID");
                        //int userID = userDataSetID.

                        //  SqlCommand adminCheck = new SqlCommand("getAdmin", con);
                        //  adminCheck.CommandType = CommandType.StoredProcedure;
                        //  adminCheck.Parameters.Add(new SqlParameter("@pEmail", email));
                        SqlDataAdapter adminDA = new SqlDataAdapter(adminCheck);
                        DataTable adminDT = new DataTable();

                        adminDA.Fill(adminDT);
                        if (adminDT.Rows.Count > 0)

                        //SqlDataReader reader;

                        //pull from database like "userID = DATABASECALL.GETID_FROM_STRING(UsernameTextBox.Text)"
                        //NOTE: appears that maybe not all database data on the lower levels is fully initialized
                        //      (e.g. "employee" stuff is blank maybe?) -- might need to put in some test ones
                        //      procedures all work fine but the DAYS, EMPLOYEES, etc are blank-ish but with the correct columns

                        //string userEmail = UsernameTextBox.Text;
                        //Int32 userID = -1;
                        //SqlCommand getid = new SqlCommand();
                        //getid.CommandText = "getEmployeeIDFromEmail";
                        //getid.CommandType = CommandType.StoredProcedure;
                        //getid.Connection = con;
                        //getid.Parameters.Add(new SqlParameter("@email", userEmail));
                        //reader = getid.ExecuteReader();
                        //if(reader.HasRows)
                        //{
                        // while(reader.Read())
                        //{
                        //  userID = reader.GetInt32(0);
                        // break;
                        //}
                        //}
                        //else
                        //{
                        //  userID = -1;
                        //}
                        //reader.Close();

                        //string password = PasswordMaskedTextBox.Text;
                        //string userPassword = "";

                        //SqlCommand cmd = new SqlCommand("select Email,Password from Employee where Email='" + userEmail + "'and Password='" + password + "'", con);
                        //SqlCommand cmd = new SqlCommand("getPassword", con);
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.Add(new SqlParameter("@pID", userID));
                        //reader = cmd.ExecuteReader();
                        //if(reader.HasRows)
                        //{
                        //  while(reader.Read())
                        //{
                        //  userPassword = reader.GetString(0);
                        //userPassword.Trim(); //remove trailing spaces
                        //break;
                        //}
                        //}
                        //reader.Close();

                        //  if (password.Equals(userPassword) && !userPassword.Equals(""))
                        //{
                        //  SqlCommand adminCheck = new SqlCommand("getAdmin", con);
                        //adminCheck.Parameters.Add(new SqlParameter("@pID", userID));
                        // adminCheck.CommandType = CommandType.StoredProcedure;
                        //bool adminbool = false;
                        //reader = adminCheck.ExecuteReader();
                        //if(reader.HasRows)
                        //{
                        //  while(reader.Read())
                        //{
                        //  adminbool = reader.GetBoolean(0);
                        //break;
                        //}
                        //}
                        //reader.Close();
                        //if(adminbool)
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                MessageBox.Show("User ID and Password are required.");
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
