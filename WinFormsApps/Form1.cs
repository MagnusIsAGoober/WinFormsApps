using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApps
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
        int TimesClicked = 0;





        private void btn1_Click(object sender, EventArgs e)
        {

            label1.Text = txtBx1.Text;

        }

        private void txtBx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btn2_Click(object sender, EventArgs e) //to upper button
        {
            // txtBx1.Text = txtBx1.Text.ToUpper();

            string word = txtBx1.Text;

            label1.Text = word.ToUpper();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            label1.Text = txtBx1.Text.ToLower();
        }

        private void txtBx1_Click(object sender, EventArgs e)
        {
            txtBx1.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show(
                "Welcome",  // the main text to be shown
                "Entrance", // the caption
                MessageBoxButtons.YesNo,    // different buttons that can be used
                MessageBoxIcon.Question,    // different icons that can be used
                MessageBoxDefaultButton.Button2,    // determines which button is highlighted by default
                MessageBoxOptions.DefaultDesktopOnly);  // determines the general look and shape of the message box
            if (result1 == DialogResult.No)
            {
                Close();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}