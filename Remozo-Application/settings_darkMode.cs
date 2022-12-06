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
    public partial class settings_darkMode : Form
    {
        public settings_darkMode()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_darkMode_disabled_CheckedChanged(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();
            Close();
        }

        private void btn_checkUpdates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.01 is up to date. \n" +
                      "No new updates available.");
        }

        private void rbtn_geofence_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_geofence.Text == "")
            {
                rbtn_geofence_disabled.Checked = true;
                MessageBox.Show("Before turning on Geofence\nplease enter a desired area.");
            }
        }
    }
}
