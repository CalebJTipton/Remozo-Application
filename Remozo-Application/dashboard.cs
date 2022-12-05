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
            InitializeComponent();
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
    }
}
