namespace Distance_Converter
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
            MaterialSkin.MaterialListBoxItem materialListBoxItem5 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem6 = new MaterialSkin.MaterialListBoxItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            groupBox2 = new GroupBox();
            materialListBox2 = new MaterialSkin.Controls.MaterialListBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            label1 = new Label();
            label2 = new Label();
            convertedDistanceLbl = new Label();
            ConvertButton = new MaterialSkin.Controls.MaterialButton();
            exitBtn = new MaterialSkin.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialListBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(21, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "From";
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "inches";
            materialListBoxItem2.SecondaryText = "";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "Feet";
            materialListBoxItem3.SecondaryText = "";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "Yards";
            materialListBox1.Items.Add(materialListBoxItem1);
            materialListBox1.Items.Add(materialListBoxItem2);
            materialListBox1.Items.Add(materialListBoxItem3);
            materialListBox1.Location = new Point(21, 44);
            materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(186, 120);
            materialListBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(materialListBox2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(262, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(224, 173);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "To";
            // 
            // materialListBox2
            // 
            materialListBox2.BackColor = Color.White;
            materialListBox2.BorderColor = Color.LightGray;
            materialListBox2.Depth = 0;
            materialListBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem4.SecondaryText = "";
            materialListBoxItem4.Tag = null;
            materialListBoxItem4.Text = "inches";
            materialListBoxItem5.SecondaryText = "";
            materialListBoxItem5.Tag = null;
            materialListBoxItem5.Text = "Feet";
            materialListBoxItem6.SecondaryText = "";
            materialListBoxItem6.Tag = null;
            materialListBoxItem6.Text = "Yards";
            materialListBox2.Items.Add(materialListBoxItem4);
            materialListBox2.Items.Add(materialListBoxItem5);
            materialListBox2.Items.Add(materialListBoxItem6);
            materialListBox2.Location = new Point(21, 44);
            materialListBox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox2.Name = "materialListBox2";
            materialListBox2.SelectedIndex = -1;
            materialListBox2.SelectedItem = null;
            materialListBox2.Size = new Size(186, 120);
            materialListBox2.TabIndex = 0;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.Hint = "Distance";
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(283, 27);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(203, 50);
            materialTextBox1.TabIndex = 2;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(265, 33);
            label1.TabIndex = 3;
            label1.Text = "Enter the distance to convert:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 305);
            label2.Name = "label2";
            label2.Size = new Size(204, 24);
            label2.TabIndex = 4;
            label2.Text = "Converted Distance:";
            // 
            // convertedDistanceLbl
            // 
            convertedDistanceLbl.BorderStyle = BorderStyle.FixedSingle;
            convertedDistanceLbl.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            convertedDistanceLbl.ImageAlign = ContentAlignment.MiddleLeft;
            convertedDistanceLbl.Location = new Point(262, 293);
            convertedDistanceLbl.Name = "convertedDistanceLbl";
            convertedDistanceLbl.Size = new Size(207, 46);
            convertedDistanceLbl.TabIndex = 5;
            convertedDistanceLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConvertButton
            // 
            ConvertButton.AutoSize = false;
            ConvertButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ConvertButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ConvertButton.Depth = 0;
            ConvertButton.HighEmphasis = true;
            ConvertButton.Icon = null;
            ConvertButton.Location = new Point(159, 368);
            ConvertButton.Margin = new Padding(4, 6, 4, 6);
            ConvertButton.MouseState = MaterialSkin.MouseState.HOVER;
            ConvertButton.Name = "ConvertButton";
            ConvertButton.NoAccentTextColor = Color.Empty;
            ConvertButton.Size = new Size(86, 36);
            ConvertButton.TabIndex = 6;
            ConvertButton.Text = "Convert";
            ConvertButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ConvertButton.UseAccentColor = false;
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // exitBtn
            // 
            exitBtn.AutoSize = false;
            exitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exitBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            exitBtn.Depth = 0;
            exitBtn.HighEmphasis = true;
            exitBtn.Icon = null;
            exitBtn.Location = new Point(283, 368);
            exitBtn.Margin = new Padding(4, 6, 4, 6);
            exitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            exitBtn.Name = "exitBtn";
            exitBtn.NoAccentTextColor = Color.Empty;
            exitBtn.Size = new Size(66, 36);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "Exit";
            exitBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            exitBtn.UseAccentColor = false;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 450);
            Controls.Add(exitBtn);
            Controls.Add(ConvertButton);
            Controls.Add(convertedDistanceLbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(materialTextBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Distance Converter";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialListBox materialListBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private Label label1;
        private Label label2;
        private Label convertedDistanceLbl;
        private MaterialSkin.Controls.MaterialButton ConvertButton;
        private MaterialSkin.Controls.MaterialButton exitBtn;
    }
}