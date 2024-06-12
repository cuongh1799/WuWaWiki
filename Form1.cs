namespace ChangliReborn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void JinhsiSelect_Click(object sender, EventArgs e)
        {
            string filepath = "..\\..\\..\\assets\\CharacterBanner\\JinhsiBanner.jpg";
            pictureBox1.Load(filepath);
        }

        private void ChangliSelect_Click(object sender, EventArgs e)
        {
            string filepath = "..\\..\\..\\assets\\CharacterBanner\\ChangliBanner.jpeg";
            pictureBox1.Load(filepath);
        }
    }
}
