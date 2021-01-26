using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class AutoClicker : Form
    {

        private Thread processThread;

        public AutoClicker()
        {
            InitializeComponent();
        }


        

        private void SnipScreenButton_Click(object sender, EventArgs e)
        {
            SnipScreen sp = new SnipScreen();
            this.Hide();
            if(sp.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            
        }

        private void btnOptionsScreen_Click(object sender, EventArgs e)
        {
            Options optionsForm = new Options();
            optionsForm.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ProcessManager pm = new ProcessManager();
            processThread = new Thread(pm.Run);
            processThread.Start();

            btnStart.Enabled = false;
            btnStop.Enabled = true;
           
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            processThread.Abort();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void AutoClicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(processThread != null)
            {
                processThread.Abort();
            }
            
        }
    }

    
}
