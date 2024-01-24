using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leaders_of_Rome
{
    public partial class PMForm : Form
    {
        public PMForm()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void PMForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbSilvioBerlusconi, "Silvio Berlusconi");
            toolTip1.SetToolTip(pbLambertoDini, "Lamberto Dini");
            toolTip1.SetToolTip(pbRomanoProdi, "Romano Prodi");
            toolTip1.SetToolTip(pbMassimoDAlema, "Massimo D'Alema");
        }
    }
}
