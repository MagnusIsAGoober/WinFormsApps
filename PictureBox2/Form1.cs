using PictureBox2.Properties;
using System.Media;

namespace PictureBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool isItHeads = true;
        SoundPlayer sound = new SoundPlayer(@"C:\Users\2013.102253\Downloads\poppinBottles.wav");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sound.Play();
        }

        private void coinImg_Click(object sender, EventArgs e)
        {
            if (isItHeads)
            {
                coinImg.Image = Resources.Tails;
                isItHeads = false;
            }

            else
            {
                coinImg.Image = Resources.Heads;
                isItHeads = true;


            }
        }
    }
}