using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    class ImageManager
    {
        /// <summary>
        /// Save full print screen image to constant location - return bitmap
        /// </summary>
        public Bitmap PrintScreen()
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            Bitmap bitmap = new Bitmap(w, h);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            bitmap.Save(Program.TEMP_SS_FILE, ImageFormat.Jpeg);
            return bitmap;
        }

        /// <summary>
        /// Save selected positions print screen image to constant location - return bitmap
        /// </summary>
        public Bitmap PrintScreen(int x, int y, int w, int h)
        {
            Bitmap bitmap = new Bitmap(w, h);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(x, y, 0, 0, bitmap.Size);
            bitmap.Save(Program.TEMP_SS_FILE, ImageFormat.Jpeg);
            return bitmap;
        }
    }
}
