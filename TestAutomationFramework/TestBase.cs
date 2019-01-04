using NUnit.Framework;
using TestAutomationFramework.Generators;

namespace TestAutomationFramework
{    
    public class TestBase
    {
        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Browser.Initialize();
            UserGenerator.Initialize();
        }

        [TearDown]
        public static void TearDown()
        {
            if (Pages.TopNavigation.IsLoggedIn())
                Pages.TopNavigation.LogOut();

            //if(UserGenerator.LastGeneratedUser != null)
            //    Browser.Goto("Account/DeleteUsers.cshtml");
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Browser.Close();
        }
    }
}