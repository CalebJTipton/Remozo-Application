namespace Remozo_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            nextPage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_moveToNextPage_Click(object sender, EventArgs e)
        {
            
        }

        public async void nextPage()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));

            userAuthSelect userAuthSelect = new userAuthSelect();

            userAuthSelect.Show();

            Hide();
        }
    }
}