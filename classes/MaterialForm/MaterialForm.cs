using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            AscensionMatLabel.Text = c.AscensionMat;
            SkillMatLabel1.Text = c.AscensionMat;
            SkillMatLabel2.Text = c.SkillMat;
            FlowerTypeLabel.Text = c.FlowerType + " x 60";
            foreach (KeyValuePair<string, Bitmap> kvp in matdic.FlowerMatDic)
            {
                if (kvp.Key == c.FlowerType)
                {
                    FlowerTypePic.Image = kvp.Value;
                    FlowerTypePic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }

        private void MaterialForm_Load(object sender, EventArgs e)
        {

        }
    }
}
