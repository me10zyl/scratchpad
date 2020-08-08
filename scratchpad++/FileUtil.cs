using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scratchpad__
{
    class FileUtil
    {

        public static String BASE_DIR = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\scratchpad";
        public static void SaveTmp(String tempString, String fileName) {
            Directory.CreateDirectory(BASE_DIR);
            FileStream f = File.Create(BASE_DIR + "\\" + fileName);
            byte[] bytes = System.Text.Encoding.Default.GetBytes(tempString);
            f.Write(bytes, 0, bytes.Length);
            f.Close();
        }

        public static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        public static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? null;
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return null;
        }


        public static String ReadTmp(String fileName){
            String path = BASE_DIR + "\\" + fileName;
            if (File.Exists(path))
            {
                String bytes = File.ReadAllText(path);
                return bytes;
            }
            return "";
        }

    }
}
