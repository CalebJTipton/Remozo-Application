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
            InitializeComponent();
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

        }

        private void rbtn_window1_closed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_window2_open_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_window2_closed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_window3_open_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_window3_closed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_window4_open_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_window4_closed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_window5_open_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_window5_closed_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
