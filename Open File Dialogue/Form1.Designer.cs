namespace Open_File_Dialogue
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
            pictureBox1 = new PictureBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            fileSelectorDialogue = new OpenFileDialog();
            tbContents = new MaterialSkin.Controls.MaterialTextBox2();
            fileSaverDialogue = new SaveFileDialog();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(528, 271);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.BorderStyle = BorderStyle.FixedSingle;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(600, 147);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(187, 33);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "No File Selected";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fileSelectorDialogue
            // 
            fileSelectorDialogue.FileName = "openFileDialog1";
            fileSelectorDialogue.Title = "ImageSelector";
            // 
            // tbContents
            // 
            tbContents.AnimateReadOnly = false;
            tbContents.BackgroundImageLayout = ImageLayout.None;
            tbContents.CharacterCasing = CharacterCasing.Normal;
            tbContents.Depth = 0;
            tbContents.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbContents.HideSelection = true;
            tbContents.LeadingIcon = null;
            tbContents.Location = new Point(556, 58);
            tbContents.MaxLength = 32767;
            tbContents.MouseState = MaterialSkin.MouseState.OUT;
            tbContents.Name = "tbContents";
            tbContents.PasswordChar = '\0';
            tbContents.PrefixSuffixText = null;
            tbContents.ReadOnly = false;
            tbContents.RightToLeft = RightToLeft.No;
            tbContents.SelectedText = "";
            tbContents.SelectionLength = 0;
            tbContents.SelectionStart = 0;
            tbContents.ShortcutsEnabled = true;
            tbContents.Size = new Size(268, 48);
            tbContents.TabIndex = 2;
            tbContents.TabStop = false;
            tbContents.TextAlign = HorizontalAlignment.Left;
            tbContents.TrailingIcon = null;
            tbContents.UseSystemPasswordChar = false;
            // 
            // fileSaverDialogue
            // 
            fileSaverDialogue.FileOk += fileSaverDialogue_FileOk;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(618, 221);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(64, 36);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 450);
            Controls.Add(btnSave);
            Controls.Add(tbContents);
            Controls.Add(materialLabel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private OpenFileDialog fileSelectorDialogue;
        private MaterialSkin.Controls.MaterialTextBox2 tbContents;
        private SaveFileDialog fileSaverDialogue;
        private MaterialSkin.Controls.MaterialButton btnSave;
    }
}