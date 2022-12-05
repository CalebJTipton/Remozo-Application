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

        
    }
}
