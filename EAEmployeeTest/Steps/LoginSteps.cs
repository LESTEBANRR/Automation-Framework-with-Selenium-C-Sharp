using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using TechTalk.SpecFlow;

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
            ScenarioContext.Current.Pending();
        }

        [Then(@"I click login link")]
        public void ThenIClickLoginLink()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I click kogin button")]
        public void ThenIClickKoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the username with hello")]
        public void ThenIShouldSeeTheUsernameWithHello()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
