namespace Labels
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
            topLeftLabel = new Label();
            topMiddleLabel = new Label();
            topRightLabel = new Label();
            middleRightLabel = new Label();
            middleLable = new Label();
            middleLeftLabel = new Label();
            bottomRightLabel = new Label();
            BottomMiddleLabel = new Label();
            bottomLeftLabel = new Label();
            button1 = new Button();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // topLeftLabel
            // 
            topLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            topLeftLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            topLeftLabel.Location = new Point(12, 9);
            topLeftLabel.Name = "topLeftLabel";
            topLeftLabel.Size = new Size(150, 80);
            topLeftLabel.TabIndex = 0;
            topLeftLabel.Click += topLeftLabel_Click;
            // 
            // topMiddleLabel
            // 
            topMiddleLabel.BorderStyle = BorderStyle.FixedSingle;
            topMiddleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            topMiddleLabel.Location = new Point(181, 9);
            topMiddleLabel.Name = "topMiddleLabel";
            topMiddleLabel.Size = new Size(150, 80);
            topMiddleLabel.TabIndex = 1;
            topMiddleLabel.TextAlign = ContentAlignment.TopCenter;
            topMiddleLabel.Click += topMiddleLabel_Click;
            // 
            // topRightLabel
            // 
            topRightLabel.BorderStyle = BorderStyle.FixedSingle;
            topRightLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            topRightLabel.Location = new Point(353, 9);
            topRightLabel.Name = "topRightLabel";
            topRightLabel.Size = new Size(150, 80);
            topRightLabel.TabIndex = 2;
            topRightLabel.TextAlign = ContentAlignment.TopRight;
            topRightLabel.Click += topRightLabel_Click;
            // 
            // middleRightLabel
            // 
            middleRightLabel.BorderStyle = BorderStyle.FixedSingle;
            middleRightLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            middleRightLabel.Location = new Point(353, 95);
            middleRightLabel.Name = "middleRightLabel";
            middleRightLabel.Size = new Size(150, 80);
            middleRightLabel.TabIndex = 5;
            middleRightLabel.TextAlign = ContentAlignment.MiddleRight;
            middleRightLabel.Click += middleRightLabel_Click;
            // 
            // middleLable
            // 
            middleLable.BorderStyle = BorderStyle.FixedSingle;
            middleLable.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            middleLable.Location = new Point(181, 95);
            middleLable.Name = "middleLable";
            middleLable.Size = new Size(150, 80);
            middleLable.TabIndex = 4;
            middleLable.TextAlign = ContentAlignment.MiddleCenter;
            middleLable.Click += middleLable_Click;
            // 
            // middleLeftLabel
            // 
            middleLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            middleLeftLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            middleLeftLabel.Location = new Point(12, 95);
            middleLeftLabel.Name = "middleLeftLabel";
            middleLeftLabel.Size = new Size(150, 80);
            middleLeftLabel.TabIndex = 3;
            middleLeftLabel.TextAlign = ContentAlignment.MiddleLeft;
            middleLeftLabel.Click += middleLeftLabel_Click;
            // 
            // bottomRightLabel
            // 
            bottomRightLabel.BorderStyle = BorderStyle.FixedSingle;
            bottomRightLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            bottomRightLabel.Location = new Point(353, 188);
            bottomRightLabel.Name = "bottomRightLabel";
            bottomRightLabel.Size = new Size(150, 80);
            bottomRightLabel.TabIndex = 8;
            bottomRightLabel.TextAlign = ContentAlignment.BottomRight;
            bottomRightLabel.Click += bottomRightLabel_Click;
            // 
            // BottomMiddleLabel
            // 
            BottomMiddleLabel.BorderStyle = BorderStyle.FixedSingle;
            BottomMiddleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BottomMiddleLabel.Location = new Point(181, 188);
            BottomMiddleLabel.Name = "BottomMiddleLabel";
            BottomMiddleLabel.Size = new Size(150, 80);
            BottomMiddleLabel.TabIndex = 7;
            BottomMiddleLabel.TextAlign = ContentAlignment.BottomCenter;
            BottomMiddleLabel.Click += BottomMiddleLabel_Click;
            // 
            // bottomLeftLabel
            // 
            bottomLeftLabel.BorderStyle = BorderStyle.FixedSingle;
            bottomLeftLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            bottomLeftLabel.Location = new Point(12, 188);
            bottomLeftLabel.Name = "bottomLeftLabel";
            bottomLeftLabel.Size = new Size(150, 80);
            bottomLeftLabel.TabIndex = 6;
            bottomLeftLabel.TextAlign = ContentAlignment.BottomLeft;
            bottomLeftLabel.Click += bottomleftLabel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(197, 297);
            button1.Name = "button1";
            button1.Size = new Size(118, 58);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(343, 308);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 10;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 402);
            Controls.Add(materialButton1);
            Controls.Add(button1);
            Controls.Add(bottomRightLabel);
            Controls.Add(BottomMiddleLabel);
            Controls.Add(bottomLeftLabel);
            Controls.Add(middleRightLabel);
            Controls.Add(middleLable);
            Controls.Add(middleLeftLabel);
            Controls.Add(topRightLabel);
            Controls.Add(topMiddleLabel);
            Controls.Add(topLeftLabel);
            Name = "Form1";
            Text = "Label Alignment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label topLeftLabel;
        private Label topMiddleLabel;
        private Label topRightLabel;
        private Label middleRightLabel;
        private Label middleLable;
        private Label middleLeftLabel;
        private Label bottomRightLabel;
        private Label BottomMiddleLabel;
        private Label bottomLeftLabel;
        private Button button1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}