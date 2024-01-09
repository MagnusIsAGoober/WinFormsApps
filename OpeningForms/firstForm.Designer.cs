namespace OpeningForms
{
    partial class firstForm
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
            contentTextBox = new MaterialSkin.Controls.MaterialTextBox();
            Button = new MaterialSkin.Controls.MaterialButton();
            displayLabel = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contentTextBox
            // 
            contentTextBox.AnimateReadOnly = false;
            contentTextBox.BorderStyle = BorderStyle.None;
            contentTextBox.Depth = 0;
            contentTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            contentTextBox.LeadingIcon = null;
            contentTextBox.Location = new Point(38, 277);
            contentTextBox.MaxLength = 50;
            contentTextBox.MouseState = MaterialSkin.MouseState.OUT;
            contentTextBox.Multiline = false;
            contentTextBox.Name = "contentTextBox";
            contentTextBox.Size = new Size(201, 50);
            contentTextBox.TabIndex = 1;
            contentTextBox.Text = "";
            contentTextBox.TrailingIcon = null;
            // 
            // Button
            // 
            Button.AutoSize = false;
            Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Button.Depth = 0;
            Button.HighEmphasis = true;
            Button.Icon = null;
            Button.Location = new Point(60, 348);
            Button.Margin = new Padding(4, 6, 4, 6);
            Button.MouseState = MaterialSkin.MouseState.HOVER;
            Button.Name = "Button";
            Button.NoAccentTextColor = Color.Empty;
            Button.Size = new Size(158, 36);
            Button.TabIndex = 2;
            Button.Text = "Send";
            Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Button.UseAccentColor = false;
            Button.UseVisualStyleBackColor = true;
            Button.Click += materialButton1_Click;
            // 
            // displayLabel
            // 
            displayLabel.BorderStyle = BorderStyle.FixedSingle;
            displayLabel.Depth = 0;
            displayLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            displayLabel.Location = new Point(28, 30);
            displayLabel.MouseState = MaterialSkin.MouseState.HOVER;
            displayLabel.Name = "displayLabel";
            displayLabel.Size = new Size(226, 211);
            displayLabel.TabIndex = 3;
            displayLabel.Text = "...";
            displayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.kisspng_android_logo_computer_icons_svg_5ac07661354e92_9646832915225626572184;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(169, 393);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // firstForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(281, 450);
            Controls.Add(pictureBox1);
            Controls.Add(displayLabel);
            Controls.Add(Button);
            Controls.Add(contentTextBox);
            Name = "firstForm";
            Text = "Form1";
            Load += firstForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox contentTextBox;
        private MaterialSkin.Controls.MaterialButton Button;
        private MaterialSkin.Controls.MaterialLabel displayLabel;
        private PictureBox pictureBox1;
    }
}