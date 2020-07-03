using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EAEmployeeTest.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {       

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<HomePage>().CheckIfLoginExist();
        }

       
        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<LoginPage>().Login(data.UserName,data.Password);
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
