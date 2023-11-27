namespace PictureBox
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
            SalPicture = new System.Windows.Forms.PictureBox();
            SpeachBblPicture = new System.Windows.Forms.PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)SalPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpeachBblPicture).BeginInit();
            SuspendLayout();
            // 
            // SalPicture
            // 
            SalPicture.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SalPicture.BackColor = Color.FromArgb(255, 128, 128);
            SalPicture.BackgroundImage = (Image)resources.GetObject("SalPicture.BackgroundImage");
            SalPicture.BackgroundImageLayout = ImageLayout.Stretch;
            SalPicture.Image = (Image)resources.GetObject("SalPicture.Image");
            SalPicture.Location = new Point(12, 0);
            SalPicture.Name = "SalPicture";
            SalPicture.Size = new Size(768, 450);
            SalPicture.TabIndex = 0;
            SalPicture.TabStop = false;
            SalPicture.Click += SalPicture_Click;
            // 
            // SpeachBblPicture
            // 
            SpeachBblPicture.BorderStyle = BorderStyle.FixedSingle;
            SpeachBblPicture.Image = (Image)resources.GetObject("SpeachBblPicture.Image");
            SpeachBblPicture.Location = new Point(473, 74);
            SpeachBblPicture.Name = "SpeachBblPicture";
            SpeachBblPicture.Size = new Size(268, 150);
            SpeachBblPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            SpeachBblPicture.TabIndex = 1;
            SpeachBblPicture.TabStop = false;
            SpeachBblPicture.Visible = false;
            SpeachBblPicture.Click += SpeachBblPicture_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(517, 131);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 2;
            label1.Text = "im tonights biggest loser...";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 450);
            Controls.Add(label1);
            Controls.Add(SpeachBblPicture);
            Controls.Add(SalPicture);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)SalPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpeachBblPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox SalPicture;
        private System.Windows.Forms.PictureBox SpeachBblPicture;
        private Label label1;
    }
}