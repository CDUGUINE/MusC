using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusC
{
    class BtnCarte : Button
    {
        public BtnCarte()
        {
            BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("dos");
            BackgroundImageLayout = ImageLayout.Zoom;
            Size = new Size(102, 168);
            UseVisualStyleBackColor = true;
            Cursor = Cursors.Hand;
            Visible = false;
        }
    }
}
