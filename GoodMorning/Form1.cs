namespace GoodMorning
{
    public partial class Translate : Form
    {
        public Translate()
        {
            InitializeComponent();
        }

        private void arabicBtn_Click(object sender, EventArgs e)
        {

            lbl.Text = "صباح الخير";
        }

        private void spanishBtn_Click(object sender, EventArgs e)
        {

            lbl.Text = "Buen día";
        }

        private void germanBtn_Click(object sender, EventArgs e)
        {

            lbl.Text = "Guten Morgen";
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}