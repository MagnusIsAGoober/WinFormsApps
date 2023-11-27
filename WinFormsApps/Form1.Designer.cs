namespace WinFormsApps
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btn1 = new Button();
            label1 = new Label();
            txtBx1 = new TextBox();
            btn2 = new Button();
            btn3 = new Button();
            ExitBtn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(255, 192, 128);
            btn1.BackgroundImageLayout = ImageLayout.Center;
            btn1.Location = new Point(259, 156);
            btn1.Name = "btn1";
            btn1.Size = new Size(217, 79);
            btn1.TabIndex = 0;
            btn1.Text = "Click Me ;)";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Rockwell Extra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 111);
            label1.Name = "label1";
            label1.Size = new Size(574, 30);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // txtBx1
            // 
            txtBx1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txtBx1.Location = new Point(83, 33);
            txtBx1.Name = "txtBx1";
            txtBx1.Size = new Size(574, 61);
            txtBx1.TabIndex = 2;
            txtBx1.Text = "[Type Here]";
            txtBx1.TextAlign = HorizontalAlignment.Center;
            txtBx1.Click += txtBx1_Click;
            txtBx1.TextChanged += txtBx1_TextChanged;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightCoral;
            btn2.BackgroundImageLayout = ImageLayout.Center;
            btn2.Location = new Point(259, 326);
            btn2.Name = "btn2";
            btn2.Size = new Size(217, 79);
            btn2.TabIndex = 3;
            btn2.Text = "To Upper";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ActiveCaption;
            btn3.BackgroundImageLayout = ImageLayout.Center;
            btn3.Location = new Point(259, 241);
            btn3.Name = "btn3";
            btn3.Size = new Size(217, 79);
            btn3.TabIndex = 5;
            btn3.Text = "To Lower ";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.BackgroundImage = (Image)resources.GetObject("ExitBtn.BackgroundImage");
            ExitBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.ForeColor = Color.Red;
            ExitBtn.ImageAlign = ContentAlignment.MiddleRight;
            ExitBtn.Location = new Point(679, 12);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.RightToLeft = RightToLeft.No;
            ExitBtn.Size = new Size(34, 34);
            ExitBtn.TabIndex = 6;
            ExitBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            ExitBtn.UseMnemonic = false;
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExtBtn_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(679, 48);
            label2.Name = "label2";
            label2.Size = new Size(34, 23);
            label2.TabIndex = 7;
            label2.Text = "Exit";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(725, 450);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(ExitBtn);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(txtBx1);
            Controls.Add(label1);
            Controls.Add(btn1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "MainForm";
            TopMost = true;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label label1;
        private TextBox txtBx1;
        private Button btn2;
        private Button btn3;
        private Button ExitBtn;
        private Label label2;
    }
}