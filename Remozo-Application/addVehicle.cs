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
    public partial class addVehicle : Form
    {
        public addVehicle()
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
            dashboard dashboard = new dashboard();
            dashboard.Show();
            Close();
        }

        private void rbtn_EV_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_make_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_model_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
