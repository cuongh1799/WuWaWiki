using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ChangliReborn.classes.CharacterClass;

namespace ChangliReborn.classes.WuWaButton
{
    internal class WuWaButton : Button
    {
        public Character charButton { get; set; } = null;
        public WuWaButton(Character c)
        {
            this.Name = c.Name + "Button";
            this.charButton = c;
            Width = 362;
            Height = 80;
            this.Image = c.CharIcon;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            if(this.Image == null)
            {
                this.Text = c.Name;
            }
        }

        public Image returnCharBanner()
        {
            return getCharButton().CharBanner;
        }
            
        public Character getCharButton()
        {
            return charButton;
        }
    }
}
