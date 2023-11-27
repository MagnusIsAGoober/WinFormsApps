using System.Xml.Schema;

namespace WeightCalculator
{
    public partial class WageCalculator : Form
    {
        public WageCalculator()
        {
            InitializeComponent();
        }


        private void CalcBtn_Click(object sender, EventArgs e)
        {
            if (hours.Text == "") { hours.Text = "0"; }
            if (wage.Text == "") { wage.Text = "0"; }
            if (Tax.Text == "") { Tax.Text = "0"; }

            double TotalHours = double.Parse(hours.Text);
            double TaxRate = (int.Parse(Tax.Text));

            double PayRate = double.Parse(wage.Text);
            double GrossPay = TotalHours * PayRate;
            double NetPay = GrossPay * ((100 - TaxRate) / 100);
            double TaxOwed = GrossPay - NetPay;


            MessageBox.Show(
                "$" + NetPay.ToString() + "\n You paid $" + TaxOwed + " in taxes.",
                "Your Gross Pay is",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void WageCalculator_Load(object sender, EventArgs e)
        {

        }

        private void hours_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaxRate_Click(object sender, EventArgs e)
        {

        }

        private void Tax_TextChanged(object sender, EventArgs e)
        {

        }
    }
}