using System.Numerics;
using System.Runtime.CompilerServices;
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

        private void LoadSidebar(List<Character> CharacterList)
        {
            for(int i = 0; i < CharacterList.Count; i++){
                Button button = new Button();
                button.Tag = i;
                sidebar.Controls.Add(button);
                button.Text = CharacterList.ElementAt(i).Name;
                button.Width = sidebar.Width - 10;
                button.Height = 80;
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
    }
}
