using MaterialSkin.Controls;
using System.Windows.Forms;

namespace Text_Editor_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFileTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fileSaverDialogue.Filter = "Text files |*.txt;";
            fileSaverDialogue.InitialDirectory = @"C:\Users\2013.102253\Downloads\";
            fileSaverDialogue.FileName = tbFileTitle.Text;

            if (fileSaverDialogue.ShowDialog() == DialogResult.OK)
            {

                string address = Path.GetFullPath(fileSaverDialogue.FileName);
                string contents = tbFileContents.Text;
                string fileName = fileSaverDialogue.FileName;
                File.WriteAllText(fileName, contents);

                MessageBox.Show("Successfully saved", "Saving Successful");


            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // only selection of text files
            fileSelectorDialogue.Filter = "Text files |*.txt;";

            //only allows the selection of image files
            //fileSelectorDialogue.Filter = "Image files |*.png;*.jpg;*.jpeg;*.ico;";
            fileSelectorDialogue.InitialDirectory = "C:\\Users\\2013.102253\\Downloads";

            if (fileSelectorDialogue.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.BackgroundImage = Image.FromFile(fileSelectorDialogue.FileName);
                tbFileContents.Text = File.ReadAllText(fileSelectorDialogue.FileName);
                tbFileTitle.Text = fileSelectorDialogue.SafeFileName;


            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFileTitle.Text = "";
            tbFileContents.Text = "";
        }
    }
}