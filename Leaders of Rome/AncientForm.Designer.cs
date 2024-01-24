namespace Leaders_of_Rome
{
    partial class AncientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AncientForm));
            toolTip1 = new ToolTip(components);
            pbAugustus = new PictureBox();
            pbTiberius = new PictureBox();
            pbCalaudius = new PictureBox();
            pbCaligula = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbAugustus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTiberius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCalaudius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCaligula).BeginInit();
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Roman Emperors";
            // 
            // pbAugustus
            // 
            pbAugustus.BackgroundImage = Properties.Resources.augustus;
            pbAugustus.BackgroundImageLayout = ImageLayout.Stretch;
            pbAugustus.BorderStyle = BorderStyle.FixedSingle;
            pbAugustus.Location = new Point(12, 9);
            pbAugustus.Name = "pbAugustus";
            pbAugustus.Size = new Size(148, 211);
            pbAugustus.TabIndex = 1;
            pbAugustus.TabStop = false;
            pbAugustus.Click += pbAugustus_Click;
            // 
            // pbTiberius
            // 
            pbTiberius.BackgroundImage = Properties.Resources.tiberius;
            pbTiberius.BackgroundImageLayout = ImageLayout.Stretch;
            pbTiberius.BorderStyle = BorderStyle.FixedSingle;
            pbTiberius.Location = new Point(185, 9);
            pbTiberius.Name = "pbTiberius";
            pbTiberius.Size = new Size(148, 211);
            pbTiberius.TabIndex = 2;
            pbTiberius.TabStop = false;
            // 
            // pbCalaudius
            // 
            pbCalaudius.BackgroundImage = Properties.Resources.calaudius;
            pbCalaudius.BackgroundImageLayout = ImageLayout.Stretch;
            pbCalaudius.BorderStyle = BorderStyle.FixedSingle;
            pbCalaudius.Location = new Point(358, 9);
            pbCalaudius.Name = "pbCalaudius";
            pbCalaudius.Size = new Size(148, 211);
            pbCalaudius.TabIndex = 3;
            pbCalaudius.TabStop = false;
            // 
            // pbCaligula
            // 
            pbCaligula.BackgroundImage = Properties.Resources.caligula;
            pbCaligula.BackgroundImageLayout = ImageLayout.Stretch;
            pbCaligula.BorderStyle = BorderStyle.FixedSingle;
            pbCaligula.Location = new Point(532, 9);
            pbCaligula.Name = "pbCaligula";
            pbCaligula.Size = new Size(148, 211);
            pbCaligula.TabIndex = 4;
            pbCaligula.TabStop = false;
            // 
            // AncientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 232);
            Controls.Add(pbCaligula);
            Controls.Add(pbCalaudius);
            Controls.Add(pbTiberius);
            Controls.Add(pbAugustus);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AncientForm";
            Text = "AncientForm";
            Load += AncientForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbAugustus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTiberius).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCalaudius).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCaligula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private PictureBox pbAugustus;
        private PictureBox pbTiberius;
        private PictureBox pbCalaudius;
        private PictureBox pbCaligula;
    }
}