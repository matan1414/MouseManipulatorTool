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

namespace AutoClicker
{
    public partial class Main : Form
    { 
        public Main()
        {
            InitializeComponent();
        }

        private void SnipScreenButton_Click(object sender, EventArgs e)
        {
            SnipScreen sp = new SnipScreen();
            if(sp.ShowDialog() == DialogResult.OK)
            {

            }
            
        }
    }
}
