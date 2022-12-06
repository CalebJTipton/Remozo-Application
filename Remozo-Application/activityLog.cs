using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remozo_Application
{
    public partial class activityLog : Form
    {
        public activityLog()
        {
            this.StartPosition = FormStartPosition.Manual;
            InitializeComponent();
        }

        private void btn_disableVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vehicle has been disabled!");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            Close();
        }

        private void activityLog_Load(object sender, EventArgs e)
        {

        }

        private void pb_scroll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No further activity to show.\n" +
                "Come back after you've used Remozo for longer.");
        }

        private void btn_lastWeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No further activity to show.\n" +
                "Come back after you've used Remozo for longer.");
        }

        private void btn_lastMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No further activity to show.\n" +
                "Come back after you've used Remozo for longer.");
        }
    }
}
