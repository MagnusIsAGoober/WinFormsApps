namespace Labels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void changeText(Label objLabel, String allignment)
        {
            if (objLabel.Text != "") { objLabel.Text = ""; }
            else
            {
                objLabel.Text = allignment;
            }
        }
        private void topLeftLabel_Click(object sender, EventArgs e)
        {
            changeText(topLeftLabel, "Top left");
        }

        private void topMiddleLabel_Click(object sender, EventArgs e)
        {
            changeText(topMiddleLabel, "Top left");
        }

        private void topRightLabel_Click(object sender, EventArgs e)
        {
            changeText(topRightLabel, "Top left");
        }

        private void middleLeftLabel_Click(object sender, EventArgs e)
        {
            changeText(middleLeftLabel, "Top left");
        }

        private void middleLable_Click(object sender, EventArgs e)
        {
            changeText(middleLable, "Top left");
        }

        private void middleRightLabel_Click(object sender, EventArgs e)
        {
            changeText(middleRightLabel, "Top left");
        }


        private void bottomleftLabel_Click(object sender, EventArgs e)
        {
            changeText(bottomLeftLabel, "Top left");
        }

        private void BottomMiddleLabel_Click(object sender, EventArgs e)
        {
            changeText(BottomMiddleLabel, "Top left");
        }

        private void bottomRightLabel_Click(object sender, EventArgs e)
        {
            changeText(bottomRightLabel, "Top left");
        }
    }
}