namespace Text_Editor_App
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
            tbFileTitle = new MaterialSkin.Controls.MaterialTextBox();
            lblFileTitle = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnOpen = new MaterialSkin.Controls.MaterialFloatingActionButton();
            btnSave = new MaterialSkin.Controls.MaterialFloatingActionButton();
            btnClear = new MaterialSkin.Controls.MaterialFloatingActionButton();
            btnExit = new MaterialSkin.Controls.MaterialFloatingActionButton();
            tbFileContents = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            fileSaverDialogue = new SaveFileDialog();
            fileSelectorDialogue = new OpenFileDialog();
            SuspendLayout();
            // 
            // tbFileTitle
            // 
            tbFileTitle.AnimateReadOnly = false;
            tbFileTitle.BorderStyle = BorderStyle.None;
            tbFileTitle.Depth = 0;
            tbFileTitle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbFileTitle.ForeColor = SystemColors.MenuHighlight;
            tbFileTitle.Hint = "Enter file title";
            tbFileTitle.LeadingIcon = null;
            tbFileTitle.Location = new Point(135, 24);
            tbFileTitle.MaxLength = 50;
            tbFileTitle.MouseState = MaterialSkin.MouseState.OUT;
            tbFileTitle.Multiline = false;
            tbFileTitle.Name = "tbFileTitle";
            tbFileTitle.Size = new Size(239, 50);
            tbFileTitle.TabIndex = 1;
            tbFileTitle.Text = "";
            tbFileTitle.TrailingIcon = null;
            tbFileTitle.UseAccent = false;
            // 
            // lblFileTitle
            // 
            lblFileTitle.AutoSize = true;
            lblFileTitle.Depth = 0;
            lblFileTitle.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFileTitle.Location = new Point(26, 24);
            lblFileTitle.MouseState = MaterialSkin.MouseState.HOVER;
            lblFileTitle.Name = "lblFileTitle";
            lblFileTitle.Size = new Size(61, 19);
            lblFileTitle.TabIndex = 2;
            lblFileTitle.Text = "File Title";
            lblFileTitle.Click += lblFileTitle_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(26, 108);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(93, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "File Contents";
            // 
            // btnOpen
            // 
            btnOpen.Depth = 0;
            btnOpen.Icon = Properties.Resources.open_ico;
            btnOpen.Location = new Point(96, 336);
            btnOpen.MouseState = MaterialSkin.MouseState.HOVER;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(56, 56);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "materialFloatingActionButton1";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.Depth = 0;
            btnSave.Icon = (Image)resources.GetObject("btnSave.Icon");
            btnSave.Location = new Point(171, 336);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(56, 56);
            btnSave.TabIndex = 5;
            btnSave.Text = "materialFloatingActionButton1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Depth = 0;
            btnClear.Icon = (Image)resources.GetObject("btnClear.Icon");
            btnClear.Location = new Point(246, 336);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(56, 56);
            btnClear.TabIndex = 6;
            btnClear.Text = "materialFloatingActionButton1";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Depth = 0;
            btnExit.Icon = (Image)resources.GetObject("btnExit.Icon");
            btnExit.Location = new Point(318, 336);
            btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(56, 56);
            btnExit.TabIndex = 7;
            btnExit.Text = "materialFloatingActionButton1";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tbFileContents
            // 
            tbFileContents.AnimateReadOnly = false;
            tbFileContents.BackgroundImageLayout = ImageLayout.None;
            tbFileContents.CharacterCasing = CharacterCasing.Normal;
            tbFileContents.Depth = 0;
            tbFileContents.HideSelection = true;
            tbFileContents.Hint = "Enter text file contents";
            tbFileContents.Location = new Point(135, 108);
            tbFileContents.MaxLength = 32767;
            tbFileContents.MouseState = MaterialSkin.MouseState.OUT;
            tbFileContents.Name = "tbFileContents";
            tbFileContents.PasswordChar = '\0';
            tbFileContents.ReadOnly = false;
            tbFileContents.ScrollBars = ScrollBars.Vertical;
            tbFileContents.SelectedText = "";
            tbFileContents.SelectionLength = 0;
            tbFileContents.SelectionStart = 0;
            tbFileContents.ShortcutsEnabled = true;
            tbFileContents.Size = new Size(239, 222);
            tbFileContents.TabIndex = 8;
            tbFileContents.TabStop = false;
            tbFileContents.TextAlign = HorizontalAlignment.Left;
            tbFileContents.UseSystemPasswordChar = false;
            // 
            // fileSelectorDialogue
            // 
            fileSelectorDialogue.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 408);
            Controls.Add(tbFileContents);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(materialLabel2);
            Controls.Add(lblFileTitle);
            Controls.Add(tbFileTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Text Writer and Reader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox tbFileTitle;
        private MaterialSkin.Controls.MaterialLabel lblFileTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnOpen;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnSave;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnClear;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnExit;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tbFileContents;
        private SaveFileDialog fileSaverDialogue;
        private OpenFileDialog fileSelectorDialogue;
    }
}