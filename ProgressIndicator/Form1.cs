namespace ProgressIndicator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < progressBar1.Maximum; i++)
            {
                progressBar1.Increment(1);
                //progressBar1.Width++;
                //progressBar1.Maximum++;
                
                await Task.Delay(10);

            }
            */

            backgroundWorker1.RunWorkerAsync(); // Starting the backround worker

        }

        int sum = 0;
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int num = Convert.ToInt32(materialTextBox21.Text);
            for (int i = 0; i <= num; i += 1)
            {

                sum = sum + i;
                backgroundWorker1.ReportProgress(num);
            }

            for (int i = 0; i <= 100; i += 1)
            {
                // calls the progress changed function of the background worker
                backgroundWorker1.ReportProgress(i);
                Thread.Sleep(50);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            circularProgressBar1.Value = e.ProgressPercentage;
            progressBar1.Value = e.ProgressPercentage;
            lblProgress.Text = e.ProgressPercentage.ToString() + "%";
            circularProgressBar1.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {


            DialogResult dr = MessageBox.Show("The sum is " + sum, "Dialogue Result", MessageBoxButtons.OK);

            if (dr == DialogResult.OK)
            {
                circularProgressBar1.Value = 0;
                circularProgressBar1.Text = "0%";

                progressBar1.Value = 0;
                lblProgress.Text = "";

                sum = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(); // Starting the backround worker
        }
    }
}