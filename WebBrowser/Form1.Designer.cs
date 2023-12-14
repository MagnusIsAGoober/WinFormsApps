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
            btnPrint = new MaterialSkin.Controls.MaterialButton();
            btnPrevious = new Button();
            btnHome = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)wvMain).BeginInit();
            SuspendLayout();
            // 
            // wvMain
            // 
            wvMain.AllowExternalDrop = true;
            wvMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wvMain.CreationProperties = null;
            wvMain.DefaultBackgroundColor = Color.White;
            wvMain.Location = new Point(12, 71);
            wvMain.Name = "wvMain";
            wvMain.Size = new Size(997, 608);
            wvMain.Source = new Uri("https://www.google.ca/?safe=active&ssui=on", UriKind.Absolute);
            wvMain.TabIndex = 0;
            wvMain.ZoomFactor = 1D;
            // 
            // btnGo
            // 
            btnGo.Anchor = AnchorStyles.Top;
            btnGo.AutoSize = false;
            btnGo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGo.Depth = 0;
            btnGo.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGo.HighEmphasis = true;
            btnGo.Icon = null;
            btnGo.Location = new Point(402, 5);
            btnGo.Margin = new Padding(4, 6, 4, 6);
            btnGo.MouseState = MaterialSkin.MouseState.HOVER;
            btnGo.Name = "btnGo";
            btnGo.NoAccentTextColor = Color.Empty;
            btnGo.Size = new Size(107, 55);
            btnGo.TabIndex = 1;
            btnGo.Text = "Go";
            btnGo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGo.UseAccentColor = false;
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnEnter_Click;
            // 
            // tbUrl
            // 
            tbUrl.Anchor = AnchorStyles.Top;
            tbUrl.AnimateReadOnly = false;
            tbUrl.BorderStyle = BorderStyle.FixedSingle;
            tbUrl.Depth = 0;
            tbUrl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbUrl.Hint = "www.google.com";
            tbUrl.LeadingIcon = null;
            tbUrl.Location = new Point(91, 5);
            tbUrl.MaxLength = 50;
            tbUrl.MouseState = MaterialSkin.MouseState.OUT;
            tbUrl.Multiline = false;
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(304, 50);
            tbUrl.TabIndex = 2;
            tbUrl.Text = "https://www.facebook.com/";
            tbUrl.TrailingIcon = null;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top;
            btnPrint.AutoSize = false;
            btnPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPrint.Depth = 0;
            btnPrint.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.HighEmphasis = true;
            btnPrint.Icon = null;
            btnPrint.Location = new Point(632, 5);
            btnPrint.Margin = new Padding(4, 6, 4, 6);
            btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            btnPrint.Name = "btnPrint";
            btnPrint.NoAccentTextColor = Color.Empty;
            btnPrint.Size = new Size(107, 55);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPrint.UseAccentColor = false;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Top;
            btnPrevious.BackgroundImage = Properties.Resources.previous;
            btnPrevious.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrevious.FlatStyle = FlatStyle.Popup;
            btnPrevious.Location = new Point(746, 5);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(128, 57);
            btnPrevious.TabIndex = 6;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click_1;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top;
            btnHome.AutoSize = false;
            btnHome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnHome.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnHome.Depth = 0;
            btnHome.Font = new Font("Papyrus", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.HighEmphasis = true;
            btnHome.Icon = null;
            btnHome.Location = new Point(517, 5);
            btnHome.Margin = new Padding(4, 6, 4, 6);
            btnHome.MouseState = MaterialSkin.MouseState.HOVER;
            btnHome.Name = "btnHome";
            btnHome.NoAccentTextColor = Color.Empty;
            btnHome.Size = new Size(107, 55);
            btnHome.TabIndex = 9;
            btnHome.Text = "Home";
            btnHome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnHome.UseAccentColor = false;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(21, 9);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(64, 23);
            materialLabel1.TabIndex = 10;
            materialLabel1.Text = "Enter Url";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackgroundImage = Properties.Resources.next;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(880, 5);
            button1.Name = "button1";
            button1.Size = new Size(128, 57);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1021, 682);
            Controls.Add(btnPrevious);
            Controls.Add(button1);
            Controls.Add(materialLabel1);
            Controls.Add(btnHome);
            Controls.Add(btnPrint);
            Controls.Add(tbUrl);
            Controls.Add(btnGo);
            Controls.Add(wvMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
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
        private MaterialSkin.Controls.MaterialButton btnPrint;
        private Button btnPrevious;
        private MaterialSkin.Controls.MaterialButton btnHome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Button button1;
    }
}