namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (materialTextBox1.Text != "")
            {
                if (materialListBox1.SelectedIndex != -1)
                {
                    if (materialListBox2.SelectedIndex != -1)
                    {
                        double distance = double.Parse(materialTextBox1.Text);
                        string dataType = "Inches";

                        double convertedDist = 0;

                        convertedDist = distance;

                        if (materialListBox1.SelectedIndex == 0 && materialListBox2.SelectedIndex == 0)
                        {
                            convertedDist = distance;
                            dataType = "Inches";
                        }
                        if (materialListBox1.SelectedIndex == 0 && materialListBox2.SelectedIndex == 1)
                        {
                            convertedDist = distance / 12;
                            dataType = "Feet";
                        }
                        if (materialListBox1.SelectedIndex == 0 && materialListBox2.SelectedIndex == 2)
                        {
                            convertedDist = distance / 36;
                            dataType = "Yards";
                        }
                        if (materialListBox1.SelectedIndex == 1 && materialListBox2.SelectedIndex == 1)
                        {
                            convertedDist = distance;
                            dataType = "Feet";
                        }
                        if (materialListBox1.SelectedIndex == 1 && materialListBox2.SelectedIndex == 0)
                        {
                            convertedDist = distance * 12;
                            dataType = "Inches";
                        }
                        if (materialListBox1.SelectedIndex == 1 && materialListBox2.SelectedIndex == 2)
                        {
                            convertedDist = distance / 3;
                            dataType = "Yards";
                        }
                        if (materialListBox1.SelectedIndex == 2 && materialListBox2.SelectedIndex == 2)
                        {
                            convertedDist = distance;
                            dataType = "Yards";
                        }
                        if (materialListBox1.SelectedIndex == 2 && materialListBox2.SelectedIndex == 0)
                        {
                            convertedDist = distance * 36;
                            dataType = "Inches";
                        }
                        if (materialListBox1.SelectedIndex == 2 && materialListBox2.SelectedIndex == 1)
                        {
                            convertedDist = distance * 3;
                            dataType = "Feet";
                        }

                        convertedDistanceLbl.Text = convertedDist.ToString() + " " + dataType;

                    }
                    else
                    {
                        MessageBox.Show(
                        "No [ To ] data type was chosen",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "No [ From ] data type was chosen",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(
                    "You must enter a distance to convert",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}