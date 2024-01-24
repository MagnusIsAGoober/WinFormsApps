namespace Leaders_of_Rome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void currentItalianPrimeMinistersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMForm second = new PMForm();

            second.ShowDialog();

        }

        private void ancientRomanEmperorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AncientForm second = new AncientForm();

            second.ShowDialog();

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}