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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            this.StartPosition = FormStartPosition.Manual;
            InitializeComponent();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_locateExpand_Click(object sender, EventArgs e)
        {
            locate locate = new locate();
            locate.Show();
            Hide();

        }

        private void btn_maintainExpand_Click(object sender, EventArgs e)
        {
            maintain maintain = new maintain();
            maintain.Show();
            Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            settings settings = new settings();
            settings.Show();
            Close();
        }

        private void btn_controlExpand_Click(object sender, EventArgs e)
        {
            control control = new control();
            control.Show();
            Close();
        }

        private void btn_changeVehicle_Click(object sender, EventArgs e)
        {
            changeVehicle changeVehicle = new changeVehicle();
            changeVehicle.Show();
            Close();
        }

        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            addVehicle addVehicle = new addVehicle();
            addVehicle.Show();
            Close();
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
    }
}
