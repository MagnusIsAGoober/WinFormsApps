using System.Media;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer sound = new SoundPlayer(@"C:\Users\2013.102253\Downloads\Sal.wav");

        private void SpeachBblPicture_Click(object sender, EventArgs e)
        {

        }

        private void SalPicture_Click(object sender, EventArgs e)
        {
            if (SpeachBblPicture.Visible == true)
            {
                SpeachBblPicture.Visible = false;
                label1.Visible = false;
                sound.Stop();
            }

            else if (SpeachBblPicture.Visible == false)
            {
                SpeachBblPicture.Visible = true;
                label1.Visible = true;
                sound.Play();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}