﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Remozo_Application
{
    public partial class login : Form
    {
        public login()
        {
            this.StartPosition = FormStartPosition.Manual;
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "password")
            {
                dashboard dashboard = new dashboard();

                dashboard.Show();

                Close();

            }

            else
            {
                MessageBox.Show("Whoops! Wrong password, try again!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
