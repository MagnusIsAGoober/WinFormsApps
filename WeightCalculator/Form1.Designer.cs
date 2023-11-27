namespace WeightCalculator
{
    partial class WageCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WageCalculator));
            label1 = new Label();
            label2 = new Label();
            CalcBtn = new Button();
            hours = new TextBox();
            wage = new TextBox();
            btn2 = new Button();
            Tax = new TextBox();
            taxLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(243, 31);
            label1.TabIndex = 0;
            label1.Text = "Number of Hours Worked ";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(105, 50);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(150, 28);
            label2.TabIndex = 1;
            label2.Text = "Hourly Pay Rate";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // CalcBtn
            // 
            CalcBtn.Location = new Point(261, 140);
            CalcBtn.Name = "CalcBtn";
            CalcBtn.Size = new Size(91, 55);
            CalcBtn.TabIndex = 4;
            CalcBtn.Text = "Calculate Net Pay";
            CalcBtn.UseVisualStyleBackColor = true;
            CalcBtn.Click += CalcBtn_Click;
            // 
            // hours
            // 
            hours.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            hours.Location = new Point(261, 9);
            hours.Name = "hours";
            hours.Size = new Size(190, 34);
            hours.TabIndex = 6;
            hours.TextChanged += hours_TextChanged;
            // 
            // wage
            // 
            wage.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            wage.Location = new Point(261, 50);
            wage.Name = "wage";
            wage.Size = new Size(190, 34);
            wage.TabIndex = 7;
            // 
            // btn2
            // 
            btn2.Location = new Point(358, 140);
            btn2.Name = "btn2";
            btn2.Size = new Size(91, 55);
            btn2.TabIndex = 8;
            btn2.Text = "Exit";
            btn2.UseVisualStyleBackColor = true;
            // 
            // Tax
            // 
            Tax.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Tax.Location = new Point(261, 92);
            Tax.Name = "Tax";
            Tax.Size = new Size(190, 34);
            Tax.TabIndex = 10;
            Tax.TextChanged += Tax_TextChanged;
            // 
            // taxLbl
            // 
            taxLbl.AutoSize = true;
            taxLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            taxLbl.Location = new Point(151, 95);
            taxLbl.Name = "taxLbl";
            taxLbl.RightToLeft = RightToLeft.Yes;
            taxLbl.Size = new Size(104, 28);
            taxLbl.TabIndex = 9;
            taxLbl.Text = "Tax Rate %";
            taxLbl.TextAlign = ContentAlignment.TopRight;
            taxLbl.Click += TaxRate_Click;
            // 
            // WageCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 234);
            Controls.Add(Tax);
            Controls.Add(taxLbl);
            Controls.Add(btn2);
            Controls.Add(wage);
            Controls.Add(hours);
            Controls.Add(CalcBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WageCalculator";
            Text = "Form1";
            Load += WageCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button CalcBtn;
        private TextBox hours;
        private TextBox wage;
        private Button btn2;
        private TextBox Tax;
        private Label taxLbl;
    }
}