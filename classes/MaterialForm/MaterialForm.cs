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

namespace ChangliReborn.classes.MaterialForm
{
    public partial class MaterialForm : Form
    {
        public MaterialForm()
        {
            InitializeComponent();
        }

        public MaterialForm(Character c)
        {
            InitializeComponent();
            MatFormPic.Image = c.CharIcon;
            BossMatLabel.Text = c.BossMaterialType + " x 46";
            ClassMatLabel.Text = c.ClassMaterialType + " x 26";
            AscensionMatLabel.Text = c.AscensionMat;
            SkillMatLabel1.Text = c.AscensionMat;
            SkillMatLabel2.Text = c.SkillMat;
        }

        private void MatFormPic_Click(object sender, EventArgs e)
        {

        }
    }
}
