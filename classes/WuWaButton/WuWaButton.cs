using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangliReborn.classes.WuWaButton
{
    internal class WuWaButton : Button
    {
        Character charButton;
        public WuWaButton(Character c)
        {
            this.Name = c.Name + "Button";
            this.charButton = c;
            Width = 309;
            Height = 80;
            this.Image = c.CharIcon;
            if(this.Image == null)
            {
                this.Text = c.Name;
            }
            
        }

        private void showBanner(PictureBox p)
        {
            p.Image = charButton.CharBanner;
        }
    }
}
