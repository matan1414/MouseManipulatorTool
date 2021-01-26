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
    public partial class MarkImagePosition : Form
    {
        private Bitmap frameImage;
        public MarkImagePosition(Bitmap image)
        {
            InitializeComponent();

            this.frameImage = image;
            pictureBox.Image = image;

            BtnOk.DialogResult = DialogResult.OK;
            BtnCancel.DialogResult = DialogResult.Cancel;

            this.AcceptButton = BtnOk;
            this.CancelButton = BtnCancel;
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
