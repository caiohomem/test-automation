using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationFramework;

namespace UnitTests
{
    [Binding]
    public class TestWebSite
    {
        [Given(@"the user navigate to about page")]
        public void GivenTheUserNavigateToAboutPage()
        {
            Pages.About.Goto();
        }

        [Then(@"the title of the page must the about")]
        public void ThenTheTitleOfThePageMustTheAbout()
        {
            Assert.IsTrue(Pages.About.IsAt());
        }

        [Given(@"the user navigate to contact page")]
        public void GivenTheUserNavigateToContactPage()
        {
            Pages.Contact.Goto();
        }

        [Then(@"the title of the page must the contact")]
        public void ThenTheTitleOfThePageMustTheContact()
        {
            Assert.IsTrue(Pages.Contact.IsAt());
        }

        [Given(@"the user navigate to home page")]
        public void GivenTheUserNavigateToHomePage()
        {
            Pages.Home.Goto();
        }

        [Then(@"the title of the page must the home")]
        public void ThenTheTitleOfThePageMustTheHome()
        {
            Assert.IsTrue(Pages.Home.IsAt());
        }

        [Given(@"the user register a new random user")]
        public void GivenTheUserRegisterANewRandomUser()
        {
            Pages.Register.Goto();
            Pages.Register.RegisterNewUser();
            Pages.TopNavigation.LogOut();
        }

        [Given(@"try to login with the user")]
        public void GivenTryToLoginWithTheUser()
        {
            Pages.Login.Goto();
            Pages.Login.LogInAsLastRegisteredUser();
        }

        [Then(@"the user must be logged in")]
        public void ThenTheUserMustBeLoggedIn()
        {
            Assert.IsTrue(Pages.TopNavigation.LoggedInAsLastRegisteredUser());
        }


    }
}
