namespace ChangliReborn
{
    public partial class Form1 : Form
    {
        //string JinhsiFilePath = "..\\..\\..\\assets\\CharacterBanner\\JinhsiBanner.jpg";
        //string ChangliFilePath = "..\\..\\..\\assets\\CharacterBanner\\ChangliBanner.jpeg";

        /*
        Trying to cache the image file to bitmap first so later on we don't need to convert it again 
        */
        Bitmap JinhsiBMP = new Bitmap("..\\..\\..\\assets\\CharacterBanner\\JinhsiBanner.jpg");
        Bitmap ChangliBMP = new Bitmap("..\\..\\..\\assets\\CharacterBanner\\ChangliBanner.jpeg");
        public Form1()
        {
            InitializeComponent();
        }

        private void JinhsiSelect_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = JinhsiBMP;
            //pictureBox1.Load(JinhsiFilePath);
        }

        private void ChangliSelect_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ChangliBMP;
            //pictureBox1.Load(ChangliFilePath);
        }
    }
}
