using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFramework.ConfigElement
{
    public class EAFrameworkElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name => (string)base["name"];

        [ConfigurationProperty("aut", IsRequired = true)]
        public string AUT => (string)base["aut"];

        [ConfigurationProperty("browser", IsRequired = true)]
        public string Browser => (string)base["browser"];

        [ConfigurationProperty("testType", IsRequired = true)]
        public string TesType => (string)base["testType"];

        [ConfigurationProperty("isLog", IsRequired = true)]
        public string IsLog => (string)base["IsLog"];

        [ConfigurationProperty("logPath", IsRequired = true)]
        public string LogPath => (string)base["logPath"];

        [ConfigurationProperty("autConnectionString", IsRequired = true)]
        public string AUTDBConnectionString => (string)base["autConnectionString"];

    }
}
