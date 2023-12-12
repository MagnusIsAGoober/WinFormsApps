namespace WebBrowser
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
            wvMain = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnGo = new MaterialSkin.Controls.MaterialButton();
            tbUrl = new MaterialSkin.Controls.MaterialTextBox();
            btnPrevious = new MaterialSkin.Controls.MaterialButton();
            btnNext = new MaterialSkin.Controls.MaterialButton();
            btnPrint = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)wvMain).BeginInit();
            SuspendLayout();
            // 
            // wvMain
            // 
            wvMain.AllowExternalDrop = true;
            wvMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wvMain.CreationProperties = null;
            wvMain.DefaultBackgroundColor = Color.White;
            wvMain.Location = new Point(12, 12);
            wvMain.Name = "wvMain";
            wvMain.Size = new Size(776, 379);
            wvMain.Source = new Uri("https://ca.yahoo.com/", UriKind.Absolute);
            wvMain.TabIndex = 0;
            wvMain.ZoomFactor = 1D;
            // 
            // btnGo
            // 
            btnGo.Anchor = AnchorStyles.Bottom;
            btnGo.AutoSize = false;
            btnGo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGo.Depth = 0;
            btnGo.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGo.HighEmphasis = true;
            btnGo.Icon = null;
            btnGo.Location = new Point(379, 400);
            btnGo.Margin = new Padding(4, 6, 4, 6);
            btnGo.MouseState = MaterialSkin.MouseState.HOVER;
            btnGo.Name = "btnGo";
            btnGo.NoAccentTextColor = Color.Empty;
            btnGo.Size = new Size(64, 36);
            btnGo.TabIndex = 1;
            btnGo.Text = "Go";
            btnGo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGo.UseAccentColor = false;
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnEnter_Click;
            // 
            // tbUrl
            // 
            tbUrl.Anchor = AnchorStyles.Bottom;
            tbUrl.AnimateReadOnly = false;
            tbUrl.BorderStyle = BorderStyle.FixedSingle;
            tbUrl.Depth = 0;
            tbUrl.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbUrl.Hint = "URL:";
            tbUrl.LeadingIcon = null;
            tbUrl.Location = new Point(12, 397);
            tbUrl.MaxLength = 50;
            tbUrl.MouseState = MaterialSkin.MouseState.OUT;
            tbUrl.Multiline = false;
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(357, 50);
            tbUrl.TabIndex = 2;
            tbUrl.Text = "";
            tbUrl.TrailingIcon = null;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom;
            btnPrevious.AutoSize = false;
            btnPrevious.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrevious.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPrevious.Depth = 0;
            btnPrevious.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.HighEmphasis = true;
            btnPrevious.Icon = Properties.Resources.icons8_undo_52;
            btnPrevious.Location = new Point(451, 400);
            btnPrevious.Margin = new Padding(4, 6, 4, 6);
            btnPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            btnPrevious.Name = "btnPrevious";
            btnPrevious.NoAccentTextColor = Color.Empty;
            btnPrevious.Size = new Size(115, 36);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "Previous";
            btnPrevious.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPrevious.UseAccentColor = false;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom;
            btnNext.AutoSize = false;
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNext.Depth = 0;
            btnNext.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.HighEmphasis = true;
            btnNext.Icon = Properties.Resources.icons8_redo_52;
            btnNext.Location = new Point(574, 400);
            btnNext.Margin = new Padding(4, 6, 4, 6);
            btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            btnNext.Name = "btnNext";
            btnNext.NoAccentTextColor = Color.Empty;
            btnNext.Size = new Size(102, 36);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next";
            btnNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNext.UseAccentColor = false;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Bottom;
            btnPrint.AutoSize = false;
            btnPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPrint.Depth = 0;
            btnPrint.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.HighEmphasis = true;
            btnPrint.Icon = null;
            btnPrint.Location = new Point(684, 400);
            btnPrint.Margin = new Padding(4, 6, 4, 6);
            btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            btnPrint.Name = "btnPrint";
            btnPrint.NoAccentTextColor = Color.Empty;
            btnPrint.Size = new Size(102, 36);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPrint.UseAccentColor = false;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrint);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(tbUrl);
            Controls.Add(btnGo);
            Controls.Add(wvMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Web Browser";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)wvMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvMain;
        private MaterialSkin.Controls.MaterialButton btnGo;
        private MaterialSkin.Controls.MaterialTextBox tbUrl;
        private MaterialSkin.Controls.MaterialButton btnPrevious;
        private MaterialSkin.Controls.MaterialButton btnNext;
        private MaterialSkin.Controls.MaterialButton btnPrint;
    }
}