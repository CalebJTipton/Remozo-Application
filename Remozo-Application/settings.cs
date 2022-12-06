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
    public partial class settings : Form
    {
        


        public settings()
        {
            InitializeComponent();
            //chk_darkModeEnabled.Appearance = System.Windows.Forms.Appearance.Button;
            //chk_darkModeDisabled.Appearance = System.Windows.Forms.Appearance.Button;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            Close();
        }

        private void txt_geoFence_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void btn_checkUpdates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.01 is up to date. \n" +
                            "No new updates available.");
        }

        private void darkModeGroup_Enter(object sender, EventArgs e)
        {

        }

        private void rbtn_darkMode_enabled_CheckedChanged(object sender, EventArgs e)
        {
            settings_darkMode settings_darkMode = new settings_darkMode();

            settings_darkMode.Show();

            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_darkMode_disabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_maintenance_enabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_maintenance_disabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_geofence_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_geofence.Text == "")
            {
                rbtn_geofence_disabled.Checked = true;
                MessageBox.Show("Before turning on Geofence\nplease enter a desired area.");
            }
        }

        private void rbtn_geofence_disabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_contrast_enabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_contrast_disabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_colorblind_enabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_colorblind_disabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_vibration_enabled_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_vibration_disabled_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
