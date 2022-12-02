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
    public partial class create_account : Form
    {
        public create_account()
        {
            InitializeComponent();
        }

        private void create_account_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_account_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != "" && txt_confirmPassword.Text != "")
            {
                if (txt_password.Text == txt_confirmPassword.Text)
                {
                    dashboard dashboard = new dashboard();
                    dashboard.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Whoops! Passwords do not match.");
                }
            }
            else
            {
                MessageBox.Show("Whoops! It appears you did not enter a password/confirm password");
            }
           
        }
    }
}
