using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangliReborn.classes.CharacterClass
{
    public class Character
    {
        public Character() { }
        public Character(
                        string nameInput,
                        string classMaterialInput,
                        string bossMaterialinput,
                        string ascensionMatInput,
                        string skillMatInput,
                        string charBannerURl,
                        string charIconURL)
        {
            Name = nameInput;
            ClassMaterialType = classMaterialInput;
            BossMaterialType = bossMaterialinput;
            AscensionMat = ascensionMatInput;
            SkillMat = skillMatInput;
            CharBannerURL = charBannerURl;
            CharIconURL = charIconURL;
        }

        public string Name { get; set; } = "Not set"; // Using auto-implemented property
        public string ClassMaterialType { get; set; } = "Not set";
        public string BossMaterialType { get; set; } = "Not set";
        public string AscensionMat { get; set; } = "Not set";
        public string SkillMat { get; set; } = "Not set";
        public string CharBannerURL { get; set; } = "Not set";
        public string CharIconURL { get; set; } = "Not set";
        public Bitmap CharBanner { get; set; } = null;
        public Bitmap CharIcon { get; set; } = null;
        

        public void setName(string input)
        {
            Name = input;
        }
    }
}

