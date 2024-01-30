namespace Login
{
    partial class Main_Form
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
            groupBox1 = new GroupBox();
            materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            tbPrescriptionComments = new MaterialSkin.Controls.MaterialTextBox();
            tbAddress = new MaterialSkin.Controls.MaterialTextBox();
            tbPhone = new MaterialSkin.Controls.MaterialTextBox();
            tbLastName = new MaterialSkin.Controls.MaterialTextBox();
            tbFirstName = new MaterialSkin.Controls.MaterialTextBox();
            tbSearchLastName = new MaterialSkin.Controls.MaterialTextBox2();
            dataGridView1 = new DataGridView();
            btnUpdate = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            btnDelete = new MaterialSkin.Controls.MaterialFloatingActionButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialFloatingActionButton2);
            groupBox1.Controls.Add(tbPrescriptionComments);
            groupBox1.Controls.Add(tbAddress);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(tbLastName);
            groupBox1.Controls.Add(tbFirstName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 248);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adding A Patient";
            // 
            // materialFloatingActionButton2
            // 
            materialFloatingActionButton2.Depth = 0;
            materialFloatingActionButton2.Icon = Properties.Resources.insert;
            materialFloatingActionButton2.Location = new Point(425, 22);
            materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            materialFloatingActionButton2.Size = new Size(56, 56);
            materialFloatingActionButton2.TabIndex = 6;
            materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            materialFloatingActionButton2.UseVisualStyleBackColor = true;
            materialFloatingActionButton2.Click += materialFloatingActionButton2_Click;
            // 
            // tbPrescriptionComments
            // 
            tbPrescriptionComments.AnimateReadOnly = false;
            tbPrescriptionComments.BorderStyle = BorderStyle.None;
            tbPrescriptionComments.Depth = 0;
            tbPrescriptionComments.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPrescriptionComments.Hint = "Prescription and comments";
            tbPrescriptionComments.LeadingIcon = null;
            tbPrescriptionComments.Location = new Point(6, 190);
            tbPrescriptionComments.MaxLength = 50;
            tbPrescriptionComments.MouseState = MaterialSkin.MouseState.OUT;
            tbPrescriptionComments.Multiline = false;
            tbPrescriptionComments.Name = "tbPrescriptionComments";
            tbPrescriptionComments.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal;
            tbPrescriptionComments.Size = new Size(404, 50);
            tbPrescriptionComments.TabIndex = 4;
            tbPrescriptionComments.Text = "";
            tbPrescriptionComments.TrailingIcon = null;
            // 
            // tbAddress
            // 
            tbAddress.AnimateReadOnly = false;
            tbAddress.BorderStyle = BorderStyle.None;
            tbAddress.Depth = 0;
            tbAddress.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbAddress.Hint = "Address";
            tbAddress.LeadingIcon = null;
            tbAddress.Location = new Point(6, 134);
            tbAddress.MaxLength = 50;
            tbAddress.MouseState = MaterialSkin.MouseState.OUT;
            tbAddress.Multiline = false;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(404, 50);
            tbAddress.TabIndex = 3;
            tbAddress.Text = "";
            tbAddress.TrailingIcon = null;
            // 
            // tbPhone
            // 
            tbPhone.AnimateReadOnly = false;
            tbPhone.BorderStyle = BorderStyle.None;
            tbPhone.Depth = 0;
            tbPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPhone.Hint = "Phone";
            tbPhone.LeadingIcon = null;
            tbPhone.Location = new Point(6, 78);
            tbPhone.MaxLength = 50;
            tbPhone.MouseState = MaterialSkin.MouseState.OUT;
            tbPhone.Multiline = false;
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(404, 50);
            tbPhone.TabIndex = 2;
            tbPhone.Text = "";
            tbPhone.TrailingIcon = null;
            // 
            // tbLastName
            // 
            tbLastName.AnimateReadOnly = false;
            tbLastName.BorderStyle = BorderStyle.None;
            tbLastName.Depth = 0;
            tbLastName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbLastName.Hint = "Last name";
            tbLastName.LeadingIcon = null;
            tbLastName.Location = new Point(211, 22);
            tbLastName.MaxLength = 50;
            tbLastName.MouseState = MaterialSkin.MouseState.OUT;
            tbLastName.Multiline = false;
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(199, 50);
            tbLastName.TabIndex = 1;
            tbLastName.Text = "";
            tbLastName.TrailingIcon = null;
            // 
            // tbFirstName
            // 
            tbFirstName.AnimateReadOnly = false;
            tbFirstName.BorderStyle = BorderStyle.None;
            tbFirstName.Depth = 0;
            tbFirstName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbFirstName.Hint = "First name";
            tbFirstName.LeadingIcon = null;
            tbFirstName.Location = new Point(6, 22);
            tbFirstName.MaxLength = 50;
            tbFirstName.MouseState = MaterialSkin.MouseState.OUT;
            tbFirstName.Multiline = false;
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(199, 50);
            tbFirstName.TabIndex = 0;
            tbFirstName.Text = "";
            tbFirstName.TrailingIcon = null;
            // 
            // tbSearchLastName
            // 
            tbSearchLastName.AnimateReadOnly = false;
            tbSearchLastName.BackgroundImageLayout = ImageLayout.None;
            tbSearchLastName.CharacterCasing = CharacterCasing.Normal;
            tbSearchLastName.Depth = 0;
            tbSearchLastName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbSearchLastName.HideSelection = true;
            tbSearchLastName.Hint = "Search with last name";
            tbSearchLastName.LeadingIcon = null;
            tbSearchLastName.Location = new Point(12, 272);
            tbSearchLastName.MaxLength = 32767;
            tbSearchLastName.MouseState = MaterialSkin.MouseState.OUT;
            tbSearchLastName.Name = "tbSearchLastName";
            tbSearchLastName.PasswordChar = '\0';
            tbSearchLastName.PrefixSuffixText = null;
            tbSearchLastName.ReadOnly = false;
            tbSearchLastName.RightToLeft = RightToLeft.No;
            tbSearchLastName.SelectedText = "";
            tbSearchLastName.SelectionLength = 0;
            tbSearchLastName.SelectionStart = 0;
            tbSearchLastName.ShortcutsEnabled = true;
            tbSearchLastName.Size = new Size(683, 48);
            tbSearchLastName.TabIndex = 1;
            tbSearchLastName.TabStop = false;
            tbSearchLastName.TextAlign = HorizontalAlignment.Left;
            tbSearchLastName.TrailingIcon = Properties.Resources.spy_glass;
            tbSearchLastName.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(683, 301);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = false;
            btnUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdate.Depth = 0;
            btnUpdate.HighEmphasis = true;
            btnUpdate.Icon = null;
            btnUpdate.Location = new Point(706, 439);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.NoAccentTextColor = Color.Empty;
            btnUpdate.Size = new Size(75, 36);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdate.UseAccentColor = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += materialButton1_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(706, 391);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(75, 36);
            materialButton2.TabIndex = 4;
            materialButton2.Text = "Print";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // btnDelete
            // 
            btnDelete.Depth = 0;
            btnDelete.Icon = Properties.Resources.delete;
            btnDelete.Location = new Point(716, 326);
            btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(56, 56);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "materialFloatingActionButton1";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 640);
            Controls.Add(btnDelete);
            Controls.Add(materialButton2);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView1);
            Controls.Add(tbSearchLastName);
            Controls.Add(groupBox1);
            Name = "Main_Form";
            Text = "Main_Form";
            FormClosing += Main_Form_FormClosing;
            Load += Main_Form_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox tbLastName;
        private MaterialSkin.Controls.MaterialTextBox tbFirstName;
        private MaterialSkin.Controls.MaterialTextBox tbPrescriptionComments;
        private MaterialSkin.Controls.MaterialTextBox tbAddress;
        private MaterialSkin.Controls.MaterialTextBox tbPhone;
        private MaterialSkin.Controls.MaterialTextBox2 tbSearchLastName;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnDelete;
    }
}