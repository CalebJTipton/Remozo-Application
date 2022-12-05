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
    public partial class userAuthSelect : Form
    {
        public userAuthSelect()
        {
            InitializeComponent();
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            create_account create_Account = new create_account();

            create_Account.Show();

            Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login login = new login();

            login.Show();

            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();

            dashboard.Show();

            Close();
        }
    }
}
