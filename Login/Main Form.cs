

using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;

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


            string ln = tbLastName.Text;
            string fn = tbFirstName.Text;
            string phone = tbPhone.Text;
            string res = tbAddress.Text;
            string presc = tbPrescriptionComments.Text;



            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Main (lname, fname, phone, address, residence, prescription)" + " VALUES ('" + ln + "','" + fn + "','" + res + "','" + presc + "','" + phone + "')";
            cmd.Parameters.AddWithValue("@fn", tbFirstName.Text);
            cmd.Parameters.AddWithValue("@ln", tbLastName.Text);
            cmd.Parameters.AddWithValue("@address", tbAddress.Text);
            cmd.Parameters.AddWithValue("@presc", tbPrescriptionComments.Text);
            cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();











            //MessageBox.Show("Added Row");
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf|*.pdf)";
                save.FileName = "Result";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch(Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                        }
                        catch(Exception ex )
                        {

                        }
                    }
                }
            }
        }
    }
}
