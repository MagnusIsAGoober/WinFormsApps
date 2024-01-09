using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpeningForms
{
    public partial class secondForm : Form
    {
        public secondForm(string value)
        {
            InitializeComponent();
            displayLabel.Text = value;
        }

        private void secondForm_Load(object sender, EventArgs e)
        {
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string text = contentTextBox.Text;

            firstForm second = new firstForm(text);


            second.ShowDialog();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "secondForm")
                    Application.OpenForms[i].Close();
            }
        }
    }
}
