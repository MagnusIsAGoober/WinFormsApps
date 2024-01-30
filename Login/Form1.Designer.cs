namespace Login
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
            cbUsername = new MaterialSkin.Controls.MaterialComboBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            tbPassword = new MaterialSkin.Controls.MaterialTextBox2();
            SuspendLayout();
            // 
            // cbUsername
            // 
            cbUsername.AutoResize = false;
            cbUsername.BackColor = Color.FromArgb(255, 255, 255);
            cbUsername.Depth = 0;
            cbUsername.DrawMode = DrawMode.OwnerDrawVariable;
            cbUsername.DropDownHeight = 174;
            cbUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsername.DropDownWidth = 121;
            cbUsername.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbUsername.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbUsername.FormattingEnabled = true;
            cbUsername.Hint = "Username";
            cbUsername.IntegralHeight = false;
            cbUsername.ItemHeight = 43;
            cbUsername.Location = new Point(49, 12);
            cbUsername.MaxDropDownItems = 4;
            cbUsername.MouseState = MaterialSkin.MouseState.OUT;
            cbUsername.Name = "cbUsername";
            cbUsername.Size = new Size(246, 49);
            cbUsername.StartIndex = 0;
            cbUsername.TabIndex = 0;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(49, 144);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(75, 36);
            materialButton1.TabIndex = 2;
            materialButton1.Text = "Login";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // tbPassword
            // 
            tbPassword.AnimateReadOnly = false;
            tbPassword.BackgroundImageLayout = ImageLayout.None;
            tbPassword.CharacterCasing = CharacterCasing.Normal;
            tbPassword.Depth = 0;
            tbPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPassword.HideSelection = true;
            tbPassword.Hint = "Password";
            tbPassword.LeadingIcon = null;
            tbPassword.Location = new Point(49, 78);
            tbPassword.MaxLength = 32767;
            tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '●';
            tbPassword.PrefixSuffixText = null;
            tbPassword.ReadOnly = false;
            tbPassword.RightToLeft = RightToLeft.No;
            tbPassword.SelectedText = "";
            tbPassword.SelectionLength = 0;
            tbPassword.SelectionStart = 0;
            tbPassword.ShortcutsEnabled = true;
            tbPassword.Size = new Size(246, 48);
            tbPassword.TabIndex = 3;
            tbPassword.TabStop = false;
            tbPassword.TextAlign = HorizontalAlignment.Left;
            tbPassword.TrailingIcon = Properties.Resources._lock;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 195);
            Controls.Add(tbPassword);
            Controls.Add(materialButton1);
            Controls.Add(cbUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Login";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbUsername;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 tbPassword;
    }
}