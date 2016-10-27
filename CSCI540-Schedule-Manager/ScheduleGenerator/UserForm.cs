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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AvailabilityButton_Click(object sender, EventArgs e)
        {
            //Set the user's availability into the database.
        }

        private void askOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TimeOffForm().Show();
        }
    }
}
