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
    public partial class AdministratorForm : Form
    {
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
    }
}
