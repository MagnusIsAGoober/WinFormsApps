namespace Open_File_Dialogue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // only selection of text files
            fileSelectorDialogue.Filter = "Text files |*.txt;";

            //only allows the selection of image files
            //fileSelectorDialogue.Filter = "Image files |*.png;*.jpg;*.jpeg;*.ico;";
            fileSelectorDialogue.InitialDirectory = "C:\\Users\\2013.102253\\Downloads";

            if (fileSelectorDialogue.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.BackgroundImage = Image.FromFile(fileSelectorDialogue.FileName);
                tbContents.Text = File.ReadAllText(fileSelectorDialogue.FileName);
                materialLabel1.Text = fileSelectorDialogue.SafeFileName;


            }



        }

        private void fileSaverDialogue_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (fileSaverDialogue.ShowDialog() == DialogResult.OK)
            {
                string address = Path.GetFullPath(fileSaverDialogue.FileName);
                string contents = tbContents.Text;
                File.WriteAllText(address, contents);

                MessageBox.Show("Successfully saved", "Saving Successful");


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}