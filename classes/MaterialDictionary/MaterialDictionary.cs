using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangliReborn.classes.MaterialDictionaryClass
{
    internal class MaterialDictionary
    {
        public MaterialDictionary() {
            Start();
        }
        public void Start()
        {
            /*
                CLASS MATERIAL
            */
            ClassMatDic.Add("Rage Tacet Core", new Bitmap(classMatPath + "\\ragetacetcore.png"));
            ClassMatDic.Add("Elegy Tacet Core", new Bitmap(classMatPath + "\\elegytacetcore.png"));

            /*
                BOSS MATERIAL
            */
            BossMatDic.Add("Sentinel Dagger", new Bitmap(bossMatPath + "\\sentineldagger.png"));

            /*
                FLOWER TYPE
            */
            FlowerMatDic.Add("Pavo Plum", new Bitmap(FlowerMatPath + "\\pavoplum.png"));
            FlowerMatDic.Add("Gloom Slough", new Bitmap(FlowerMatPath + "\\gloomslough.png"));
        }
        string classMatPath = "..\\..\\..\\assets\\IngameMaterial\\ClassMat";
        string bossMatPath = "..\\..\\..\\assets\\IngameMaterial\\BossMat";
        string FlowerMatPath = "..\\..\\..\\assets\\IngameMaterial\\FlowerType";

        public Dictionary<string, Bitmap> ClassMatDic = new Dictionary<string, Bitmap>();
        public Dictionary<string, Bitmap> BossMatDic = new Dictionary<string, Bitmap>();
        public Dictionary<string, Bitmap> FlowerMatDic = new Dictionary<string, Bitmap>();
        //public Dictionary<string, string> AscensionMatDic = new Dictionary<string, string>();
        //public Dictionary<string, string> SkillMatDic = new Dictionary<string, string>();
    }
}
