﻿using System;
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

namespace ScheduleGenerator
{
    public partial class AddUserForm : Form
    {
		String serverInfo = "Data Source=" + System.Environment.GetEnvironmentVariable("COMPUTERNAME") + "\\SQLEXPRESS;Initial Catalog=SchedulingDatabase;Integrated Security=True";

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (AddFirstNameTextBox.TextLength <= 0)
            {
                MessageBox.Show("Please enter a first name.");
                return;
            }
            if (AddLastNameTextBox.TextLength <= 0)
            {
                MessageBox.Show("Please enter a last name.");
                return;
            }
            if (AddEmailTextBox.TextLength <= 0)
            {
                MessageBox.Show("Please enter an email.");
                return;
            }
            if (AddPasswordTextBox.TextLength <= 0)
            {
                MessageBox.Show("Please entr a password.");
                return;
            }
            SqlConnection con = new SqlConnection(serverInfo);
            con.Open();

            //Call
            string FirstName = AddFirstNameTextBox.Text;
            string LastName = AddLastNameTextBox.Text;
            string Email = AddEmailTextBox.Text;
            string Password = AddPasswordTextBox.Text;
            //string ID = addUserIDTextBox.Text;
            //int IDint = Convert.ToInt32(ID);

            SqlCommand cmd = new SqlCommand("addEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@pID", IDint);
            cmd.Parameters.AddWithValue("@pFirstName", FirstName);
            cmd.Parameters.AddWithValue("@pLastName", LastName);
            cmd.Parameters.AddWithValue("@pEmail", Email);
            cmd.Parameters.AddWithValue("@pPassword", Password);
            //Flat 0 value for the admin bit.
            cmd.Parameters.AddWithValue("@pAdmin", 0);
            cmd.ExecuteNonQuery();



            //      DataTable dt = new DataTable();
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
       //     da.Fill(dt);
       //     da.Update(dt);
            con.Close();
            MessageBox.Show("User was added!");
            this.Hide();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'admin.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter4.Fill(this.admin.Employee);
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
