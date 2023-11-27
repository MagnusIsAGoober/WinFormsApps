namespace ComboBox
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
            MaterialSkin.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem2 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem3 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem4 = new MaterialSkin.MaterialListBoxItem();
            comboBox1 = new System.Windows.Forms.ComboBox();
            button1 = new Button();
            label1 = new Label();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            listBox1 = new ListBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.RosyBrown;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BMW", "Toyota", "Ford", "Audi", "Ferrari" });
            comboBox1.Location = new Point(62, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 22);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Not Chosen";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(78, 158);
            button1.Name = "button1";
            button1.Size = new Size(84, 22);
            button1.TabIndex = 1;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(24, 69);
            label1.Name = "label1";
            label1.Size = new Size(207, 86);
            label1.TabIndex = 2;
            label1.Text = "Selected Index";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.FlatStyle = FlatStyle.Popup;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.Hint = "chose a car";
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "Not Chosen", "BMW", "Toyota", "Ford", "Audi", "Ferrari" });
            materialComboBox1.Location = new Point(293, 17);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(121, 49);
            materialComboBox1.StartIndex = 4;
            materialComboBox1.TabIndex = 3;
            materialComboBox1.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.BorderStyle = BorderStyle.FixedSingle;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(262, 69);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(188, 86);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Selected Index";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(316, 156);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(74, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "select";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "BMW";
            materialListBoxItem2.SecondaryText = "";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "Toyota";
            materialListBoxItem3.SecondaryText = "";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "Ferrari";
            materialListBoxItem4.SecondaryText = "";
            materialListBoxItem4.Tag = null;
            materialListBoxItem4.Text = "Audi";
            materialListBox1.Items.Add(materialListBoxItem1);
            materialListBox1.Items.Add(materialListBoxItem2);
            materialListBox1.Items.Add(materialListBoxItem3);
            materialListBox1.Items.Add(materialListBoxItem4);
            materialListBox1.Location = new Point(307, 41);
            materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(158, 160);
            materialListBox1.TabIndex = 10;
            materialListBox1.SelectedIndexChanged += materialListBox1_SelectedIndexChanged;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(41, 143);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(73, 36);
            materialButton2.TabIndex = 7;
            materialButton2.Text = "DELETE";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "BMW", "Toyota", "Ferrari", "Audi" });
            listBox1.Location = new Point(181, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 11;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(6, 66);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(156, 50);
            materialTextBox1.TabIndex = 6;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialTextBox1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(materialButton2);
            groupBox1.Controls.Add(materialListBox1);
            groupBox1.Location = new Point(19, 221);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 217);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "ListBoxes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(materialButton1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(materialLabel1);
            groupBox2.Controls.Add(materialComboBox1);
            groupBox2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(19, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(503, 195);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "ComboBoxes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private ListBox listBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}