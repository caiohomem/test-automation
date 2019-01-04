using TechTalk.SpecFlow;
using TestAutomationFramework;

namespace SeleniumTests
{
    [Binding]
    public class RegisterSteps
    {
        public RegisterSteps()
        {
            //driver = new ChromeDriver();
        }

        [Given(@"the user accesses the site")]
        public void GivenTheUserAccessesTheSite()
        {
            Pages.About.Goto();
        }

        [When(@"I insert the username (.*) and password (.*)")]
        public void WhenIInsertTheUsernameAndPassword(string p0, string p1)
        {
            //myField = driver.FindElement(By.Name("username"));
            //myField.SendKeys(p0);
            //myField = driver.FindElement(By.Name("password"));
            //myField.SendKeys(p1);
        }

        [When(@"I click on register button")]
        public void WhenIClickOnRegisterButton()
        {
            //myField = driver.FindElement(By.Name("FormsButton2"));
            //myField.Click();
        }

        [Then(@"my account must be created and username must be shown (.*) on the screen")]
        public void ThenMyAccountMustBeCreatedAndUsernameMustBeShownOnTheScreen(string p0)
        {
            //myField = driver.FindElement(By.XPath($"//blockquote/blockquote[2]/blockquote"));
            //Assert.IsTrue(myField.Text.Contains(p0));
        }
    }
}