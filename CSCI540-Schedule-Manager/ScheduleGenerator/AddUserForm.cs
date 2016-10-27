using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleGenerator
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            //Call
            String FirstName = AddFirstNameTextBox.ToString();
            String LastName = AddLastNameTextBox.ToString();
            String EmployeeID = AddIDTextBox.ToString();
            String Email = AddLastNameTextBox.ToString();

            int Password = 1;

            //GeneratedPasswordTextBox.Text().Equals("1");
            //Call sql procedure addUser(FirstName,LastName,EmployeeID,Email, Password);
        }
    }
}
