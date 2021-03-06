﻿using System;
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
        private bool isMouseDown;
        private int MouseDownX;
        private int MouseDownY;
        private int MouseUpX;
        private int MouseUpY;
        private int MouseMoveX;
        private int MouseMoveY;

        public SnipScreen()
        {
            InitializeComponent();
            
            this.Opacity = 0.01;
            Frame.BorderStyle = BorderStyle.FixedSingle;
            Console.WriteLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            ImageManager mgr = new ImageManager();
            Bitmap ss = mgr.PrintScreen(100, 100, 100, 100);
            MarkImagePosition mip = new MarkImagePosition(ss);
            if (mip.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("aaaa");
            }
            */
        }

        private void SnipScreen_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void SnipScreen_MouseDown(object sender, MouseEventArgs e)
        {
            this.isMouseDown = true;
            this.MouseDownX = e.X;
            this.MouseDownY = e.Y;
        }

        private void SnipScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int x, y, w, h;
                this.MouseMoveX = e.X;
                this.MouseMoveY = e.Y;
                if (this.MouseMoveX > this.MouseDownX)
                {
                    x = this.MouseDownX;
                    w = this.MouseMoveX - this.MouseDownX;
                }
                else
                {
                    x = this.MouseMoveX;
                    w = this.MouseDownX - this.MouseMoveX;
                }

                if (this.MouseMoveY > this.MouseDownY)
                {
                    y = this.MouseDownY;
                    h = this.MouseMoveY - this.MouseDownY;
                }
                else
                {
                    y = this.MouseMoveY;
                    h = this.MouseDownY - this.MouseMoveY;
                }

                DrawFrame(new Rectangle(x, y, w, h));
            }
        }

        private void SnipScreen_MouseUp(object sender, MouseEventArgs e)
        {
            if(this.isMouseDown)
            {
                this.MouseUpX = e.X;
                this.MouseUpY = e.Y;

                ImageManager mgr = new ImageManager();
                mgr.PrintScreen(Frame.Bounds.X, Frame.Bounds.Y, Frame.Bounds.Width, Frame.Bounds.Height);//
                Bitmap rectScreenShot = new Bitmap(Image.FromFile(Program.TEMP_SNIP_SS_FILE));
                MarkImagePosition mip = new MarkImagePosition(rectScreenShot, 0, 0);

                if(mip.ShowDialog() == DialogResult.OK)
                {
                    Program.AddTaskData(mip.taskData);
                }
                this.DialogResult = DialogResult.OK;
                mgr.PrintScreen(); //
                Bitmap fullScreenShoot = new Bitmap(Image.FromFile(Program.TEMP_SS_FILE));
                Point? po = mgr.FindInScreen(fullScreenShoot, rectScreenShot);
              
                if(po != null)
                {
                    Console.WriteLine(po.Value.X + "_" + po.Value.Y + " - " + Frame.Bounds.X + "_" + Frame.Bounds.Y);
                }
                else
                {
                    Console.WriteLine("No");
                }
                
                this.Close();
            }   
        }

        private void DrawFrame(Rectangle rect) {
            Frame.Visible = true;
            Frame.SetBounds(rect.X, rect.Y, rect.Width, rect.Height);
                
        }
        private void HideFrame() {
            Frame.Visible = false;
        }

    }
}
