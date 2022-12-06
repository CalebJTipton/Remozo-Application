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
    public partial class control : Form
    {
        public control()
        {
            this.StartPosition = FormStartPosition.Manual;
            InitializeComponent();

            pb_window1_up.Visible = false;
            pb_window2_up.Visible = false;
            pb_window3_up.Visible = false;
            pb_window4_up.Visible = false;
            pb_window5_up.Visible = false;

            pb_locked.Visible = true;
            pb_armed.Visible = true;
            pb_off.Visible = true;

            lbl_locked.Visible = true;
            lbl_armed.Visible = true;
            lbl_off.Visible = true;
            lbl_unlocked.Visible = false;
            lbl_disarmed.Visible = false;
            lbl_on.Visible = false;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            Close();
        }

        private void btn_diableVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vehicle has been Disabled!");
        }

        private void rbtn_window1_open_CheckedChanged(object sender, EventArgs e)
        {
            pb_window1_up.Visible = true;
        }

        private void rbtn_window1_closed_CheckedChanged(object sender, EventArgs e)
        {
            pb_window1_up.Visible = false;
        }

        private void rbtn_window2_open_CheckedChanged(object sender, EventArgs e)
        {
            pb_window2_up.Visible = true;
        }

        private void rbtn_window2_closed_CheckedChanged(object sender, EventArgs e)
        {
            pb_window2_up.Visible = false;
        }

        private void rbtn_window3_open_CheckedChanged(object sender, EventArgs e)
        {
            pb_window3_up.Visible = true;
        }

        private void rbtn_window3_closed_CheckedChanged(object sender, EventArgs e)
        {
            pb_window3_up.Visible = false;
        }

        private void rbtn_window4_open_CheckedChanged(object sender, EventArgs e)
        {
            pb_window4_up.Visible = true;
        }

        private void rbtn_window4_closed_CheckedChanged(object sender, EventArgs e)
        {
            pb_window4_up.Visible = false;
        }

        private void rbtn_window5_open_CheckedChanged(object sender, EventArgs e)
        {
            pb_window5_up.Visible = true;
        }

        private void rbtn_window5_closed_CheckedChanged(object sender, EventArgs e)
        {
            pb_window5_up.Visible = false;
        }

        private void pb_window1_Click(object sender, EventArgs e)
        {

        }

        private void pb_window2_Click(object sender, EventArgs e)
        {

        }

        private void pb_window3_Click(object sender, EventArgs e)
        {

        }

        private void pb_window4_Click(object sender, EventArgs e)
        {

        }

        private void pb_window5_Click(object sender, EventArgs e)
        {

        }

        private void control_Load(object sender, EventArgs e)
        {

        }

        private void pb_window1_down_Click(object sender, EventArgs e)
        {

        }

        private void pb_unlocked_Click(object sender, EventArgs e)
        {
            pb_locked.Visible = true;
            lbl_unlocked.Visible = false;
            lbl_locked.Visible = true;
        }

        private void pb_disarmed_Click(object sender, EventArgs e)
        {
            pb_armed.Visible = true;
            lbl_armed.Visible = true;
            lbl_disarmed.Visible = false;
        }

        private void pb_started_Click(object sender, EventArgs e)
        {
            pb_off.Visible = true;
            lbl_off.Visible = true;
            lbl_on.Visible = false;


        }

        private void pb_locked_Click(object sender, EventArgs e)
        {
            pb_locked.Visible = false;
            lbl_locked.Visible = false;
            lbl_unlocked.Visible = true;
        }

        private void pb_armed_Click(object sender, EventArgs e)
        {
            pb_armed.Visible = false;
            lbl_armed.Visible = false;
            lbl_disarmed.Visible = true;
        }

        private void pb_off_Click(object sender, EventArgs e)
        {
            pb_off.Visible = false;
            lbl_off.Visible = false;
            lbl_on.Visible = true;
        }

        private void lbl_locked_Click(object sender, EventArgs e)
        {

        }

        private void lbl_armed_Click(object sender, EventArgs e)
        {

        }

        private void lbl_on_Click(object sender, EventArgs e)
        {

        }
    }
}
