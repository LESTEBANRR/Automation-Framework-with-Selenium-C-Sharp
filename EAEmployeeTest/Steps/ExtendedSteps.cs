using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using TechTalk.SpecFlow;

namespace EAEmployeeTest.Steps
{
    [Binding]
    internal class ExtendedSteps: BaseStep
    {
        [Then(@"I click (.*) link")]
        public void ThenIClickLink(string linkName)
        {
            switch (linkName)
            {
                case "login":
                    CurrentPage = CurrentPage.As<HomePage>().ClickLogin();
                    break;
                case "employeeList":
                    CurrentPage = CurrentPage.As<HomePage>().ClickEmployeeList();
                    break;
            }

        }
        [Then(@"I click (.*) button")]
        public void ThenIClickKoginButton(string button)
        {
            switch (button)
            {
                case "login":
                    CurrentPage = CurrentPage.As<LoginPage>().ClickLoginButton();
                    break;
                case "createnew":
                    CurrentPage = CurrentPage.As<EmployeeListPage>().ClickCreateNew();
                    break;
                case "create":
                    CurrentPage.As<CreateEmployeePage>().ClickCreateButton();
                    break;

            }

        }

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            CurrentPage = GetInstance<HomePage>();
        }

    }
}
