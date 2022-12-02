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

        }

        private void btn_maintainExpand_Click(object sender, EventArgs e)
        {
            maintain maintain = new maintain();

            maintain.Show();

            Close();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {

        }
    }
}
