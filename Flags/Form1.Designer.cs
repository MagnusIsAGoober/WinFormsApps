namespace Flags
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
            FinlandPictureBox = new PictureBox();
            FrancePictureBox = new PictureBox();
            GermanyPictureBox = new PictureBox();
            countryLabel = new Label();
            instructionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)FinlandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrancePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GermanyPictureBox).BeginInit();
            SuspendLayout();
            // 
            // FinlandPictureBox
            // 
            FinlandPictureBox.BorderStyle = BorderStyle.FixedSingle;
            FinlandPictureBox.Image = Properties.Resources.Finland;
            FinlandPictureBox.Location = new Point(25, 65);
            FinlandPictureBox.Name = "FinlandPictureBox";
            FinlandPictureBox.Size = new Size(186, 116);
            FinlandPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            FinlandPictureBox.TabIndex = 0;
            FinlandPictureBox.TabStop = false;
            FinlandPictureBox.Click += FinlandPictureBox_Click;
            // 
            // FrancePictureBox
            // 
            FrancePictureBox.BorderStyle = BorderStyle.FixedSingle;
            FrancePictureBox.Image = Properties.Resources.France;
            FrancePictureBox.Location = new Point(234, 65);
            FrancePictureBox.Name = "FrancePictureBox";
            FrancePictureBox.Size = new Size(172, 116);
            FrancePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            FrancePictureBox.TabIndex = 1;
            FrancePictureBox.TabStop = false;
            FrancePictureBox.Click += FrancePictureBox_Click;
            // 
            // GermanyPictureBox
            // 
            GermanyPictureBox.BorderStyle = BorderStyle.FixedSingle;
            GermanyPictureBox.Image = Properties.Resources.Germany;
            GermanyPictureBox.Location = new Point(428, 65);
            GermanyPictureBox.Name = "GermanyPictureBox";
            GermanyPictureBox.Size = new Size(189, 116);
            GermanyPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            GermanyPictureBox.TabIndex = 2;
            GermanyPictureBox.TabStop = false;
            GermanyPictureBox.Click += GermanyPictureBox_Click;
            // 
            // countryLabel
            // 
            countryLabel.BorderStyle = BorderStyle.FixedSingle;
            countryLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            countryLabel.Location = new Point(234, 216);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(172, 38);
            countryLabel.TabIndex = 3;
            countryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // instructionLabel
            // 
            instructionLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            instructionLabel.Location = new Point(107, 9);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(425, 45);
            instructionLabel.TabIndex = 4;
            instructionLabel.Text = "Click a flag to see the name of the country";
            instructionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 294);
            Controls.Add(instructionLabel);
            Controls.Add(countryLabel);
            Controls.Add(GermanyPictureBox);
            Controls.Add(FrancePictureBox);
            Controls.Add(FinlandPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)FinlandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrancePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)GermanyPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox FinlandPictureBox;
        private PictureBox FrancePictureBox;
        private PictureBox GermanyPictureBox;
        private Label countryLabel;
        private Label instructionLabel;
    }
}