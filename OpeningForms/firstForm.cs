namespace OpeningForms
{
    public partial class firstForm : Form
    {
        public firstForm(string value = "...")
        {
            InitializeComponent();
            displayLabel.Text = value;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            

            string text = contentTextBox.Text;

            secondForm second = new secondForm(text);

            this.Visible = false;

            second.ShowDialog();


        }

        private void firstForm_Load(object sender, EventArgs e)
        {

        }
    }
}