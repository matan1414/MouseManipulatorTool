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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();


            reloadTasksList();
            tbRefreshTime.Text = Program.GetProgramData().ProcessRefreshTimeMS.ToString();
            tbAfkDelay.Text = Program.GetProgramData().AfkDelayMS.ToString();
        }

        private void reloadTasksList()
        {
            int index = 0;
            ProcessData pd = Program.GetProgramData();
            foreach(TaskData td in pd.TaskData)
            {
                PictureBox pb = new PictureBox();
                
                string imagePath = Program.TASKS_IMAGES_FOLDER + @"\" + td.ImageKey + ".jpg";
                Bitmap bmp = new Bitmap(imagePath);
                bmp = ImageManager.ScaleImage(bmp, tlpTasks.Width, 200);
                pb.Image = bmp;
                pb.Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                pb.SetBounds(0, 0, bmp.Width, bmp.Height);
                pb.Name = td.ImageKey + " " + td.ClickPositionX + " " + td.ClickPositionY;

                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img.Image = bmp;
                img.Width = bmp.Width;

                //tlpTasks.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
               
                tlpTasks.Controls.Add(pb, index, 0);
                /*
                dgvTasks.Rows.Add(img);
                dgvTasks.Rows[index].Height = bmp.Height;
                dgvTasks.Rows[index].Cells[0].Value = bmp;
                index++;
                */
            }
            tlpTasks.AutoScroll = true;
            tlpTasks.MaximumSize = new Size(tlpTasks.Parent.Width, tlpTasks.Parent.Height);
        }

        private void lvTasksLists_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
            ImageList il = lvTasksLists.LargeImageList;
            
            if (lvTasksLists.SelectedItems.Count > 0){
                ImageList li = lvTasksLists.SelectedItems[0].ImageList;
                Bitmap bmp = new Bitmap(li.Images[0]);
                MarkImagePosition mip = new MarkImagePosition(bmp, 0, 0);
                if(mip.ShowDialog() == DialogResult.OK)
                {

                }
            }
            */
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ProcessData pd = Program.GetProgramData();
            try {
                pd.ProcessRefreshTimeMS = int.Parse(tbRefreshTime.Text);
                pd.AfkDelayMS = int.Parse(tbAfkDelay.Text);
                Program.SaveProgramData(pd);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void Options_Resize(object sender, EventArgs e)
        {
            tlpTasks.MaximumSize = new Size(tlpTasks.Parent.Width, tlpTasks.Parent.Height); 
        }
    }
}
