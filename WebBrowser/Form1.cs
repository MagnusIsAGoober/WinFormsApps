using Microsoft.Web.WebView2.WinForms;
using System.Runtime.CompilerServices;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            wvMain.CoreWebView2.Navigate(tbUrl.Text);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            wvMain.CoreWebView2.ShowPrintUI();
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            wvMain.CoreWebView2.GoBack();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            wvMain.CoreWebView2.Navigate("https://www.google.ca/?safe=active&ssui=on");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wvMain.CoreWebView2.GoForward();
        }
    }
}