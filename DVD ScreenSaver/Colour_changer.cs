using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_ScreenSaver
{

    internal static class Colour_changer
    {    
        public static Image ColourFilter(this Image inputImage)
        {
            Random r = new Random();

            Bitmap outputColour = new Bitmap(inputImage.Width, inputImage.Height);
            outputColour.MakeTransparent();
            Graphics img_graphics = Graphics.FromImage(outputColour);
            img_graphics.DrawImage(inputImage, 0, 0, inputImage.Width, inputImage.Height);

            img_graphics.FillRectangle(new SolidBrush(Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256))), 0, 0, outputColour.Width, outputColour.Height);
            //img_graphics.BackColor = Color.Transparent;
            

            return outputColour;
        }
    }
}
