namespace ProgressIndicator
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
            progressBar1 = new ProgressBar();
            lblProgress = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            circularProgressBar1 = new CircularProgressBar_NET5.CircularProgressBar();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(262, 133);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(313, 37);
            progressBar1.TabIndex = 0;
            // 
            // lblProgress
            // 
            lblProgress.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            lblProgress.Location = new Point(581, 133);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(86, 37);
            lblProgress.TabIndex = 2;
            lblProgress.Text = "0%";
            lblProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.QuinticEaseOut;
            circularProgressBar1.AnimationSpeed = 500;
            circularProgressBar1.BackColor = Color.Transparent;
            circularProgressBar1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            circularProgressBar1.ForeColor = Color.FromArgb(64, 64, 64);
            circularProgressBar1.InnerColor = Color.FromArgb(224, 224, 224);
            circularProgressBar1.InnerMargin = 2;
            circularProgressBar1.InnerWidth = -1;
            circularProgressBar1.Location = new Point(24, 125);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColor = Color.Gray;
            circularProgressBar1.OuterMargin = -25;
            circularProgressBar1.OuterWidth = 25;
            circularProgressBar1.ProgressColor = Color.FromArgb(255, 128, 0);
            circularProgressBar1.ProgressWidth = 25;
            circularProgressBar1.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            circularProgressBar1.Size = new Size(200, 191);
            circularProgressBar1.StartAngle = 270;
            circularProgressBar1.SubscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = "";
            circularProgressBar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "";
            circularProgressBar1.TabIndex = 4;
            circularProgressBar1.TextMargin = new Padding(8, 8, 0, 0);
            circularProgressBar1.Value = 68;
            circularProgressBar1.Click += circularProgressBar1_Click;
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = true;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.Hint = "Integer";
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(12, 58);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(264, 48);
            materialTextBox21.TabIndex = 6;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseAccent = false;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(313, 61);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(75, 36);
            materialButton1.TabIndex = 7;
            materialButton1.Text = "Start";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(12, 27);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(589, 28);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "Enter a positive integer to determine the sum of the numbers from 1 to that number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 328);
            Controls.Add(materialLabel1);
            Controls.Add(materialButton1);
            Controls.Add(materialTextBox21);
            Controls.Add(circularProgressBar1);
            Controls.Add(lblProgress);
            Controls.Add(progressBar1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Total Sum";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lblProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularProgressBar_NET5.CircularProgressBar circularProgressBar1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}