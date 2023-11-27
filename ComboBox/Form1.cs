using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = comboBox1.Text;
            if (value == "") { value = "Not Chosen"; }
            MessageBox.Show(value);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Selected Index: " + comboBox1.SelectedIndex.ToString();
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialLabel1.Text = "Selected Index: " + materialComboBox1.SelectedIndex.ToString();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string value = materialComboBox1.Text;
            if (value == "") { value = "Not Chosen"; }
            MessageBox.Show(value);
        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            materialTextBox1.Text = materialListBox1.SelectedIndex.ToString();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(materialTextBox1.Text);
            int max = materialListBox1.Items.Count;
            
            if (number > -1 && number < max)
            {
                materialListBox1.Items.RemoveAt(materialListBox1.SelectedIndex);
                listBox1.Items.RemoveAt(materialListBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show(
                    "The value was not within the parameters", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialTextBox1.Text = listBox1.SelectedIndex.ToString();
        }
    }
}