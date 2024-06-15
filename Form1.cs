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
        Boolean sidebarCollapse = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void JinhsiSelect_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
            }
            pictureBox1.Image = JinhsiBMP;
            //SideBar.BackColor = Color.DarkCyan;
            //pictureBox1.Load(JinhsiFilePath);
        }

        private void ChangliSelect_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
            }
            pictureBox1.Image = ChangliBMP;
            //SideBar.BackColor = Color.DarkRed;
            //pictureBox1.Load(ChangliFilePath);
        }

        private void JinhsiIconSide_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
            }
            pictureBox1.Image = JinhsiBMP;
            //SideBar.BackColor = Color.DarkCyan;
        }

        private void ChangliIconSide_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
            }
            pictureBox1.Image = ChangliBMP;
            //SideBar.BackColor = Color.DarkRed;
        }

        private void SideBarCollapseButton_Click(object sender, EventArgs e)
        {
            // Expand the Sidebar
            // Hide the buttonSelect of the characters
            if (sidebarCollapse == true)
            {
                ChangliIconSide.Visible = true;
                JinhsiIconSide.Visible = true;

                ChangliSelect.Visible = false;
                JinhsiSelect.Visible = false;

                //SideBar.Width = 286;
                timer1.Start();
                sidebarCollapse = false;
            }
            // Collapse the Sidebar
            // Hide the characterIcon
            else if (sidebarCollapse == false)
            {
                ChangliIconSide.Visible = false;
                JinhsiIconSide.Visible = false;

                ChangliSelect.Visible = true;
                JinhsiSelect.Visible = true;

                //SideBar.Width = 90;
                timer1.Start();
                sidebarCollapse = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarCollapse == true)
            {
                SideBar.Width += 14;
                if (SideBar.Width >= 330)
                {
                    timer1.Stop();
                }
            }
            else if (sidebarCollapse == false)
            {
                SideBar.Width -= 14;
                if (SideBar.Width <= 110)
                {
                    timer1.Stop();
                }
            }
        }
    }
}
