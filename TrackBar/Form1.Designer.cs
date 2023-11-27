namespace TrackBar
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
            trackBar1 = new System.Windows.Forms.TrackBar();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.BackColor = Color.FromArgb(255, 192, 128);
            trackBar1.Location = new Point(710, 88);
            trackBar1.Maximum = 816;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(63, 318);
            trackBar1.TabIndex = 0;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Value = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // materialLabel1
            // 
            materialLabel1.BorderStyle = BorderStyle.FixedSingle;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(633, 22);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(140, 51);
            materialLabel1.TabIndex = 1;
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            materialLabel1.Click += materialLabel1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.laughing_miles_morales;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 20);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // materialSlider1
            // 
            materialSlider1.Depth = 0;
            materialSlider1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialSlider1.Location = new Point(12, 398);
            materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSlider1.Name = "materialSlider1";
            materialSlider1.RangeMax = 489;
            materialSlider1.Size = new Size(318, 40);
            materialSlider1.TabIndex = 3;
            materialSlider1.Text = "materialSlider1";
            materialSlider1.onValueChanged += materialSlider1_onValueChanged;
            materialSlider1.Click += materialSlider1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialSlider1);
            Controls.Add(pictureBox1);
            Controls.Add(materialLabel1);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
    }
}