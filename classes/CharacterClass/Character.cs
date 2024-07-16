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
                        string materialInput,
                        string classMaterialInput,
                        string bossMaterialinput,
                        string skillMatInput,
                        string charBannerURl,
                        string charIconURL)
        {
            Name = nameInput;
            //MaterialType = materialInput;
            ClassMaterialType = classMaterialInput;
            BossMaterialType = bossMaterialinput;
            addMaterial(materialInput, skillMatInput);
            CharBannerURL = charBannerURl;
            CharIconURL = charIconURL;
        }

        public string Name { get; set; } = "Not set"; // Using auto-implemented property
        public string ClassMaterialType { get; set; } = "Not set";
        public string BossMaterialType { get; set; } = "Not set";
        public string CharBannerURL { get; set; } = "Not set";
        public string CharIconURL { get; set; } = "Not set";
        public Bitmap CharBanner { get; set; } = null;
        public Bitmap CharIcon { get; set; } = null;
        public Dictionary<string, int> Material { get; set; } = new Dictionary<string, int>();

        public void setName(string input)
        {
            Name = input;
        }
        public void addMaterial(string Input, string Input2)
        {
            //  Ascension + skill
            // Amount order might be wrong pls check this again
            Material.Add(Input + " T0", 52);
            Material.Add(Input + " T1", 29);
            Material.Add(Input + " T2", 61);
            Material.Add(Input + " T3", 40);

            // Skill
            Material.Add(Input2 + " T0", 25);
            Material.Add(Input2 + " T1", 28);
            Material.Add(Input2 + " T2", 55);
            Material.Add(Input2 + " T3", 67);
        }
        public string returnInfoString()
        {
            string result = new string("");
            result += Name + "\n" + "Material list: \n";
            Console.WriteLine(Name);
            Console.WriteLine("Material list:");
            foreach (KeyValuePair<string, int> kvp in Material)
            {
                Console.WriteLine("- " + kvp.Key + ", amount: " + kvp.Value);
                result += "- " + kvp.Key + ", amount: " + kvp.Value + "\n";
            }
            Console.WriteLine("- " + ClassMaterialType + ", amount: " + 46);
            Console.WriteLine("- " + BossMaterialType + ", amount: " + 26);
            Console.WriteLine("CharBannerURL: " + CharBannerURL);
            Console.WriteLine("CharIconURL: " + CharIconURL);
            return result;
        }
    }
}

