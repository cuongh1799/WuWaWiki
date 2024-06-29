using System.Text.Json;

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
        string characterCursor = new string("");

        /*
            JSON SERIALIZATION AND DESERIALIZATION FOR FETCHING CHARACTER DATA
        */
        //var options = new JsonSerializerOptions { WriteIndented = true };

        public static string ChangliJSON = File.ReadAllText("..\\..\\..\\assets\\CharacterMaterial\\ChangliMaterial.json");
        public static string JinhsiJSON = File.ReadAllText("..\\..\\..\\assets\\CharacterMaterial\\JinhsiMaterial.json");
        Character Changli = JsonSerializer.Deserialize<Character>(ChangliJSON);
        Character Jinhsi = JsonSerializer.Deserialize<Character>(JinhsiJSON);

        public Form1()
        {
            InitializeComponent();
        }

        public class Character
        {
            public string Name { get; set; } = "Not set"; // Using auto-implemented property
            public Dictionary<string, int> Material { get; set; } = new Dictionary<string, int>();

            public void setName(string input)
            {
                this.Name = input;
            }
            public void addMaterial(string Input, int Amount)
            {
                Material.Add(Input, Amount);
            }
            public string returnInfoString()
            {
                string result = new string("");
                result += Name + "\n" + "Material list: \n";
                System.Console.WriteLine(Name);
                System.Console.WriteLine("Material list:");
                foreach (KeyValuePair<string, int> kvp in Material)
                {
                    System.Console.WriteLine("- " + kvp.Key + ", amount: " + kvp.Value);
                    result += "- " + kvp.Key + ", amount: " + kvp.Value + "\n";
                }
                return result;
            }
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
            //SideBar.BackColor = Color.DarkCyan;
            //pictureBox1.Load(JinhsiFilePath);
            characterCursor = "Jinhsi";
        }

        private void ChangliSelect_Click(object sender, EventArgs e)
        {
            OnOffPictureBox1();
            pictureBox1.Image = ChangliBMP;
            //SideBar.BackColor = Color.DarkRed;
            //pictureBox1.Load(ChangliFilePath);
            characterCursor = "Changli";
        }

        private void JinhsiIconSide_Click(object sender, EventArgs e)
        {
            OnOffPictureBox1();
            pictureBox1.Image = JinhsiBMP;
            //SideBar.BackColor = Color.DarkCyan;
            characterCursor = "Jinhsi";
        }

        private void ChangliIconSide_Click(object sender, EventArgs e)
        {
            OnOffPictureBox1();
            pictureBox1.Image = ChangliBMP;
            //SideBar.BackColor = Color.DarkRed;
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
                    case "Changli":
                        MaterialPanel.Clear();
                        MaterialPanel.AppendText(Changli.returnInfoString());
                        break;
                    case "Jinhsi":
                        MaterialPanel.Clear();
                        MaterialPanel.AppendText(Jinhsi.returnInfoString());
                        break;
                }
            }
        }

        private void MaterialButton_Click(object sender, EventArgs e)
        {

        }
    }
}
