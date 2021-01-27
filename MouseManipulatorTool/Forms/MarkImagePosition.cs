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
        public const int DOT_WH = 3;
        public TaskData taskData { set; get; }

        private Bitmap currentImage; 

        public MarkImagePosition(Bitmap image, int x, int y)
        {
            
            this.currentImage = image;
            InitializeComponent();

            SetElementsStyle();

            Dot.BackColor = Color.Red;
            Dot.Visible = x > 0 && y > 0;

            pictureBox.Image = image;

            BtnOk.DialogResult = DialogResult.OK;
            BtnCancel.DialogResult = DialogResult.Cancel;

            this.AcceptButton = BtnOk;
            this.CancelButton = BtnCancel;
        }

        private void SetElementsStyle()
        {
            int offsetY = 10;
            int formWidth = this.currentImage.Width + (tableLayoutPanel.Bounds.X * 2);
            int formHeight = this.currentImage.Height + (tableLayoutPanel.Bounds.Y * 2) + tableLayoutInner.Height + offsetY;

            if (formHeight > Screen.PrimaryScreen.Bounds.Height)
            {
                formHeight = Screen.PrimaryScreen.Bounds.Height;
            }
            if (formWidth > Screen.PrimaryScreen.Bounds.Width)
            {
                formWidth = Screen.PrimaryScreen.Bounds.Width;
            }

            this.Size = new Size(formWidth, formHeight);

           

            BtnOk.Enabled = false;
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string uniqFileName = GetTimestamp(DateTime.Now);
            string imagePath = Program.PathImageKey(uniqFileName);
            ImageManager im = new ImageManager();
            //im.SaveHighQualityBitmap(this.currentImage, imagePath);
            this.currentImage.Save(imagePath);
            this.taskData = new TaskData(uniqFileName, Dot.Bounds.X, Dot.Bounds.Y);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            int x = coordinates.X + tableLayoutPanel.Bounds.X;
            int y = coordinates.Y + tableLayoutPanel.Bounds.Y;
            Dot.SetBounds(x, y, DOT_WH, DOT_WH);
            Dot.Visible = true;
            BtnOk.Enabled = true;

        }

        private static string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
    }
}
