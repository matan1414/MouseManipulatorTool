using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseManipulatorTool
{
    public partial class Form1 : Form
    {
        string desktop_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
        }

        private void PrintScreen_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(desktop_path + "\\Image Dir");
            string image_path = desktop_path + "\\Image Dir\\" + DateTime.Now.ToString("MMddyyHmmss") + ".jpg";

            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                    Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            bitmap.Save(image_path, ImageFormat.Jpeg);
        }
    }
}
