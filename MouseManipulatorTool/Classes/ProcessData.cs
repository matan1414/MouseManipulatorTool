using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    public class ProcessData
    {
        public int ProcessRefreshTimeMS { set; get; }
        public int AfkDelayMS { set; get; }
        public List<TaskData> TaskData = new List<TaskData>();
    }

    public class TaskData
    {
        public string ImageKey { set; get; }
        public int ClickPositionX { set; get; }
        public int ClickPositionY { set; get; }
        public TaskData() { }
        public TaskData(string imagePath, int x, int y) {
            this.ImageKey = imagePath;
            this.ClickPositionX = x;
            this.ClickPositionY = y;
        }
    }
}
