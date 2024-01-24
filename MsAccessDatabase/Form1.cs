//using MySql.Data.MySqlClient;
//using System.Data;
//using System.Data.OleDb;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MsAccessDatabase
{
    public partial class Form1 : Form
    {

        OleDbConnection conn =
            new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\2013.102253\Documents\Student_Scores.accdb");

        OleDbCommand cmd =
            new OleDbCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        void refillGrid()
        {
            cmd.CommandText = "select * from Scores";
            OleDbDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open(); // opens a connection to the ms access file
            cmd.Connection = conn; // tells the cmd command to work in this connection
            refillGrid();
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(materialTextBox3.Text);
            cmd.CommandText = "delete from Scores where ID =" + id + "";
            cmd.ExecuteNonQuery();
            refillGrid();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter dataAdapter = 
                new OleDbDataAdapter("select * from Scores", conn);
            DataTable updatedDataTable = (DataTable)dataGridView1.DataSource;

            OleDbCommandBuilder commandBuilder =
                new OleDbCommandBuilder(dataAdapter);

            dataAdapter.Update(updatedDataTable);
            refillGrid();
        }
    }
}