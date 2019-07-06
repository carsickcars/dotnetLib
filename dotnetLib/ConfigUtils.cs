using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace dotnetLib
{
    public class ConfigUtils
    {
        /// <summary>
        /// Get someone value of AppSettings
        /// </summary>
        /// <param name="key"></param>
        public static string GetConfigValue(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] != null)
                return config.AppSettings.Settings[key].Value;
            else
                return string.Empty;
        }
        /// <summary>
        /// set new value for key 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetConfigValue(string key, string value)
        {
            //Added content in appSettings  eg: <add key="RegCode" value="0"/>  
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");//refresh new config   
        }
    }
}
