using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EAEmployeeTest.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            CurrentPage = GetInstance<HomePage>();
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<HomePage>().CheckIfLoginExist();
        }

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

        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<LoginPage>().Login(data.UserName,data.Password);
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

        [Then(@"I should see the username with hello")]
        public void ThenIShouldSeeTheUsernameWithHello()
        {
            if (CurrentPage.As<HomePage>().GetLoggedInUser().Contains("admin"))
                System.Console.WriteLine("Success Login");
            else
                System.Console.WriteLine("Unsuccessful Login");
        }


    }
}
