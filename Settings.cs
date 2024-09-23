using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ModbusObserverTool
{
    public class Settings
    {
        public static string Ip;
        public static int Port;
        public static byte SlaveId;
        public static int StartId;
        public static byte Range;

        private static void Validate()
        {
            var keys = ConfigurationManager.AppSettings.AllKeys;

            if (!keys.Contains(nameof(Ip)))
                AddUpdateAppSettings(nameof(Ip), "192.168.1.1");
            if (!keys.Contains(nameof(Port)))
                AddUpdateAppSettings(nameof(Port), "502");
            if (!keys.Contains(nameof(SlaveId)))
                AddUpdateAppSettings(nameof(SlaveId), "1");
            if (!keys.Contains(nameof(StartId)))
                AddUpdateAppSettings(nameof(StartId), "1000");
            if (!keys.Contains(nameof(Range)))
                AddUpdateAppSettings(nameof(Range), "10");
        }

        private static void AddUpdateAppSettings(string key, string value)
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
            catch (Exception e)
            {
            }
        }

        private static void RemoveAppSettings(params string[] keys)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                foreach (var key in keys) if (settings[key] != null) settings.Remove(key);

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (Exception e)
            {
            }
        }

        public static void LoadData()
        {
            try
            {
                Validate();

                var settings = ConfigurationManager.AppSettings;

                Ip = settings["Ip"];
                Port = int.Parse(settings["Port"]);
                SlaveId = byte.Parse(settings["SlaveId"]);
                StartId = int.Parse(settings["StartId"]);
                Range = byte.Parse(settings["Range"]);
            }
            catch (Exception e)
            {
            }
        }

        public static void SaveData()
        {
            try
            {
                AddUpdateAppSettings(nameof(Ip), Ip);
                AddUpdateAppSettings(nameof(Port), Port.ToString());
                AddUpdateAppSettings(nameof(SlaveId), SlaveId.ToString());
                AddUpdateAppSettings(nameof(StartId), StartId.ToString());
                AddUpdateAppSettings(nameof(Range), Range.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error saving data.\n" + e.Message);
            }
        }
    }
}
