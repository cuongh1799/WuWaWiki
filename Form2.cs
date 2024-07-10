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

namespace ChangliReborn
{
    public partial class AddCharacterForm : Form
    {
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
                    SkillMatInput.Text
                );
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string serialString = JsonSerializer.Serialize( newchar, options );
            File.WriteAllText(newchar.Name, serialString);
        }
    }
}
