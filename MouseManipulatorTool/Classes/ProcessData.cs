using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    class ProcessData
    {
        public int ProcessRefreshTimeMS { set; get; }
        public List<TaskData> TaskData = new List<TaskData>();
    }

    class TaskData
    {
        public string ImagePath { set; get; }
        public int ClickPositionX { set; get; }
        public int ClickPositionY { set; get; }
    }
}
