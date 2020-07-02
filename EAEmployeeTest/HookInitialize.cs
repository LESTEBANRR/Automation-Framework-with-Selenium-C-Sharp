using EAAutoFramework.Base;

namespace EAEmployeeTest
{
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize(): base(BrowserType.Chrome)
        {
            InitializeSettings();
            NavigateSite();
        }
    }
}
