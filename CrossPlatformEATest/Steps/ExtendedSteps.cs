using EAAutoFramework.Base;
using EAAutoFramework.Config;
using CrossPlatformEATest.Pages;
using TechTalk.SpecFlow;
using EAAutoFramework.Helpers;
using System.Threading;

namespace CrossPlatformEATest.Steps
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
                    Thread.Sleep(2000);
                    DriverContext.Driver.Close();
                    break;

            }

        }

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            CurrentPage = GetInstance<HomePage>();
        }

        [Given(@"I delete employee '(.*)' before i start running test")]
        public void GivenIDeleteEmployeeBeforeIStartRunningTest(string employeeName)
        {
            string query = "delete from Employees where Name='"+employeeName+"'";
            Sttings.ApplicationCon.ExecuteQuery(query);
        }


    }
}
