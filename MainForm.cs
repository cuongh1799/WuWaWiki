using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using ChangliReborn.classes.CharacterClass;
using ChangliReborn.classes.WuWaButton;
using ChangliReborn.classes;
using ChangliReborn.classes.MaterialForm;

namespace ChangliReborn
{
    public partial class MainForm : Form
    {
        Character charCursor = new Character(); // use this save the current chosen char
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
                    LINE 32-33 IS NEEDED BECAUSE:

                    LINE 30 WILL MAKE CharBanner and CharIcon NULL BECAUSE DESERIALIZE ASSIGN
                    IT TO NULL

                    NULL BECAUSE WE'RE NOT ACTUALLY CONVERTING IT BEFORE CREATE CHARACTER
                */
                Character character = JsonSerializer.Deserialize<Character>(jsonString);
                try
                {
                    character.CharBanner = new Bitmap(character.CharBannerURL);
                    character.CharIcon = new Bitmap(character.CharIconURL);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                    character.CharBanner = null;
                    character.CharIcon = null;
                }

                if (character != null)
                {
                    CharacterList.Add(character);
                }
            }
            return CharacterList;
        }

        private void LoadSidebar(List<Character> CharacterList)
        {
            foreach (Character c in CharacterList)
            {
                WuWaButton w = new WuWaButton(c);
                w.Click += WuWaButton_Click;
                sidebar.Controls.Add(w);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            CharacterList = LoadCharacter();
            LoadSidebar(CharacterList);
            System.Console.WriteLine("You are here");
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            MaterialForm materialForm = new MaterialForm(charCursor);
            materialForm.ShowDialog();
        }

        private void addCharacterButton_Click(object sender, EventArgs e)
        {
            AddCharacterForm addCharacterForm = new AddCharacterForm();
            addCharacterForm.ShowDialog();
        }

        private void WuWaButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (sender as WuWaButton).returnCharBanner();
            charCursor = (sender as WuWaButton).getCharButton();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            sidebar.Controls.Clear();
            CharacterList.Clear();
            CharacterList = LoadCharacter();
            sidebar.Controls.Add(addCharacterButton);
            LoadSidebar(CharacterList);
            System.Console.WriteLine("Refreshed!");
        }
    }
}
