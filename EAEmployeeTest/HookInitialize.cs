using EAAutoFramework.Base;
using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using TechTalk.SpecFlow;

namespace EAEmployeeTest
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize(): base(BrowserType.Chrome)
        {
            InitializeSettings();
            Sttings.ApplicationCon = Sttings.ApplicationCon.DBConnect(Sttings.AppConnectionString);
        }
        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }
    }
}
