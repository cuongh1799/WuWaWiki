using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Reflection;

namespace ChangliReborn
{
    public partial class AddCharacterForm : Form
    {
        const string materialPath = "..\\..\\..\\assets\\CharacterMaterial";
        const string bannerPath = "..\\..\\..\\assets\\CharacterBanner";
        const string bannerIcon = "..\\..\\..\\assets\\CharacterIcon";

        public AddCharacterForm()
        {
            InitializeComponent();
        }

        private void ChooseCharBanner_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CharBannerURL.Text = openFileDialog1.FileName;
            }
        }

        private void ChooseCharIcon_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                CharIconURL.Text = openFileDialog2.FileName;
            }
        }

        private void AddCharacterJSON_Click(object sender, EventArgs e)
        {
            Character newchar = new Character
                (
                    InputCharacterName.Text, 
                    AscensionMatInput.Text, 
                    ClassMatNameInput.Text, 
                    BossMatInput.Text,
                    SkillMatInput.Text, 
                    CharBannerURL.Text, 
                    CharIconURL.Text
                );
            /*
                NEW ISSUE: THE URL ON BOTH BANNER AND ICON IS FULL DIRECTORY
                WHICH MEANS ON OTHER PC IT WILL BE FUCKED
            */

            // Case 1: User choose file from "Download"
            // We probably need to check if exist first then move + rename 

            // Case 2: User choose file from the folder itself for some reason
            // Need to check if file exist or not


            var options = new JsonSerializerOptions{ WriteIndented = true };
            string serialString = JsonSerializer.Serialize( newchar, options );
            
            // Need Directory.Move because it create in Debug folder
            File.WriteAllText(newchar.Name + ".json", serialString);


            if (File.Exists(materialPath + "\\" + newchar.Name + ".json"))
            {
                File.Delete(materialPath + "\\" + newchar.Name + ".json");
            }

            Directory.Move(newchar.Name + ".json", materialPath + "\\" + newchar.Name + ".json");
            AddSuccessScreen successScreen = new AddSuccessScreen();
            successScreen.ShowDialog();
        }
    }
}
