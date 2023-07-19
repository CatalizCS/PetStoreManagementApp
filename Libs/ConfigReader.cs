namespace PetStoreManagementApp.Libs
{
    public class ConfigReader
    {
        private PathManagement configFilePath;
        string currentDirectory = Directory.GetCurrentDirectory();
        private Dictionary<string, string> ConfigValue = new Dictionary<string, string>();

        public ConfigReader(string configFilePath)
        {
            this.configFilePath = new PathManagement(configFilePath);
        }

        public bool validateConfig()
        {
            try
            {
                string[] lines = File.ReadAllLines(Path.Combine(currentDirectory, configFilePath.fullPath));
                foreach (string line in lines)
                {
                    string[] keyValuePair = line.Split('=');
                    if (keyValuePair.Length != 2) return false;
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool ReadConfig()
        {
            string[] lines = File.ReadAllLines(Path.Combine(currentDirectory, configFilePath.fullPath));
            foreach (string line in lines)
            {
                string[] keyValuePair = line.Split('=');
                ConfigValue.Add(keyValuePair[0], keyValuePair[1]);
            }
            return true;
        }

        public string GetConfigValue(string key)
        {
            return ConfigValue[key];
        }

        public void SetConfigValue(string key, string value)
        {
            ConfigValue[key] = value;
        }

        public void SaveConfig()
        {
            try
            {
                string[] lines = new string[ConfigValue.Count];
                int i = 0;
                foreach (KeyValuePair<string, string> entry in ConfigValue)
                {
                    lines[i] = entry.Key + "=" + entry.Value;
                    i++;
                }
                File.WriteAllLines(Path.Combine(currentDirectory, configFilePath.fullPath), lines);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                ReadConfig();
                SaveConfig();
            }
        }
    }
}
