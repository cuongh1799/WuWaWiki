using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using ChangliReborn.classes.WuWaButton;

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

                /*
                    LINE 46-47 IS NEEDED BECAUSE:

                    LINE 45 WILL MAKE CharBanner and CharIcon NULL BECAUSE DESERIALIZE ASSIGN
                    IT TO NULL

                    NULL BECAUSE WE'RE NOT ACTUALLY CONVERTING IT BEFORE CREATE CHARACTER
                */
                Character character = JsonSerializer.Deserialize<Character>(jsonString);
                character.CharBanner = new Bitmap(character.CharBannerURL);
                character.CharIcon = new Bitmap(character.CharIconURL);
                if (character != null)
                {
                    CharacterList.Add(character);
                }
            }
            return CharacterList;
        }

        private void LoadSidebar(List<Character> CharacterList)
        {
            foreach(Character c in CharacterList)
            {
                sidebar.Controls.Add(new WuWaButton(c));
            }
        }

        public MainForm()
        {
            InitializeComponent();
            CharacterList = LoadCharacter();
            LoadSidebar(CharacterList);
            
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

        private void WuWaButton_Click(object sender, EventArgs e)
        {

        }
    }
}
