namespace OpeningForms
{
    partial class secondForm
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
            displayLabel = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            contentTextBox = new MaterialSkin.Controls.MaterialTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // displayLabel
            // 
            displayLabel.BackColor = Color.White;
            displayLabel.BorderStyle = BorderStyle.FixedSingle;
            displayLabel.Depth = 0;
            displayLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            displayLabel.Location = new Point(26, 28);
            displayLabel.MouseState = MaterialSkin.MouseState.HOVER;
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(232, 215);
            displayLabel.TabIndex = 0;
            displayLabel.Text = "...";
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(61, 349);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(155, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Send";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // contentTextBox
            // 
            contentTextBox.AnimateReadOnly = false;
            contentTextBox.BackColor = Color.White;
            contentTextBox.BorderStyle = BorderStyle.None;
            contentTextBox.Depth = 0;
            contentTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            contentTextBox.LeadingIcon = null;
            contentTextBox.Location = new Point(42, 277);
            contentTextBox.MaxLength = 50;
            contentTextBox.MouseState = MaterialSkin.MouseState.OUT;
            contentTextBox.Multiline = false;
            contentTextBox.Name = "contentTextBox";
            contentTextBox.Size = new Size(196, 50);
            contentTextBox.TabIndex = 4;
            contentTextBox.Text = "";
            contentTextBox.TrailingIcon = null;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._5a3a2721ec4cc1_15350861151376054596794637;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(171, 394);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // secondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(283, 450);
            Controls.Add(pictureBox1);
            Controls.Add(contentTextBox);
            Controls.Add(materialButton1);
            Controls.Add(displayLabel);
            Name = "secondForm";
            Text = "secondForm";
            Load += secondForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel displayLabel;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox contentTextBox;
        private PictureBox pictureBox1;
    }
}