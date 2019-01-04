using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestAutomationFramework;
using TestAutomationFramework.Generators;

namespace UnitTests
{
    [Binding]
    public sealed class SpecFlowHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeFeature]
        public static void OneTimeSetUp()
        {
            Browser.Initialize();
            UserGenerator.Initialize();
        }

        [AfterScenario]
        public static void TearDown()
        {
            if (Pages.TopNavigation.IsLoggedIn())
                Pages.TopNavigation.LogOut();

            //if(UserGenerator.LastGeneratedUser != null)
            //    Browser.Goto("Account/DeleteUsers.cshtml");
        }

        [AfterFeature]
        public static void OneTimeTearDown()
        {
            Browser.Close();
        }
    }
}
