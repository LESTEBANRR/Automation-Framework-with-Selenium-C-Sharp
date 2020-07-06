using EAAutoFramework.Base;
using EAAutoFramework.ConfigElement;
using System;

namespace EAAutoFramework.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings(string settingType)
        {
            Sttings.AUT = EaTestConfiguration.EASettings.TestSettings[settingType].AUT;
            //Sttings.Build = buildName.Value.ToString();
            Sttings.TestType = EaTestConfiguration.EASettings.TestSettings[settingType].TesType;
            Sttings.IsLog = EaTestConfiguration.EASettings.TestSettings[settingType].IsLog;
           // Sttings.IsReporting = isreport.Value.ToString();
            Sttings.LogPath = EaTestConfiguration.EASettings.TestSettings[settingType].LogPath;
            Sttings.AppConnectionString = EaTestConfiguration.EASettings.TestSettings[settingType].AUTDBConnectionString;
            Sttings.BrowserType=(BrowserType)Enum.Parse(typeof(BrowserType), EaTestConfiguration.EASettings.TestSettings[settingType].Browser);
        }
    }
}
