using System.Data;
using System.Data.OleDb;
using static System.Net.Mime.MediaTypeNames;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn =
           new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\2013.102253\Documents\Pharmacy_Records.accdb");

        private void materialButton1_Click(object sender, EventArgs e)
        {
            String password, username;

            password = tbPassword.Text;
            username = cbUsername.Text;
            try
            {
                String query = "SELECT * FROM Users WHERE username = '" + cbUsername.Text + "' AND password = '" + tbPassword.Text + "'";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    password = tbPassword.Text;

                    // load main page

                    Main_Form main = new Main_Form();

                    this.Visible = false;

                    main.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Password Incorrect");
                    tbPassword.Clear();

                    tbPassword.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection conn =
           new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\2013.102253\Documents\Pharmacy_Records.accdb");


            OleDbDataAdapter dataAdapter =
                new OleDbDataAdapter("select * from Users", conn);

            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbUsername.Items.Add(dt.Rows[i]["username"]);
            }

        }
    }
}