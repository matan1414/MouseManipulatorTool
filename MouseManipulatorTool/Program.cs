using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AutoClicker
{
    static class Program
    {
        public const string TEMP_SS_FILE = "lastPrintScreen.jpg";
        public const string PROGRAM_DATA_PATH = "ProgramData.json";
        public const string TASKS_IMAGES_FOLDER = "tasks";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            createTaskImageDirectoryIfNotExist();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        /// <summary>
        /// Create folder for tasks images for first run
        /// </summary>
        static void createTaskImageDirectoryIfNotExist()
        {
            if (!Directory.Exists(TASKS_IMAGES_FOLDER))
            {
                Directory.CreateDirectory(TASKS_IMAGES_FOLDER);
            }
        }

        /// <summary>
        /// Get ProcessData object from json file
        /// </summary>
        /// <returns></returns>
        public static ProcessData GetProgramData()
        {
            ProcessData result = new ProcessData();
            using (StreamReader r = new StreamReader(PROGRAM_DATA_PATH))
            {
                string jsonString = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<ProcessData>(jsonString);
            }
            return result;
        }

        /// <summary>
        /// Save ProcessData object to json file
        /// </summary>
        /// <param name="processData"></param>
        public static void SaveProgramData(ProcessData processData)
        {
            string json = JsonConvert.SerializeObject(processData);
            File.WriteAllText(PROGRAM_DATA_PATH, json);
        }
    }


}
