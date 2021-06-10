using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GIFExporter
{
    class Config
    {
        private static String _configFileLocation = $"{Environment.CurrentDirectory}\\Preferences.json";
        public String ProgramPath { get; set; }
        public String OutputFileDirectory { get; set; }
        public String OutputFileName { get; set; }
        public bool Loop { get; set; }
        public bool LoopInfinitely { get; set; }
        public int NumLoops { get; set; }

        private Config()
        {
            ProgramPath = "";
            OutputFileDirectory = $"{Environment.CurrentDirectory}";
            OutputFileName = "";
            Loop = false;
            LoopInfinitely = false;
            NumLoops = 1;
        }

        public static void SaveConfigFile(Config config)
        {
            String jsonString = JsonConvert.SerializeObject(config);
            File.WriteAllText(_configFileLocation, jsonString);
        }

        public static Config LoadConfigFile()
        {
            if (File.Exists(_configFileLocation))
            {
                String jsonString = File.ReadAllText(_configFileLocation);

                return JsonConvert.DeserializeObject<Config>(jsonString);
            }
            else
            {
                return new Config();
            }
        }
    }
}
