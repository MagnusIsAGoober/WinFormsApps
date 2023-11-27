namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FinlandPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Finland";
        }

        private void FrancePictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "France";
        }

        private void GermanyPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Germany";
        }
    }
}