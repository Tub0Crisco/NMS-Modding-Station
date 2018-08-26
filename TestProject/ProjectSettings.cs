using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NMSModdingStation
{
    class ProjectSettings
    {
        //
        //get project settings file path
        public static string getProjectSettingsFile(string project)
        {
            string[] path = project.Split(new char[] { '\\' });
            string modSettingsPath = project + "\\" + path.Last() + ".nmf";
            return modSettingsPath;
        }

        //
        //setup settings file and get project settings
        public static List<KeyValuePair<string, string>> getProjectSettings(string project)
        {
            string modSettingsPath = getProjectSettingsFile(project);
            string modSettingsName = Path.GetFileNameWithoutExtension(modSettingsPath);
            modSettingsName = modSettingsName.Replace(" ", "");
            modSettingsName = modSettingsName.Replace(":", "");
            string[] modSettings;
            string[] lines = { "modAuthor:", "modName:" + modSettingsName, "versionControl:false", "version:0.1" };
            bool fileFound = true;
            bool fileFilled = true;
            List<KeyValuePair<string, string>> settings = new List<KeyValuePair<string, string>>();

            try
            {
                modSettings = File.ReadAllLines(modSettingsPath);
            }
            catch (FileNotFoundException)
            {
                fileFound = false;
                fileFilled = false;
            }
            catch (UnauthorizedAccessException)
            {
                return null;
            }

            if (!fileFound)
            {
                File.Create(modSettingsPath).Close();
                fileFound = true;
            }

            if (File.ReadAllLines(modSettingsPath).Length < 4)
            {
                File.WriteAllLines(modSettingsPath, lines);
                fileFilled = true;
            }

            if (fileFound && fileFilled)
            {
                modSettings = File.ReadAllLines(modSettingsPath);
                if(modSettings.Length < 4)
                {
                    return null;
                }
                int index = 0;
                foreach (string setting in modSettings)
                {
                    if (setting.Contains(":"))
                    {
                        string key = setting.Split(new char[] { ':' })[0];
                        string value = setting.Split(new char[] { ':' })[1];
                        settings.Insert(index, new KeyValuePair<string, string>(key, value));
                        index++;
                    }else
                    {
                        return null;
                    }
                }
            }
            return settings;
        }

        //
        //Save settings to project settings file
        public static void saveProjectSettings(string path, string modAuthor, string modName, string versionControl, string version)
        {
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());

            foreach(char c in invalid)
            {
                modAuthor = modAuthor.Replace(c.ToString(), "");
                modName = modName.Replace(c.ToString(), "");
            }
            string[] lines = { "modAuthor:" + modAuthor, "modName:" + modName, "versionControl:" + versionControl, "version:" + version };
            File.WriteAllLines(path, lines);
        }


    }
}
