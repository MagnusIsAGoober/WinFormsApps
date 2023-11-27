namespace GoodMorning
{
    partial class Translate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Translate));
            arabicBtn = new MaterialSkin.Controls.MaterialButton();
            spanishBtn = new MaterialSkin.Controls.MaterialButton();
            germanBtn = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            lbl = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // arabicBtn
            // 
            arabicBtn.AutoSize = false;
            arabicBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            arabicBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            arabicBtn.Depth = 0;
            arabicBtn.HighEmphasis = true;
            arabicBtn.Icon = null;
            arabicBtn.Location = new Point(21, 137);
            arabicBtn.Margin = new Padding(4, 6, 4, 6);
            arabicBtn.MouseState = MaterialSkin.MouseState.HOVER;
            arabicBtn.Name = "arabicBtn";
            arabicBtn.NoAccentTextColor = Color.Empty;
            arabicBtn.Size = new Size(125, 54);
            arabicBtn.TabIndex = 1;
            arabicBtn.Text = "Arabic";
            arabicBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            arabicBtn.UseAccentColor = false;
            arabicBtn.UseVisualStyleBackColor = true;
            arabicBtn.Click += arabicBtn_Click;
            // 
            // spanishBtn
            // 
            spanishBtn.AutoSize = false;
            spanishBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            spanishBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            spanishBtn.Depth = 0;
            spanishBtn.HighEmphasis = true;
            spanishBtn.Icon = null;
            spanishBtn.Location = new Point(154, 137);
            spanishBtn.Margin = new Padding(4, 6, 4, 6);
            spanishBtn.MouseState = MaterialSkin.MouseState.HOVER;
            spanishBtn.Name = "spanishBtn";
            spanishBtn.NoAccentTextColor = Color.Empty;
            spanishBtn.Size = new Size(125, 54);
            spanishBtn.TabIndex = 2;
            spanishBtn.Text = "Spanish";
            spanishBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            spanishBtn.UseAccentColor = false;
            spanishBtn.UseVisualStyleBackColor = true;
            spanishBtn.Click += spanishBtn_Click;
            // 
            // germanBtn
            // 
            germanBtn.AutoSize = false;
            germanBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            germanBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            germanBtn.Depth = 0;
            germanBtn.HighEmphasis = true;
            germanBtn.Icon = null;
            germanBtn.Location = new Point(287, 137);
            germanBtn.Margin = new Padding(4, 6, 4, 6);
            germanBtn.MouseState = MaterialSkin.MouseState.HOVER;
            germanBtn.Name = "germanBtn";
            germanBtn.NoAccentTextColor = Color.Empty;
            germanBtn.Size = new Size(125, 54);
            germanBtn.TabIndex = 3;
            germanBtn.Text = "German";
            germanBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            germanBtn.UseAccentColor = false;
            germanBtn.UseVisualStyleBackColor = true;
            germanBtn.Click += germanBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(52, 19);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(328, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Select a language and I will say Good Marning";
            materialLabel1.Click += materialLabel1_Click;
            // 
            // lbl
            // 
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.Depth = 0;
            lbl.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl.Location = new Point(52, 74);
            lbl.MouseState = MaterialSkin.MouseState.HOVER;
            lbl.Name = "lbl";
            lbl.Size = new Size(328, 45);
            lbl.TabIndex = 5;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Translate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 221);
            Controls.Add(lbl);
            Controls.Add(materialLabel1);
            Controls.Add(germanBtn);
            Controls.Add(spanishBtn);
            Controls.Add(arabicBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Translate";
            Text = "Language Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton arabicBtn;
        private MaterialSkin.Controls.MaterialButton spanishBtn;
        private MaterialSkin.Controls.MaterialButton germanBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl;
    }
}