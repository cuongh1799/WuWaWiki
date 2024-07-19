using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChangliReborn.classes.CharacterClass;
using ChangliReborn.classes.MaterialDictionaryClass;

namespace ChangliReborn.classes.MaterialForm
{
    public partial class MaterialForm : Form
    {
        MaterialDictionary matdic = new MaterialDictionary();
        public MaterialForm()
        {
            InitializeComponent();
        }

        public MaterialForm(Character c)
        {
            InitializeComponent();
            MatFormPic.Image = c.CharIcon;

            BossMatLabel.Text = c.BossMaterialType + " x 46";
            foreach (KeyValuePair<string, Bitmap> kvp in matdic.BossMatDic)
            {
                if (kvp.Key == c.BossMaterialType)
                {
                    BossMatPic.Image = kvp.Value;
                    BossMatPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

            ClassMatLabel.Text = c.ClassMaterialType + " x 26";
            foreach (KeyValuePair<string, Bitmap> kvp in matdic.ClassMatDic)
            {
                if (kvp.Key == c.ClassMaterialType)
                {
                    ClassMatPic.Image = kvp.Value;
                    ClassMatPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

            FlowerTypeLabel.Text = c.FlowerType + " x 60";
            foreach (KeyValuePair<string, Bitmap> kvp in matdic.FlowerMatDic)
            {
                if (kvp.Key == c.FlowerType)
                {
                    FlowerTypePic.Image = kvp.Value;
                    FlowerTypePic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

            AscensionMatLabel.Text = c.AscensionMat;
            foreach(KeyValuePair<string, string> kvp in matdic.NormalMatDic)
            {
                if (kvp.Key == c.AscensionMat)
                {
                    System.Console.WriteLine(kvp.Value);
                    DirectoryInfo directory = new DirectoryInfo(kvp.Value);
                    FileInfo[] fi = directory.GetFiles();
                    AscensionMatPic1.Image = new Bitmap(fi[0].DirectoryName + "\\" + fi[0].Name);
                    AscensionMatPic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    AscensionMatPic2.Image = new Bitmap(fi[1].DirectoryName + "\\" + fi[1].Name);
                    AscensionMatPic2.SizeMode = PictureBoxSizeMode.StretchImage;
                    AscensionMatPic3.Image = new Bitmap(fi[2].DirectoryName + "\\" + fi[2].Name);
                    AscensionMatPic3.SizeMode = PictureBoxSizeMode.StretchImage;
                    AscensionMatPic4.Image = new Bitmap(fi[3].DirectoryName + "\\" + fi[3].Name);
                    AscensionMatPic4.SizeMode = PictureBoxSizeMode.StretchImage;

                    skillMatpic0.Image = new Bitmap(fi[0].DirectoryName + "\\" + fi[0].Name);
                    skillMatpic0.SizeMode = PictureBoxSizeMode.StretchImage;
                    skillMatpic1.Image = new Bitmap(fi[1].DirectoryName + "\\" + fi[1].Name);
                    skillMatpic1.SizeMode = PictureBoxSizeMode.StretchImage;
                    skillMatpic2.Image = new Bitmap(fi[2].DirectoryName + "\\" + fi[2].Name);
                    skillMatpic2.SizeMode = PictureBoxSizeMode.StretchImage;
                    skillMatpic3.Image = new Bitmap(fi[3].DirectoryName + "\\" + fi[3].Name);
                    skillMatpic3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else 
                {
                    System.Console.WriteLine("Failed");
                }
            }
            SkillMatLabel1.Text = c.AscensionMat;
            SkillMatLabel2.Text = c.SkillMat;
        }

        private void MaterialForm_Load(object sender, EventArgs e)
        {

        }
    }
}
