namespace Leaders_of_Rome
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            ancientRomanEmperorsToolStripMenuItem = new ToolStripMenuItem();
            currentItalianPrimeMinistersToolStripMenuItem = new ToolStripMenuItem();
            lblInfo = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ancientRomanEmperorsToolStripMenuItem, currentItalianPrimeMinistersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(706, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ancientRomanEmperorsToolStripMenuItem
            // 
            ancientRomanEmperorsToolStripMenuItem.Image = Properties.Resources.emperors_ico;
            ancientRomanEmperorsToolStripMenuItem.Name = "ancientRomanEmperorsToolStripMenuItem";
            ancientRomanEmperorsToolStripMenuItem.Size = new Size(170, 20);
            ancientRomanEmperorsToolStripMenuItem.Text = "Ancient Roman Emperors";
            ancientRomanEmperorsToolStripMenuItem.Click += ancientRomanEmperorsToolStripMenuItem_Click;
            // 
            // currentItalianPrimeMinistersToolStripMenuItem
            // 
            currentItalianPrimeMinistersToolStripMenuItem.Image = Properties.Resources.pms_ico;
            currentItalianPrimeMinistersToolStripMenuItem.Name = "currentItalianPrimeMinistersToolStripMenuItem";
            currentItalianPrimeMinistersToolStripMenuItem.Size = new Size(195, 20);
            currentItalianPrimeMinistersToolStripMenuItem.Text = "Current Italian Prime ministers";
            currentItalianPrimeMinistersToolStripMenuItem.Click += currentItalianPrimeMinistersToolStripMenuItem_Click;
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.Location = new Point(0, 26);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(706, 38);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Click on the above options to view the curent and past Italian Leaders";
            lblInfo.Click += lblInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 73);
            Controls.Add(lblInfo);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Leaders of Rome";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ancientRomanEmperorsToolStripMenuItem;
        private ToolStripMenuItem currentItalianPrimeMinistersToolStripMenuItem;
        private Label lblInfo;
    }
}