using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class SnipScreen : Form
    {
        public SnipScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageManager mgr = new ImageManager();
            //mgr.PrintScreen(100, 100, 100, 100);
            //Bitmap bm = new Bitmap(Program.TEMP_SS_FILE);
            pictureBox.Image = mgr.PrintScreen(100, 100, 100, 100); ;
        }
    }
}
