﻿using System;
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
    public partial class AncientForm : Form
    {
        public AncientForm()
        {
            InitializeComponent();
        }

        private void AncientForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbAugustus, "Augustus");
            toolTip1.SetToolTip(pbTiberius, "Tiberius");
            toolTip1.SetToolTip(pbCalaudius, "Calaudius");
            toolTip1.SetToolTip(pbCaligula, "Caligula");
        }

        private void pbAugustus_Click(object sender, EventArgs e)
        {

        }
    }
}
