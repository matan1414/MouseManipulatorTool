using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public class ProcessManager
    {
        private ProcessData processData;

        private int oldCursorX = 0;
        private int oldCursorY = 0;

        public ProcessManager()
        {
            processData = Program.GetProgramData();
        }

        private bool checkAfk()
        {
            if (this.oldCursorX != Cursor.Position.X || this.oldCursorY != Cursor.Position.Y)
            {
                this.oldCursorX = Cursor.Position.X;
                this.oldCursorY = Cursor.Position.Y;
                return true;
            }
            return false;
        }

        public void Run()
        {

            while (true)
            {
                try
                {
                    if (true)//checkAfk()
                    {
                        int index = 0;
                        ImageManager im = new ImageManager();
                        Bitmap haystack = im.PrintScreen();
                        foreach (TaskData td in processData.TaskData)
                        {
                            Bitmap bmp = new Bitmap(Program.PathImageKey(td.ImageKey));
                            haystack.Save("A" + index + ".jpg");
                            bmp.Save("B" + index + ".jpg");
                            Point? po = im.FindInScreen(haystack, bmp);
                            if (po != null)
                            {
                                int x = po.Value.X + td.ClickPositionX;
                                int y = po.Value.Y + td.ClickPositionY;
                                Console.WriteLine(x + " " + y);
                                LeftMouseClick(x, y);
                            }
                            else
                            {
                                Console.WriteLine("NO");
                            }
                            index++;
                        }
                    }
                }catch(Exception ex)
                {

                }
                
                System.Threading.Thread.Sleep(processData.ProcessRefreshTimeMS);
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }
    }
}
