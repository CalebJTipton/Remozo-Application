﻿using System;
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
    public partial class changeVehicle : Form
    {
        public changeVehicle()
        {
            this.StartPosition = FormStartPosition.Manual;
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            Close();
        }

        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            addVehicle addVehicle = new addVehicle();
            addVehicle.Show();
            Close();
        }

        private void lbl_jeepWrangler_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            Close();
        }

        private void lbl_porcheTaycan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vehicle is checked out, check back later.");
        }
    }
}
