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
    public partial class TimeOffForm : Form
    {
        private int userID;
        public TimeOffForm(int id)
        {
            userID = id;
            InitializeComponent();
        }

        private void TimeOffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
