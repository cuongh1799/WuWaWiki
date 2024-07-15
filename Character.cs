using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangliReborn
{
    public class Character
    {
        public Character() { }
        public Character(
                        String nameInput, 
                        String materialInput, 
                        string classMaterialInput, 
                        String bossMaterialinput, 
                        String skillMatInput,
                        String charBannerURl,
                        String charIconURL) 
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
        public string CharIconURL{ get; set; } = "Not set";
        public Bitmap CharBanner { get; set; } = null;
        public Bitmap CharIcon { get; set; } = null;
        public Dictionary<string, int> Material { get; set; } = new Dictionary<string, int>();

        public void setName(string input)
        {
            this.Name = input;
        }
        public void addMaterial(string Input, string Input2)
        {
            //  Ascension + skill
            // Amount order might be wrong pls check this again
            Material.Add(Input+" T0", 52);
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
            System.Console.WriteLine(Name);
            System.Console.WriteLine("Material list:");
            foreach (KeyValuePair<string, int> kvp in Material)
            {
                System.Console.WriteLine("- " + kvp.Key + ", amount: " + kvp.Value);
                result += "- " + kvp.Key + ", amount: " + kvp.Value + "\n";
            }
            System.Console.WriteLine("- " + ClassMaterialType + ", amount: " + 46);
            System.Console.WriteLine("- " + BossMaterialType + ", amount: " + 26);
            System.Console.WriteLine("CharBannerURL: " + CharBannerURL);
            System.Console.WriteLine("CharIconURL: " + CharIconURL);
            return result;
        }
    }
}

