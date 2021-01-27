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
        public const string TEMP_SS_FILE = "lastPrintScreen.png";
        public const string TEMP_SNIP_SS_FILE = "snip_lastPrintScreen.png";
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
            Application.Run(new AutoClicker());
        }

        public static string PathImageKey(string fileName)
        {
            return TASKS_IMAGES_FOLDER + @"\" + fileName + ".png";
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
        /// <returns> Retrun empty if file not exist </returns>
        public static ProcessData GetProgramData()
        {
            ProcessData result = new ProcessData();
            try
            {
                if (File.Exists(PROGRAM_DATA_PATH))
                {
                    using (StreamReader r = new StreamReader(PROGRAM_DATA_PATH))
                    {
                        string jsonString = r.ReadToEnd();
                        if(jsonString != string.Empty)
                        {
                            result = JsonConvert.DeserializeObject<ProcessData>(jsonString);
                        }
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Remove task by index from json and return object
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static ProcessData RemoveTaskData(int index)
        {
            ProcessData programData = GetProgramData();
            programData.TaskData.RemoveAt(index);
            SaveProgramData(programData);
            return programData;
        }

        /// <summary>
        ///  Add new task by index from json and return object
        /// </summary>
        /// <param name="taskData"></param>
        /// <returns></returns>
        public static ProcessData AddTaskData(TaskData taskData) {
            ProcessData programData = GetProgramData();
            programData.TaskData.Add(taskData);
            SaveProgramData(programData);
            return programData;
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
