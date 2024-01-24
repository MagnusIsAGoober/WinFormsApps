namespace Leaders_of_Rome
{
    partial class PMForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMForm));
            pbSilvioBerlusconi = new PictureBox();
            toolTip1 = new ToolTip(components);
            pbLambertoDini = new PictureBox();
            pbRomanoProdi = new PictureBox();
            pbMassimoDAlema = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSilvioBerlusconi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLambertoDini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRomanoProdi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMassimoDAlema).BeginInit();
            SuspendLayout();
            // 
            // pbSilvioBerlusconi
            // 
            pbSilvioBerlusconi.BackgroundImage = Properties.Resources.Silvio_Berlusconi;
            pbSilvioBerlusconi.BackgroundImageLayout = ImageLayout.Stretch;
            pbSilvioBerlusconi.BorderStyle = BorderStyle.FixedSingle;
            pbSilvioBerlusconi.Location = new Point(12, 12);
            pbSilvioBerlusconi.Name = "pbSilvioBerlusconi";
            pbSilvioBerlusconi.Size = new Size(145, 189);
            pbSilvioBerlusconi.TabIndex = 0;
            pbSilvioBerlusconi.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Prime ministers";
            toolTip1.Popup += toolTip1_Popup;
            // 
            // pbLambertoDini
            // 
            pbLambertoDini.BackgroundImage = Properties.Resources.Lamberto_Dini;
            pbLambertoDini.BackgroundImageLayout = ImageLayout.Stretch;
            pbLambertoDini.BorderStyle = BorderStyle.FixedSingle;
            pbLambertoDini.Location = new Point(176, 12);
            pbLambertoDini.Name = "pbLambertoDini";
            pbLambertoDini.Size = new Size(145, 189);
            pbLambertoDini.TabIndex = 1;
            pbLambertoDini.TabStop = false;
            // 
            // pbRomanoProdi
            // 
            pbRomanoProdi.BackgroundImage = Properties.Resources.Romano_Prodi;
            pbRomanoProdi.BackgroundImageLayout = ImageLayout.Stretch;
            pbRomanoProdi.BorderStyle = BorderStyle.FixedSingle;
            pbRomanoProdi.Location = new Point(343, 12);
            pbRomanoProdi.Name = "pbRomanoProdi";
            pbRomanoProdi.Size = new Size(145, 189);
            pbRomanoProdi.TabIndex = 2;
            pbRomanoProdi.TabStop = false;
            // 
            // pbMassimoDAlema
            // 
            pbMassimoDAlema.BackgroundImage = Properties.Resources.Massimo_D_Alema;
            pbMassimoDAlema.BackgroundImageLayout = ImageLayout.Stretch;
            pbMassimoDAlema.BorderStyle = BorderStyle.FixedSingle;
            pbMassimoDAlema.Location = new Point(506, 12);
            pbMassimoDAlema.Name = "pbMassimoDAlema";
            pbMassimoDAlema.Size = new Size(145, 189);
            pbMassimoDAlema.TabIndex = 3;
            pbMassimoDAlema.TabStop = false;
            // 
            // PMForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 211);
            Controls.Add(pbMassimoDAlema);
            Controls.Add(pbRomanoProdi);
            Controls.Add(pbLambertoDini);
            Controls.Add(pbSilvioBerlusconi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PMForm";
            Text = "PMForm";
            Load += PMForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbSilvioBerlusconi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLambertoDini).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRomanoProdi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMassimoDAlema).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbSilvioBerlusconi;
        private ToolTip toolTip1;
        private PictureBox pbLambertoDini;
        private PictureBox pbRomanoProdi;
        private PictureBox pbMassimoDAlema;
    }
}