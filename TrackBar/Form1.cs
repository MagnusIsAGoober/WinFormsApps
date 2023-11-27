namespace TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            materialLabel1.Text = Convert.ToString(trackBar1.Value);


            pictureBox1.Width = trackBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialLabel1.Text = Convert.ToString(trackBar1.Value);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialSlider1_Click(object sender, EventArgs e)
        {
           
        }

        private void materialSlider1_onValueChanged(object sender, int newValue)
        {
            pictureBox1.Height = materialSlider1.Value;
        }
    }
}