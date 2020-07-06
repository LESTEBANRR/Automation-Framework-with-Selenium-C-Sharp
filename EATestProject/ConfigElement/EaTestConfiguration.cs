using System.Configuration;

namespace EAAutoFramework.ConfigElement
{
    public class EaTestConfiguration : ConfigurationSection
    {
        private static EaTestConfiguration _testConfig = (EaTestConfiguration)ConfigurationManager.GetSection("EATestConfiguration");

        public static EaTestConfiguration EASettings { get { return _testConfig; } }

        [ConfigurationProperty("testSettings")]
        public EAFrameworkElementCollection TestSettings{ get { return (EAFrameworkElementCollection)base["testSettings"]; } }

    }
}
