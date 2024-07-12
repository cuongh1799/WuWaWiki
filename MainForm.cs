using System.Numerics;
using System.Text.Json;

namespace ChangliReborn
{
    public partial class MainForm : Form
    {
        Bitmap JinhsiBMP = new Bitmap("..\\..\\..\\assets\\CharacterBanner\\JinhsiBanner.jpg");
        Bitmap ChangliBMP = new Bitmap("..\\..\\..\\assets\\CharacterBanner\\ChangliBanner.jpeg");
        Boolean sidebarCollapse = false;
        string characterCursor = new string("");

        /*
            JSON SERIALIZATION AND DESERIALIZATION FOR FETCHING CHARACTER DATA
        */
        //var options = new JsonSerializerOptions { WriteIndented = true };

        public static string ChangliJSON = File.ReadAllText("..\\..\\..\\assets\\CharacterMaterial\\ChangliMaterial.json");
        public static string JinhsiJSON = File.ReadAllText("..\\..\\..\\assets\\CharacterMaterial\\JinhsiMaterial.json");
        //Character Changli = JsonSerializer.Deserialize<Character>(ChangliJSON);
        //Character Jinhsi = JsonSerializer.Deserialize<Character>(JinhsiJSON);

        // Cache character list
        List<Character> CharacterList;
        private List<Character> LoadCharacter()
        {
            DirectoryInfo charBannerDir = new DirectoryInfo("..\\..\\..\\assets\\CharacterMaterial\\");
            FileInfo[] files = charBannerDir.GetFiles("*.json"); // Assuming JSON files
            List<Character> CharacterList = new List<Character>();

            foreach (FileInfo file in files)
            {
                string jsonString = File.ReadAllText(file.FullName);
                Character character = JsonSerializer.Deserialize<Character>(jsonString);
                if (character != null)
                {
                    CharacterList.Add(character);
                }
            }
            return CharacterList;
        }

        public MainForm()
        {
            CharacterList = LoadCharacter();
            InitializeComponent();
        }

        
        private void OnOffPictureBox1()
        {
            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
            }
        }

        private void JinhsiSelect_Click(object sender, EventArgs e)
        {
            OnOffPictureBox1();
            pictureBox1.Image = JinhsiBMP;
            characterCursor = "Jinhsi";
        }

        private void ChangliSelect_Click(object sender, EventArgs e)
        {
            OnOffPictureBox1();
            pictureBox1.Image = ChangliBMP;
            characterCursor = "Changli";
        }

        private void JinhsiIconSide_Click(object sender, EventArgs e)
        {
            OnOffPictureBox1();
            pictureBox1.Image = JinhsiBMP;
            characterCursor = "Jinhsi";
        }

        private void ChangliIconSide_Click(object sender, EventArgs e)
        {
            OnOffPictureBox1();
            pictureBox1.Image = ChangliBMP;
            characterCursor = "Changli";
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
            //if (sidebarCollapse == true)
            //{
            //    SideBar.Width += 14;
            //    if (SideBar.Width >= 330)
            //    {
            //        timer1.Stop();
            //    }
            //}
            //else if (sidebarCollapse == false)
            //{
            //    SideBar.Width -= 14;
            //    if (SideBar.Width <= 110)
            //    {
            //        timer1.Stop();
            //    }
            //}
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (MaterialPanel.Visible == true)
            {
                MaterialPanel.Visible = false;
            }
            else if (MaterialPanel.Visible == false)
            {
                MaterialPanel.Visible = true;
                switch (characterCursor)
                {
                    //case "Changli":
                    //    MaterialPanel.Clear();
                    //    MaterialPanel.AppendText(Changli.returnInfoString());
                    //    break;
                    //case "Jinhsi":
                    //    MaterialPanel.Clear();
                    //    MaterialPanel.AppendText(Jinhsi.returnInfoString());
                    //    break;
                }
            }
        }

        private void addCharacterButton_Click(object sender, EventArgs e)
        {
            AddCharacterForm addCharacterForm = new AddCharacterForm();
            addCharacterForm.ShowDialog();
        }
    }
}
