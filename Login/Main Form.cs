

using System.Data;
using System.Data.OleDb;

namespace Login
{

    public partial class Main_Form : Form
    {


        OleDbConnection conn =
           new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\2013.102253\Documents\Pharmacy_Records.accdb");

        OleDbCommand cmd =
            new OleDbCommand();
        public Main_Form()
        {
            InitializeComponent();
        }

        void refillGrid()
        {
            cmd.CommandText = "select * from Main";
            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }
        private void Main_Form_Load(object sender, EventArgs e)
        {
            conn.Open(); // opens a connection to the ms access file
            cmd.Connection = conn; // tells the cmd command to work in this connection
            refillGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbSearchLastName.Text);
            cmd.CommandText = "delete from Main where ID =" + id + "";
            cmd.ExecuteNonQuery();
            refillGrid();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter dataAdapter =
                new OleDbDataAdapter("select * from Main", conn);
            DataTable updatedDataTable = (DataTable)dataGridView1.DataSource;

            OleDbCommandBuilder commandBuilder =
                new OleDbCommandBuilder(dataAdapter);

            dataAdapter.Update(updatedDataTable);
            refillGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\2013.102253\Documents\Pharmacy_Records.accdb"); //Checks for final.accdb on every system.


            OleDbCommand cmd = new OleDbCommand();

            DataTable tab = (DataTable)dataGridView1.DataSource;

            DataRow row = tab.NewRow();

            int id = tab.Rows.Count + 1;
            string ln = tbLastName.Text;
            string fn = tbFirstName.Text;
            string num = tbPhone.Text;
            string res = tbaDDRESS.Text;
            string per = tbPrescriptionComments.Text;

            row[0] = id;
            row[1] = ln;
            row[2] = fn;
            row[3] = num;
            row[4] = res;
            row[5] = per;

            tab.Rows.Add(row);
            refillGrid();


        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
